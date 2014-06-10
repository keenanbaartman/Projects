using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_AddIn
{
    class EmailClass
    {
        string mailID;
        string body;
        string employeeID;
        string senderEmailAddress;
        string subject;
        DateTime emailDate;

        public DateTime EmailDate
        {
            get { return emailDate; }
            set { emailDate = value; }
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public string SenderEmailAddress
        {
            get { return senderEmailAddress; }
            set { senderEmailAddress = value; }
        }

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string MailID
        {
            get { return mailID; }
            set { mailID = value; }
        }

        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        public EmailClass() { }

        public EmailClass(string body, string empID, string email)
        {
            Body = body;
            EmployeeID = empID;
            SenderEmailAddress = email;
        }
    }
}
