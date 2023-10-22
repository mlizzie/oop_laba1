namespace ConsoleApp1
{
    public class ContTypeCol
    {
        private List<ContType> _lst;

        public ContType this[int index]
        {
            get { return _lst[index]; }
            set { _lst[index] = value; }
        }
        public void Add(ContType new_contact)
        {
            _lst.Add(new_contact);
        }
        public void Clear()
        {
            _lst.Clear();
        }
        public ContTypeCol()
        {
            _lst = new List<ContType>();
        }
    }
}
