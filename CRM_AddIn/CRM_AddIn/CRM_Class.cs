using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_AddIn
{
    class CRM_Class
    {
        string clientPolicyID;

        public string ClientPolicyID
        {
            get { return clientPolicyID; }
            set { clientPolicyID = value; }
        }
        string crmID;

        public string CrmID
        {
            get { return crmID; }
            set { crmID = value; }
        }
        string crmDetails;

        public string CrmDetails
        {
            get { return crmDetails; }
            set { crmDetails = value; }
        }
        string policyNum;

        public string PolicyNum
        {
            get { return policyNum; }
            set { policyNum = value; }
        }
        string clientID;

        public string ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public CRM_Class() { }
    }
}
