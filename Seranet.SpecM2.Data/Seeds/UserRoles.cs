using Seranet.SpecM2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seranet.SpecM2.Data.Seeds
{
    class UserRoles
    {
        public UserRole[] userRoles;

        public UserRoles() {

            userRoles = new UserRole[6];

            userRoles[0] = new UserRole { Id = 1, UserRoleType = UserRoleType.ADMIN, GUID = Guid.NewGuid(), UserName = "krishnakripaj", UserEmail ="some@99x.lk"};
            userRoles[1] = new UserRole { Id = 2, UserRoleType = UserRoleType.ADMIN, GUID = Guid.NewGuid(), UserName = "hasithy",UserEmail ="some@99x.lk" };
            userRoles[2] = new UserRole { Id = 3, UserRoleType = UserRoleType.AUDITOR, GUID = Guid.NewGuid(), UserName = "hasithy", UserEmail = "some@99x.lk" };
            userRoles[3] = new UserRole { Id = 4, UserRoleType = UserRoleType.AUDITOR, GUID = Guid.NewGuid(), UserName = "madushib", UserEmail = "some@99x.lk" };
            userRoles[4] = new UserRole { Id = 5, UserRoleType = UserRoleType.ADMIN, GUID = Guid.NewGuid(), UserName = "surangab", UserEmail = "some@99x.lk" };
            userRoles[5] = new UserRole { Id = 6, UserRoleType = UserRoleType.AUDITOR, GUID = Guid.NewGuid(), UserName = "surangab", UserEmail = "some@99x.lk" };

        }
    }

}
