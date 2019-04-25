using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Models
{
    public class Email : IDataErrorInfo
    {
        public string EmailUser { get; set; }
        public Email()
        {
            EmailUser = "";
        }
        public string this[string columnName]
        {
            get
            {
                string errors = "";
                switch (columnName)
                {
                    case "EmailUser":
                        break;
                    default:
                        break;
                }

                return errors;
            }
        }

        public string Error { get; set; }
    }
}
