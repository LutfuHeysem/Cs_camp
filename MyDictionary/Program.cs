using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<int, string> favouriteCarsAndMotors = new MyDict<int, string>();
            favouriteCarsAndMotors.Add(1, "Yamaha YZR125");
            favouriteCarsAndMotors.Add(2, "Dodge Dart GT");
            favouriteCarsAndMotors.Add(3, "Chevrolet Camaro S");
            favouriteCarsAndMotors.Add(4, "Tesla Model Y");
            favouriteCarsAndMotors.Add(5, "Kawasaki Ninja");
        }
    }
}
