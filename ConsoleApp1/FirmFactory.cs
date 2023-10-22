namespace ConsoleApp1
{
    public class FirmFactory
    {
        public Dictionary<string, string> flds { get; set; }
        public List<string> NameMain { get; set; }
        public Firm Create()
        {
            Firm new_firm = new Firm(flds);
            return new_firm;

        }
        public void fldsName(Dictionary<string, string> new_flds)
        {
            flds = new_flds;
        }
    }
}
