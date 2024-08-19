namespace Dag_1___HelloWorld
{

    internal class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public string Fornavn
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}