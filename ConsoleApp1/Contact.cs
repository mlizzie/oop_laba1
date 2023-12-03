namespace ConsoleApp1
{
    public class Contact : ICloneable
    {
        private DateTime _beginDt;
        private DateTime _endDt;
        private string _descr;
        private string _dataInfo;
        private ContType _tpy;

        public DateTime BeginDt
        {
            get { return _beginDt; }
            set { _beginDt = value; }
        }

        public DateTime EndDt
        {
            get { return _endDt; }
            set { _endDt = value; }
        }

        public string Descr
        {
            get { return _descr; }
            set { _descr = value; }
        }

        public string DataInfo
        {
            get { return _dataInfo; }
            set { _dataInfo = value; }
        }

        public ContType Tpy
        {
            get { return _tpy; }
            set { _tpy = value; }
        }

        // Конструктор класса
        public Contact(DateTime beginDt, DateTime endDt, string descr, string dataInfo, ContType tpy)
        {
            _beginDt = beginDt;
            _endDt = endDt;
            _descr = descr;
            _dataInfo = dataInfo;
            _tpy = tpy;
        }

        // Метод для клонирования контакта
        public object Clone()
        {
            return new Contact(_beginDt, _endDt, _descr, _dataInfo, new ContType { Name = _tpy.Name, Note = _tpy.Note });
        }

        // Перегрузка оператора ==
        public static bool operator ==(Contact c1, Contact c2)
        {
            if (ReferenceEquals(c1, c2))
            {
                return true;
            }

            if (c1 is null || c2 is null)
            {
                return false;
            }

            return c1._beginDt == c2._beginDt && c1._endDt == c2._endDt && c1._descr == c2._descr
                   && c1._dataInfo == c2._dataInfo && Equals(c1._tpy, c2._tpy);
        }

        // Перегрузка оператора !=
        public static bool operator !=(Contact c1, Contact c2)
        {
            return !(c1 == c2);
        }
    }
}
