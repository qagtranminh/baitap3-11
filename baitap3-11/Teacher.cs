using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap3_11
{
    class Teacher : Person
    {
        public string facultyID;

        public Teacher(string _name, int _height, int _weight, bool _ismale, string _facultyID)
            : base(_name, _height, _weight, _ismale)
        {
            this.facultyID = _facultyID;
        }

        public override void showMyIdentity()
        {
            Console.WriteLine("Ten toi la " + this.name + ", Toi la giang vien.");
        }
    }
} 