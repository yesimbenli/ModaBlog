namespace DAL.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DAL.MyContext context)
        {
            #region CreateRoles
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole() { Name = "Admin" });
            #endregion
            if (context.Users.Count() == 0)
            {
                #region CreateUsers
                UserStore<IdentityUser> us = new UserStore<IdentityUser>(new MyContext());
                UserManager<IdentityUser> um = new UserManager<IdentityUser>(us);

                IdentityUser user1 = new IdentityUser();
                user1.Email = "admin@erp2.com";
                user1.UserName = "admin@erp2.com";
                um.Create(user1, "123456");
                #endregion
                #region AssignUsersToRoles
                um.AddToRole(user1.Id, "Admin");
                #endregion
            }
        }
    }
}
