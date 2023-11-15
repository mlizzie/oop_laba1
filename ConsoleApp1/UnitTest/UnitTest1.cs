using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateFirm_test()
        {
            FirmFactory firmFactory = new FirmFactory();
            Firm firm = firmFactory.Create();
            Assert.IsNotNull(firm);
        }

        [TestMethod]
        public void FirmFields_test()
        {
            FirmFactory firmFactory = new FirmFactory();
            Firm firm = firmFactory.Create();
            List<string> list = firmFactory.flds;
            foreach (string field in list)
            {
                Assert.IsNotNull(firm._usrFields[field]);
            }
        }

        [TestMethod]
        public void AddToSbFirm_test() //добавление подразделения 
        {
            ConsoleApp1.Firm test = new ConsoleApp1.Firm();
            ConsoleApp1.SubFirm new_sub = new ConsoleApp1.SubFirm();
            int old_count = test._sbFirms.Count;
            test.AddSbFirm(new_sub);
            int new_count = test._sbFirms.Count;
            Assert.AreEqual(old_count + 1, new_count);
        }
        [TestMethod]
        public void AddField_test() //добавление поля
        {
            ConsoleApp1.Firm test = new ConsoleApp1.Firm();
            string key = "field_name";
            string value = "val";
            string search_value;
            test.AddField(key, value);
            test._usrFields.TryGetValue(key, out search_value);
            Assert.AreEqual(value, search_value);
        }
        [TestMethod]
        public void GetField_test() //получение поля 
        {
            ConsoleApp1.Firm test = new ConsoleApp1.Firm();
            string key = "field_name";
            string value = "value";
            string search_value;
            test._usrFields.Add(key, value);
            search_value = test.GetField(key);
            Assert.AreEqual(value, search_value);
        }
        [TestMethod]
        public void RenameField_test() //переименовывание поля
        {
            ConsoleApp1.Firm test = new ConsoleApp1.Firm();
            string old_key = "field_name_1";
            string new_key = "field_name_2";
            string value = "value";
            string search_value;

            test._usrFields.Add(old_key, value);
            test.RenameField(old_key, new_key);
            test._usrFields.TryGetValue(new_key, out search_value);
            Assert.AreEqual(value, search_value);
        }
        [TestMethod]
        public void AddContToSubFirm_test() //добавление контакта к подразделениям 
        {
            ConsoleApp1.Firm test_firm = new ConsoleApp1.Firm();
            ConsoleApp1.SubFirm sub_firm = new ConsoleApp1.SubFirm();
            ConsoleApp1.SubFirm sub_firm_2 = new ConsoleApp1.SubFirm();
            ConsoleApp1.Contact test_cont = new ConsoleApp1.Contact(new ConsoleApp1.ContType());
            test_firm.AddSbFirm(sub_firm);
            test_firm.AddSbFirm(sub_firm_2);
            test_firm.AddContToSbFirm(test_cont);
            Assert.AreEqual(sub_firm.contacts.Count, sub_firm_2.contacts.Count);
        }
       
        [TestMethod]
        public void SetField_test() //установка поля
        {
            ConsoleApp1.Firm test = new ConsoleApp1.Firm();
            string key = "field_name";
            string old_value = "val_1";
            string new_value = "val_2";
            string search_value;

            test._usrFields.Add(key, old_value);
            test.SetField(key, new_value);
            test._usrFields.TryGetValue(key, out search_value);
            Assert.AreEqual(new_value, search_value);
        }
    }
}
