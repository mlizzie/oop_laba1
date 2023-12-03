namespace ConsoleApp1
{
    public class ContTypeCol
    {
        // Приватное поле для хранения списка типов контактов
        private List<ContType> _lst;

        // Свойство для получения количества типов контактов
        public int Count
        {
            get { return _lst.Count; }
        }

        // Индексатор для доступа к типам контактов по индексу
        public ContType this[int index]
        {
            get
            {
                return _lst[index];
            }
        }

        // Конструктор класса
        public ContTypeCol()
        {
            _lst = new List<ContType>();
        }

        // Метод для добавления нового типа контакта
        public void Add(ContType contType)
        {
            _lst.Add(contType);
        }

        // Метод для очистки списка типов контактов
        public void Clear()
        {
            _lst.Clear();
        }
    }
}
