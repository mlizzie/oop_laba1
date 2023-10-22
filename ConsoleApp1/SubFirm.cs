namespace ConsoleApp1
{
    public class SubFirm
    {
        private string bossName;
        private string email;
        private string name;
        private string ofcBossName;
        private string tel;

        public List<Contact> contacts { get; set; }
        public SbFirmType SbFirmtpy { get; set; }

        public string BossName
        {
            get
            {
                return bossName;
            }
            set
            {
                bossName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string OfcBossName
        {
            get
            {
                return ofcBossName;
            }
            set
            {
                ofcBossName = value;
            }
        }

        public string Tel
        {
            get
            {
                return tel;
            }
            set
            {
                tel = value;
            }
        }

        public void AddCont(Contact new_contact)
        {
            contacts.Add(new_contact);
        }

        public bool ExistContact(Contact contact_for_search)
        {
            foreach (Contact cur_contact in contacts)
            {
                if (cur_contact == contact_for_search)
                    return true;
            }
            return false;
        }

        public bool isYourType(SbFirmType _type)
        {
            if (SbFirmtpy.IsMain == _type.IsMain)
            {
                return true;
            }
            return false;
        }

        public SubFirm()
        {
            contacts = new List<Contact>();
        }
    }
}
