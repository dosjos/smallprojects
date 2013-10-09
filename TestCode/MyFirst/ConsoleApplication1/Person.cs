

namespace ConsoleApplication1
{
    class Person
    {
        public string FirstName;
        public string LastName;

        public int Birthday { get; set; }

        internal int BeregnAlder()
        {
            return 2012 - Birthday;
        }
    }
}
