namespace Indexer
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string city;

        public string this[int index]
        {
            set
            {
                switch (index)
                {
                    case 0: firstName = value; break;
                    case 1: lastName = value; break;
                    case 2: city = value; break;
                    default: throw new ArgumentOutOfRangeException("index") ;

                }
            }

            get
            {
                switch (index)
                {
                    case 0: return firstName;
                        case 1: return lastName;
                        case 2: return city;
                    default: throw new ArgumentOutOfRangeException("index") ;

                }
            }
        }
    }
}
