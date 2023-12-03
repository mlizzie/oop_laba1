namespace ConsoleApp1
{
    public class SubFirm
    {
        private string _name;
        private string _bossName;
        private string _ofcBossName;
        private string _tel;
        private string _email;
        private SbFirmType _tpy;
        private List<Contact> _conts;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string BossName
        {
            get { return _bossName; }
            set { _bossName = value; }
        }

        public string OfcBossName
        {
            get { return _ofcBossName; }
            set { _ofcBossName = value; }
        }

        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public SbFirmType SbFirmTpy
        {
            get { return _tpy; }
            set { _tpy = value; }
        }

        public List<Contact> Conts
        {
            get { return _conts; }
            set { _conts = value; }
        }

        public int CountCont
        {
            get { return _conts?.Count ?? 0; }
        }

        public bool IsMain
        {
            get { return _tpy?.IsMain ?? false; }
        }

        // Конструктор класса
        public SubFirm(string name, string bossName, string ofcBossName, string tel, string email, SbFirmType tpy)
        {
            _name = name;
            _bossName = bossName;
            _ofcBossName = ofcBossName;
            _tel = tel;
            _email = email;
            _tpy = tpy;
            _conts = new List<Contact>();
        }

        // Метод для добавления контакта
        public void AddCont(Contact contact)
        {
            _conts.Add(contact);
        }

        // Метод для проверки существования контакта
        public bool ExistContact(Contact contact)
        {
            return _conts.Any(c => c == contact);
        }

        // Метод для проверки принадлежности типу фирмы
        public bool IsYourType(SbFirmType type)
        {
            return _tpy == type;
        }
    }
}
