using System.Collections;

namespace ConsoleApp1
{
    public class SubFirmTypeCol : IEnumerator
    {
        private List<SbFirmType> _lst;
        private int count;

        public object Current
        {
            get { return _lst[count]; }
        }
        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }
        public SbFirmType this[int index]
        {
            get { return _lst[index]; }
            set { _lst[index] = value; }
        }
        public void Add(SbFirmType new_type)
        {
            _lst.Add(new_type);
        }
        public void Dispose()
        {
            count = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (count == _lst.Count - 1)
            {
                Reset();
                return false;
            }

            count++;
            return true;
        }

        public void Reset()
        {
            count = -1;
        }

        public void SbFirmTypeCol()
        {
            _lst = new List<SbFirmType>();
        }

    }
}
