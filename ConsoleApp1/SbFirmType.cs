namespace ConsoleApp1
{
    public class SbFirmType
    {
        // Приватные поля
        private bool _isMain;
        private string _name;

        // Свойства для доступа к полям
        public bool IsMain
        {
            get { return _isMain; }
            set { _isMain = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
