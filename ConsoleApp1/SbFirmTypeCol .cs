using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SbFirmTypeCol : IDisposable, IEnumerable<SbFirmType>, IEnumerator<SbFirmType>
    {
        private List<SbFirmType> _lst;
        private int _currentIndex = -1;

        public SbFirmTypeCol()
        {
            _lst = new List<SbFirmType>();
        }

        public int Count
        {
            get { return _lst.Count; }
        }

        public SbFirmType this[int index]
        {
            get
            {
                return _lst[index];
            }
        }

        public void Add(SbFirmType sbFirmType)
        {
            _lst.Add(sbFirmType);
        }

        public void Dispose()
        {
            _currentIndex = -1;
        }

        public IEnumerator<SbFirmType> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public SbFirmType Current
        {
            get
            {
                return _lst[_currentIndex];
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _currentIndex++;
            return (_currentIndex < _lst.Count);
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}
