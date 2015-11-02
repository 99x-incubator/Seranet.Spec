using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seranet.SpecM2.Api.Scorecard
{
    public class O365ExchangeService
    {
         private readonly ExchangeService _exchangeService;

        public O365ExchangeService(string user, string password)
        {
            _exchangeService = new ExchangeService(ExchangeVersion.Exchange2007_SP1)
            {
                Credentials = new WebCredentials(user, password),
                TraceEnabled = true,
                TraceFlags = TraceFlags.All
            };
            _exchangeService.AutodiscoverUrl(user, RedirectionUrlValidationCallback);
        }

        public void SendEmail(string subject, string body, List<string> recipients)
        {
            var emailMessage = new EmailMessage(_exchangeService)
            {
                Subject = subject,
                Body = new MessageBody(BodyType.HTML, body)
            };

            foreach (var recipient in recipients)
            {
                emailMessage.ToRecipients.Add(recipient);
            }
            emailMessage.Send();
        }

        private static bool RedirectionUrlValidationCallback(string redirectionUrl)
        {
            var result = false;
            var redirectionUri = new Uri(redirectionUrl);
            if (redirectionUri.Scheme == "https")
            {
                result = true;
            }
            return result;
        }
    }
    
}
