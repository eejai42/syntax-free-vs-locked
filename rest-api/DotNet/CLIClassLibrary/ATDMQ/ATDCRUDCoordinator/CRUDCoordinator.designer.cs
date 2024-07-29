using AirtableDirect.CLI.Lib.DataClasses;
using AirtableToDotNet.APIWrapper;
using System;
using System.Linq;
using System.Collections.Generic;
using YP.SassyMQ.Lib.RabbitMQ;
using System.Security.Claims;

namespace CLIClassLibrary.ATDMQ
{
	public partial class ATDCRUDCoordinator : ATDActorBase
    {
       public ClaimsIdentity UserIdentity { get; set; } // IsUpdate: false
       public virtual void ResetRabbitSassyMQConfiguration(StandardPayload Payload) => throw new NotImplementedException();        
        private string WrapCRUDCoordinatorResetRabbitSassyMQConfigurationWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public virtual void ResetJWTSecretKey(StandardPayload Payload) => throw new NotImplementedException();        
        private string WrapCRUDCoordinatorResetJWTSecretKeyWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      

    }
}
					    