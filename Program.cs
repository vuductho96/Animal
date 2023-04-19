using System;
namespace Animal
{
    public abstract class Animal
    {

        public string Breed { get; set; }
        public int age { get; set; }

        public  Animal(string breed, int age)
        {
           Breed = breed;
            this.age = age;
        }
        public abstract void PrintInfo();
    }
   

    public class Cat : Animal
    {
       public string name { get; set; }
       
        public Cat(string breed, int age, string name): base (breed,age)
        {
            this.name = name;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Breed : {0}" + '\n' + "aGE: {1}" + '\n' + "Name: {2}", this.Breed, this.age, this.name);
        }

    }

    public class Program
    {
        static void Main (string []args)
        {
            Cat cat1 = new Cat("Dog",20,"Meo con");
            cat1.PrintInfo();


        }

    }
}
