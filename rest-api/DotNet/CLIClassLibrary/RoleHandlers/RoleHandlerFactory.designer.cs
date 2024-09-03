using CLIClassLibrary.AirtableAPI;
using SSoTme.Default.Lib.CLIHandler;
using System;
using System.Collections.Generic;
using System.Text;
using CLIClassLibrary.RoleHandlers.ATDHandlers;
using CLIClassLibrary.RoleHandlers.RESTHandlers;

namespace CLIClassLibrary.RoleHandlers
{
    public static partial class RoleHandlerFactory
    {
        public static RoleHandlerBase CreateHandler(string runAs, string restEndpoint)
        {        
            if (String.IsNullOrEmpty(runAs)) runAs = EAPICLIHandler.GetCurrentUserRoleName();
            if (String.IsNullOrEmpty(restEndpoint)) return RoleHandlerFactory.CallATD(runAs);
            else return RoleHandlerFactory.InvokeRest(runAs, restEndpoint);
        }
        
        public static RoleHandlerBase InvokeRest(string runAs, string restEndpoint)
        {
            switch (runAs.ToLower())
            {
                
                    
                case "guest":
                    return new GuestRESTCLIHandler(restEndpoint);

                    
                case "crudcoordinator":
                    return new CRUDCoordinatorRESTCLIHandler(restEndpoint);

                    
                case "user":
                    return new UserRESTCLIHandler(restEndpoint);

                    
                case "admin":
                    return new AdminRESTCLIHandler(restEndpoint);


                default:
                    throw new Exception($"Can't find CLIHandler for {runAs} actor.");
            }
        }
        
        public static RoleHandlerBase CallATD(string runAs) {
            ATDKey.ProjectName = "app9f8btt7lSPTpw1";
            var atdKey = EAPICLIHandler.GetCurrentKey(runAs);
            switch (runAs.ToLower())
            {
                
                    
                case "guest":
                    return new GuestCLIHandler(atdKey);

                    
                case "crudcoordinator":
                    return new CRUDCoordinatorCLIHandler(atdKey);

                    
                case "user":
                    return new UserCLIHandler(atdKey);

                    
                case "admin":
                    return new AdminCLIHandler(atdKey);


                default:
                    throw new Exception($"Can't find CLIHandler for {runAs} actor.");
            }
        }

        public static void ListRoles(StringBuilder sbHelpBuilder)
        {
           
            sbHelpBuilder.AppendLine(" - Guest");
            sbHelpBuilder.AppendLine(" - CRUDCoordinator");
            sbHelpBuilder.AppendLine(" - User");
            sbHelpBuilder.AppendLine(" - Admin");
        }
    }
}
