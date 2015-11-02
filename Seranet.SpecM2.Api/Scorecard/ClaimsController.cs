﻿using Seranet.SpecM2.Data;
using Seranet.SpecM2.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Net;
using System.Web.Configuration;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;  

namespace Seranet.SpecM2.Api.Scorecard
{
    public class ClaimsController : BaseApiController
    {
        //Shift this method from here elsewhere
        private Status getStatus(int k)
        {

            Status s = Status.PENDING;
            switch (k)
            {
                case 1:
                    s = Status.APPROVED;
                    break;
                case 2:
                    s = Status.REJECTED;
                    break;
                case 3:
                    s = Status.PENDING;
                    break;
                case 4:
                    s = Status.NOTAPPLICABLE;
                    break;

            }

            return s;
        }

        // GET api/claims
        public IEnumerable<Claim> Get()
        {
            return context.Claims;
        }

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        public Claim Get(int id)
        {
            Claim claim = context.Claims.Include("Practice").Where(p => p.Id == id).FirstOrDefault();
         return claim;
        }

           [HttpPost]
         public void post([FromBody] Claim[] claim)
         {
             for (int i = 0; i < claim.Length; i++)
             {
                 var claimToAdd = claim[i];
                 claimToAdd.GUID = Guid.NewGuid();
                 claimToAdd.CreatedTime = DateTime.Now;
                 claimToAdd.Practice = context.Practices.FirstOrDefault(t => t.Id == claimToAdd.Practice.Id);
                 claimToAdd.Project = context.Projects.FirstOrDefault(t => t.Id == claimToAdd.Project.Id);
                 claimToAdd.Status = getStatus(3);
                 context.Claims.Add(claimToAdd);
                 context.SaveChanges();
             }
         }
   
     [HttpPost]
         public void post(int status) { 
        
         }

         [Route("api/claims/email")]
         [HttpPost]
         public void sendmail()
         {
             var FromEmailid = SpecSettings.UserMail();
             var pass = SpecSettings.UserMailPassword();
             var oSr = new StreamReader(HttpContext.Current.Request.InputStream);
             var sContent = oSr.ReadToEnd();
             var obj = JObject.Parse(sContent);
             var to = (string)obj["to"];
           
             String[] Multi = to.Split(',');
             List<String> tom=new List<string>();
             foreach (String Multimailid in Multi)
             {
                 tom.Add(Multimailid);
             }
          
             var projectName = (string)obj["projectIdentity"];

             Task.Run(() =>
             {
                 var exchangeService = new O365ExchangeService(FromEmailid, pass);
                 exchangeService.SendEmail("SPEC Review on " + projectName,
                                           projectName + " team requested to review their practices.",
                                           tom);
             });
          }
        
        
        [HttpPut]
        public void put(dynamic claim)
        {

            int claimId = claim.claimId;
            var claimtoaddto = context.Claims.Where(p => p.Id == claimId).FirstOrDefault();

            context.Entry(claimtoaddto).CurrentValues.SetValues(claim.claimMessage);
            context.SaveChanges();

        }

        }
}
