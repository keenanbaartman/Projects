using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_AddIn
{
    class Policy_Document
    {
        string pdoc_id;

        public string Pdoc_id
        {
            get { return pdoc_id; }
            set { pdoc_id = value; }
        }

        string pdoc_title;

        public string Pdoc_title
        {
            get { return pdoc_title; }
            set { pdoc_title = value; }
        }

        string pdoc_desc;

        public string Pdoc_desc
        {
            get { return pdoc_desc; }
            set { pdoc_desc = value; }
        }

        string pdoc_path;

        public string Pdoc_path
        {
            get { return pdoc_path; }
            set { pdoc_path = value; }
        }

        string pdoc_date_added;

        public string Pdoc_date_added
        {
            get { return pdoc_date_added; }
            set { pdoc_date_added = value; }
        }

        string pol_id;

        public string Pol_id
        {
            get { return pol_id; }
            set { pol_id = value; }
        }

        string cl_id;

        public string Cl_id
        {
            get { return cl_id; }
            set { cl_id = value; }
        }

        string crmg_id;

        public string Crmg_id
        {
            get { return crmg_id; }
            set { crmg_id = value; }
        }

        string crmg_ref_num;

        public string Crmg_ref_num
        {
            get { return crmg_ref_num; }
            set { crmg_ref_num = value; }
        }

        public Policy_Document() { }
    }
}
