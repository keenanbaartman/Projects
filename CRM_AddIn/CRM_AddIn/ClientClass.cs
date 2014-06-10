using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_AddIn
{
    class ClientClass
    {
        string clientID;

        public string ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }
        string clientName;

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        string clientSurname;

        public string ClientSurname
        {
            get { return clientSurname; }
            set { clientSurname = value; }
        }
        string clientEmail;

        public string ClientEmail
        {
            get { return clientEmail; }
            set { clientEmail = value; }
        }

        public ClientClass() { }

        public ClientClass(string id,string name, string sname, string email)
        {
            ClientID = id;
            ClientName = name;
            ClientSurname = sname;
            ClientEmail = email;
        }

    }
}
