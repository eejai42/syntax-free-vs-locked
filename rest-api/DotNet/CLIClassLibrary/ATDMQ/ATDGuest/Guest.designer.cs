using AirtableDirect.CLI.Lib.DataClasses;
using AirtableToDotNet.APIWrapper;
using System;
using System.Linq;
using System.Collections.Generic;
using YP.SassyMQ.Lib.RabbitMQ;
using System.Security.Claims;

namespace CLIClassLibrary.ATDMQ
{
	public partial class ATDGuest : ATDActorBase
    {
       public ClaimsIdentity UserIdentity { get; set; } // IsUpdate: false
       public virtual void RequestToken(StandardPayload Payload) => throw new NotImplementedException();        
        private string WrapGuestRequestTokenWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public virtual void ValidateTemporaryAccessToken(StandardPayload Payload) => throw new NotImplementedException();        
        private string WrapGuestValidateTemporaryAccessTokenWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public virtual void WhoAmI(StandardPayload Payload) => throw new NotImplementedException();        
        private string WrapGuestWhoAmIWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public virtual void WhoAreYou(StandardPayload Payload) => throw new NotImplementedException();        
        private string WrapGuestWhoAreYouWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      
 // IsUpdate: false
       public virtual void StoreTempFile(StandardPayload Payload) => throw new NotImplementedException();        
        private string WrapGuestStoreTempFileWhere(string airtableWhere)
        {
                
        
        
            // AirtableWhere: 
            return airtableWhere; 
        }

      

    }
}
					    