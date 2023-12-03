namespace ConsoleApp1
{
    public class ContType
    {
        // Приватные поля
        private string _name;
        private string _note;

        // Свойства для доступа к полям
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }
    }
}
