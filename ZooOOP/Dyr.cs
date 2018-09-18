namespace ZooOOP
{
    // super-klassen alle dyr fra....
    class Dyr
    {
        public String navn;
        public int year;
        protected bool tam;

        public bool Tam
        {
            get { return tam; }
            set
            {
                if (tam == true) tam = true;
                if (tam == false) tam = value;
            }
        }
    }
}