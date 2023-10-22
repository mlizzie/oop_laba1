using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;



public class Firm
{

    public Dictionary<string, string> _usrFields;
    public List<SubFirm> _sbFirms;
    public List<Contact> _contacts;


    private string country;
    private string email;
    private string dateIn;
    private string name;
    private string region;
    private string postInx;
    private string street;
    private string town;
    private string web;

    public string Country
    {
        get
        {
            return country;
        }
        set
        {
            country = value;
        }
    }

    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            email = value;
        }
    }

    public string DateIn
    {
        get
        {
            return dateIn;
        }
        set
        {
            dateIn = value;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public string Region
    {
        get
        {
            return region;
        }
        set
        {
            region = value;
        }
    }

    public string PostInx
    {
        get
        {
            return postInx;
        }
        set
        {
            postInx = value;
        }
    }

    public string Street
    {
        get
        {
            return street;
        }
        set
        {
            street = value;
        }
    }

    public string Town
    {
        get
        {
            return town;
        }
        set
        {
            town = value;
        }
    }

    public string Web
    {
        get
        {
            return web;
        }
        set
        {
            web = value;
        }
    }

    public int SbFirmsCount
    {
        get { return _sbFirms.Count; }
    }
    public SubFirm this[int index]
    {
        get { return _sbFirms[index]; }
        set { _sbFirms[index] = value; }
    }

    // методы
    public void AddCont(Contact new_contact)
    {
        _contacts.Add(new_contact);
    }

    public void AddContToSbFirm(Contact new_contact)
    {
        foreach (SubFirm cur_sub in _sbFirms)
            cur_sub.AddCont(new_contact);
    }

    public void AddField(string field_name, string value)
    {
        _usrFields.Add(field_name, value);
    }

    public void AddSbFirm(SubFirm new_sub_firm)
    {
        _sbFirms.Add(new_sub_firm);
    }

    public bool ExistContact(Contact contact_for_search)
    {
        foreach (Contact cur_contact in _contacts)
            if (cur_contact == contact_for_search)
                return true;
        return false;
    }

    public string GetField(string key)
    {
        string value;
        _usrFields.TryGetValue(key, out value);
        return value;
    }

    public void RenameField(string old_key, string new_key)
    {
        string value;
        _usrFields.TryGetValue(old_key, out value);
        _usrFields.Remove(old_key);
        _usrFields.Add(new_key, value);
    }

    public void SetField(string field_name, string value)
    {
        _usrFields.Remove(field_name);
        _usrFields.Add(field_name, value);
    }

    public Firm()
    {
        _usrFields = new Dictionary<string, string>();
        _sbFirms = new List<SubFirm>();
        _contacts = new List<Contact>();
    }

    public Firm(Dictionary<string, string> _newDictionary)
    {
        _usrFields = _newDictionary;
        _sbFirms = new List<SubFirm>();
        _contacts = new List<Contact>();
    }

    //получение полей
    public string[] GetMain()
    {
        string[] result = new string[9];
        result[0] = country;
        result[1] = dateIn;
        result[2] = email;
        result[3] = name;
        result[4] = postInx;
        result[5] = region;
        result[6] = street;
        result[7] = town;
        result[8] = web;
        return result;

    }
}