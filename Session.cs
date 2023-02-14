using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_SeaAnimalGame
{
    class Session
    {
        static string sessionname;
        public static string SessionName
        { 
            get
            {
                return sessionname;
            }
            set
            {
                sessionname = value;
                //set the username value from what user store in PlayerNamePage textbox
            }
        }
    }
}
