namespace ConsoleApp1
{
    public class FirmFactory
    {
        public List<string> flds { get; private set; }
        public List<string> NameMain { get; private set; }
        public Firm Create()
        {
            Firm new_firm = new Firm(flds);
            return new_firm;

        }
        public void fldsName(List<string> new_flds)
        {
            flds = new_flds;
        }

        public void nameMain(List<string> new_names)
        {
            NameMain = new_names;
        }
    }
}
