namespace ConsoleApp1
{
    public class Contact
    {
        private string beginDt;
        private string endDt;
        private string dateInto;
        private string descr;
        private ContType cntType;

        public Contact(ContType type)
        {
            cntType = type;
        }

        public string BeginDT
        {
            get
            {
                return beginDt;
            }
            set
            {
                beginDt = value;
            }
        }

        public string EndDt
        {
            get
            {
                return endDt;
            }
            set
            {
                endDt = value;
            }
        }

        public string DateInto
        {
            get
            {
                return dateInto;
            }
            set
            {
                dateInto = value;
            }
        }

        public string Descr
        {
            get
            {
                return descr;
            }
            set
            {
                descr = value;
            }
        }

        public ContType ContType
        {
            get
            {
                return cntType;
            }
            set
            {
                cntType = value;
            }
        }

        public Contact Clone()
        {
            ContType type = cntType;
            Contact con = new Contact(type);
            con.beginDt = beginDt;
            con.dateInto = dateInto;
            con.descr = descr;
            con.endDt = endDt;
            con.cntType = cntType;
            return con;
        }

        public static bool operator ==(Contact lhs, Contact rhs)
        {
            if (lhs.beginDt == rhs.beginDt &&
            lhs.cntType == rhs.cntType &&
            lhs.dateInto == rhs.dateInto &&
            lhs.descr == rhs.descr &&
            lhs.endDt == rhs.endDt)
                return true;

            else return false;
        }
        public static bool operator !=(Contact lhs, Contact rhs)
        {
            return !(lhs == rhs);
        }
    }
}
