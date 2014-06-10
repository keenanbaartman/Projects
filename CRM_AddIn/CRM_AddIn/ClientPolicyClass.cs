using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_AddIn
{
    class ClientPolicyClass
    {
        string clientPolicyID;

        public string ClientPolicyID
        {
            get { return clientPolicyID; }
            set { clientPolicyID = value; }
        }
        string clientID;

        public string ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }
        string policyNum;

        public string PolicyNum
        {
            get { return policyNum; }
            set { policyNum = value; }
        }

        public ClientPolicyClass() { }

    }
}
