using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap3_11
{
    class Person
    {
        protected string name;
        public int height;
        public int weight;
        public bool ismale;

        public Person(string _name, int _height, int _weight, bool _ismale)
        {
            this.name = _name;
            this.height = _height;
            this.weight = _weight;
            this.ismale = _ismale;
        }

        public virtual void showMyIdentity()
        {
            Console.WriteLine("Ten toi la " + this.name + ", Toi la con nguoi.");
        }

        public void showPersonalInformation()
        {
            Console.WriteLine("Ten toi la " + this.name + ".");
            Console.WriteLine("Chieu cao " + this.height + " cm.");
            Console.WriteLine("Can nang " + this.weight + " kg.");

            if (this.ismale == true)
            {
                Console.WriteLine("Gioi tinh nam");
            }
            else
            {
                Console.WriteLine("Gioi tinh nu");
            }
        }
    }
}
