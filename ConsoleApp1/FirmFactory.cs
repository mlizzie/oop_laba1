using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FirmFactory
    {
        private List<string> _flds;
        public string NameMain { get; private set; }

        public FirmFactory(List<string> flds, string nameMain)
        {
            _flds = flds;
            NameMain = nameMain;
        }

        public Firm Create()
        {
            if(_flds.Count == 0)
                // Создание фирмы
                return new Firm();
            else
                return new Firm(_flds);
        }

        // Метод для получения названий полей для пользователя
        public List<string> GetFieldNames()
        {
            return new List<string>(_flds);
        }
    }
}
