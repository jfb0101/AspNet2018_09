using System.Collections.Generic;
using Sakila.Security;

namespace Sakila.Admin.Models {
    public class AssignRoleToUserViewModel {
        public List<ApplicationUser> UserList {get;set;}
        public List<ApplicationRole> RoleList {get;set;}
        public string SelectedUserId {get;set;}
        public string SelectedRoleId {get;set;}
        public bool? Assigned {get;set;}
    }
}