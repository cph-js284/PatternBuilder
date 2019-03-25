namespace builderPattern
{
    public class PersonBuilder
    {
        string _navn;
        int _alder;
        bool _ansat;


        public PersonBuilder()
        {
            _navn="TestNavn";
            _alder = 42;
            _ansat = false;
        }

        public Person Build(){
            return new Person(){Name = _navn, Age=_alder, Crazy=_ansat};
        }

        public PersonBuilder withName(string inname){
            _navn = inname;
            return this;
        }
        public PersonBuilder withAge(int  inalder){
            _alder = inalder;
            return this;
        }
        public PersonBuilder withCrazy(bool inansat){
            _ansat = inansat;
            return this;
        }

    }
}