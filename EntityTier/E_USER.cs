using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTier
{
    public class E_USER
    {
        private int _ID_USER;
        private string _NAME;
        private string _LASTNAME;
        private DateTime _BIRTHDATE;
        private string _USER_TYPE;
        private string _USER;
        private string _PASSWORD;

        public int ID_USER { get => _ID_USER; set => _ID_USER = value;}
        public string NAME { get => _NAME; set => _NAME = value;}
        public string LASTNAME { get => _LASTNAME; set => _LASTNAME = value;}
        public DateTime BIRTHDATE { get => _BIRTHDATE; set => _BIRTHDATE = value;}
        public string USER_TYPE { get => _USER_TYPE; set => _USER_TYPE = value;}
        public string USER { get => _USER; set => _USER = value; }
        public string PASSWORD { get => _PASSWORD; set => _PASSWORD = value;}
    }
}
