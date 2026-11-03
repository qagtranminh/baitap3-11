using baitap3_11;
using System;

class Student : Person
{
    public string studentID;

    public Student(string _name, int _height, int _weight, bool _ismale, string _studentID)
        : base(_name, _height, _weight, _ismale)
    {
        this.studentID = _studentID;
    }

    public override void showMyIdentity()
    {
        Console.WriteLine("Ten toi la " + this.name + ", Toi la sinh vien.");
    }
}
