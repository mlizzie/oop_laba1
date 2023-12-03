using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Firm
    {
        private string _name;
        private string _shname;
        private string _country;
        private string _region;
        private string _town;
        private string _street;
        private string _postInx;
        private DateTime _dateIn;
        private string _email;
        private string _web;
        private List<SubFirm> _sbFirms;
        private Dictionary<string, string> _usrFields;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Shname
        {
            get { return _shname; }
            set { _shname = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public string Region
        {
            get { return _region; }
            set { _region = value; }
        }

        public string Town
        {
            get { return _town; }
            set { _town = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public string PostInx
        {
            get { return _postInx; }
            set { _postInx = value; }
        }

        public DateTime DateIn
        {
            get { return _dateIn; }
            set { _dateIn = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Web
        {
            get { return _web; }
            set { _web = value; }
        }

        public List<SubFirm> SbFirms
        {
            get { return _sbFirms; }
            set { _sbFirms = value; }
        }

        public int SbFirmsCount
        {
            get { return _sbFirms?.Count ?? 0; }
        }

        // Индексатор для доступа к пользовательским полям
        public string this[string key]
        {
            get
            {
                return _usrFields[key];
            }
            set
            {
                _usrFields[key] = value;
            }
        }

        // Конструктор класса
        public Firm()
        {
            _sbFirms = new List<SubFirm>();
            _usrFields = new Dictionary<string, string>();

            // Создаем основной офис при создании фирмы
            SbFirmType sb = new SbFirmType
            {
                IsMain = true,
                Name = "Основной офис"
            };
            SubFirm mainOffice = new SubFirm("Основной офис", "", "", "", "", sb);

            // Добавляем основной офис в список подразделений фирмы
            _sbFirms.Add(mainOffice);
        }

        public Firm(List<string> _newList)
        {
            _sbFirms = new List<SubFirm>();
            _usrFields = new Dictionary<string, string>();

            // Создаем основной офис при создании фирмы
            SbFirmType sb = new SbFirmType
            {
                IsMain = true,
                Name = "Основной офис"
            };
            SubFirm mainOffice = new SubFirm("Основной офис", "", "", "", "", sb);
            // Добавляем основной офис в список подразделений фирмы
            _sbFirms.Add(mainOffice);
            foreach (string key in _newList)
            {
                _usrFields.Add(key, "");
            }
        }


        // Метод для добавления контакта в фирму
        public void AddCont(Contact contact)
        {
            SubFirm mainOffice = GetMain();
            // Добавление контакта в основной офис
            mainOffice.AddCont(contact);
            // Клонирование контакта для каждого подразделения
            foreach (var subFirm in _sbFirms.Where(sf => !sf.IsMain))
            {
                AddContToSbFirm(contact, subFirm);
            }
        }

        // Метод для добавления контакта в подразделение фирмы
        public void AddContToSbFirm(Contact contact, SubFirm subFirm)
        {
            subFirm.AddCont((Contact)contact.Clone());
        }

        // Метод для проверки существования контакта в фирме
        public bool ExistContact(Contact contact)
        {
            SubFirm mainOffice = GetMain();
            return mainOffice.ExistContact(contact);
        }

        // Метод для получения подразделения по имени
        public SubFirm GetSubFirm(string subFirmName)
        {
            return _sbFirms.FirstOrDefault(sf => sf.Name == subFirmName);
        }

        // Метод для получения значения поля из пользовательских полей
        public string GetField(string key)
        {
            return _usrFields.ContainsKey(key) ? _usrFields[key] : null;
        }

        // Метод для получения основного подразделения (главного офиса)
        public SubFirm GetMain()
        {
            return _sbFirms.FirstOrDefault(sf => sf.IsMain);
        }

        // Метод для переименования поля в пользовательских полях
        public void RenameField(string oldKey, string newKey)
        {
            if (_usrFields.ContainsKey(oldKey))
            {
                string value = _usrFields[oldKey];
                _usrFields.Remove(oldKey);
                _usrFields[newKey] = value;
            }
        }

        // Метод для установки значения поля в пользовательских полях
        public void SetField(string key, string value)
        {
            _usrFields[key] = value;
        }

        public void AddSbFirm(SubFirm new_sub_firm)
        {
            _sbFirms.Add(new_sub_firm);
        }

        public SubFirm GetSubFirmByType(SbFirmType type)
        {
            SubFirm subFirm = null;
            foreach (var sub in _sbFirms)
            {
                if (sub.IsMain == type.IsMain && sub.Name == type.Name)
                {
                    subFirm = sub;
                    break;
                }
            }
            return subFirm;
        }

        public void AddField(string field_name, string value)
        {
            _usrFields.Add(field_name, value);
        }

    }
}
