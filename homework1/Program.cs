using System;
namespace homework1
{
   public class Program
    {
        static void Main()
        {
          Dog dog = new Dog();
            dog.name = "Daisy";
            dog.age = 2;
            dog.color = "brown";

            Cat cat=new Cat();
            cat.name = "Liza";
            cat.age = 3;
            cat.color = "white with black prints";

        Console.WriteLine((dog.Giveallinfo()));
            Console.WriteLine((cat.GiveAllInfo()));
        }
    } 

    class Dog
    {
        public string name;
        public  byte age;
        public string color;

        public string Giveallinfo()
        {

            return $"{name} {age} {color}";

        }
    }

    class Cat
    {
        public string name;
        public byte age;
        public string color;

        public string GiveAllInfo()
        {
            return $"{name} {age} {color}"; 
        }


    } 
}
