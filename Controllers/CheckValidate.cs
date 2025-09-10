using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangMayTinh.Controllers
{
    public class CheckValidate
    {
        private static CheckValidate instance;

        public static CheckValidate Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CheckValidate();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public CheckValidate() { }

        public bool CheckTextBoxContainOnlyNum(TextBox textBoxName)
        {
            Regex regexOnlyNum = new Regex(@"^\d+$");
            
            return false;
        }

        public bool IsEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
