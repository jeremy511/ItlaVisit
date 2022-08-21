using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTier
{
    public class E_VISIT
    {
        private int _ID_VISIT;
        private string _CODE;
        private string _NAME_VISIT;
        private string _LASTNAME;
        private int _ID_CAREER;
        private string _CAREER;
        private string _MAIL;
        private int _ID_BUILDING;
        private string _BUILDING;
        private int _ID_SECTION;
        private string _SECTION;
        private DateTime _CHECKIN;
        private DateTime _CHECKOUT;
        private string _REASON;


        public int ID_VISIT { get => _ID_VISIT; set => _ID_VISIT = value; }

        public string CODE { get => _CODE; set => _CODE = value; }

        public string NAME { get => _NAME_VISIT; set => _NAME_VISIT = value; }

        public string LASTNAME { get => _LASTNAME; set => _LASTNAME = value; }

        public int ID_CAREER { get => _ID_CAREER; set => _ID_CAREER = value; }

        public string CAREER { get => _CAREER; set => _CAREER = value; }

        public string MAIL { get => _MAIL; set => _MAIL = value; }

        public int ID_BUILDING { get => _ID_BUILDING; set => _ID_BUILDING = value; }

        public string BUILDING { get => _BUILDING; set => _BUILDING = value; }

        public int ID_SECTION { get => _ID_SECTION; set => _ID_SECTION = value; }

        public string SECTION { get => _SECTION; set => _SECTION = value; }

        public DateTime CHECKIN { get => _CHECKIN; set => _CHECKIN = value; }

        public DateTime CHECKOUT { get => _CHECKOUT; set => _CHECKOUT = value; }

        public string REASON { get => _REASON; set => _REASON = value; }

    }
}
