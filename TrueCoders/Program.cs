using System;
using System.Collections.Generic;

namespace TrueCoders
{
    class TrueCoders
    {
        static void Main(string[] args)
        {
            var person1 = new People();
            
                person1.Age = 13;
                person1.FirstName = "Bobby";
                person1.LastName = "Hill";
                person1.HairColor = "blonde";


            var person2 = new People();
            
                person2.Age = 8;
                person2.FirstName = "Stan";
                person2.LastName = "Marsh";
                person2.HairColor = "brown";




            var person3 = new People();
           
                person3.Age = 2;
                person3.FirstName = "Stewie";
                person3.LastName = "Griffin";
                person3.HairColor = "black";



            List<People> trueCoders = new List<People>();
            trueCoders.Add(person1);
            trueCoders.Add(person2);
            trueCoders.Add(person3);

            foreach (var human in trueCoders)
            {
                Console.WriteLine($"Hello my name is {human.FirstName} {human.LastName}, I am {human.Age}, and my hair is {human.HairColor}! Screw you guys I'm going home!");
            }

        
             












         

        }
    }
}
