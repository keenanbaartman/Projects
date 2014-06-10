using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_AddIn
{
    class PolicyClass
    {
        string policyNum;

        public string PolicyNum
        {
            get { return policyNum; }
            set { policyNum = value; }
        }
        string policyType;

        public string PolicyType
        {
            get { return policyType; }
            set { policyType = value; }
        }

        string polDateFollowup;

        public string PolDateFollowup
        {
            get { return polDateFollowup; }
            set { polDateFollowup = value; }
        }

        string polID;

        public string PolID
        {
            get { return polID; }
            set { polID = value; }
        }

        public PolicyClass() { }
    }
}
