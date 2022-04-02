using System;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cow1 = new Cow(5, 30, "Grass", "Female");
            cow1.ProducesMilk();
            cow1.Sound();
            cow1.Eat();
            
            
            
        }
    }
    //Grandparent class
    public abstract class Animal
    {
        

        public int age;
        public int weight;
        public string food;
        public string gender;

        



        public Animal(int age, int weight, string food, string gender)
        {
            this.age = age;
            this.weight = weight;
            this.food = food;
            this.gender = gender;
        }

        public abstract void Sound();

        public abstract void Eat();

        public virtual void ProducesMilk()
        {
            Console.WriteLine("No animal produces milk currently!");
        }
        
    }
    //*****************************************************************************


    //parent class
    class Fish : Animal
    {
        public Fish(int age, int weight, string food, string gender) : base(age, weight, food, gender)
        {
        }
        public override void Sound()
        {

        }

        public override void Eat()
        {

        }
    }

    //Parent Class
    class Bird : Animal
    {


        public Bird(int age, int weight, string food, string gender) : base(age, weight, food, gender)
        {
        }
        public override void Sound()
        {

        }

        public override void Eat()
        {

        }
    }

    //Parent class
    class Mammal : Animal
    {
        public Mammal(int age, int weight, string food, string gender) : base(age, weight, food, gender)
        {
        }

        public override void Sound()
        {

        }

        public override void Eat()
        {
            
        }
        
        public override void ProducesMilk()
        {
            Console.WriteLine("No Mammal produce milk currently!");
        }
        
    }

    
    
   

    //**************************************************************************************
    //Children classes

    class Cow : Mammal,ICanWalk
    {
        public string sound = "Moo";

        public Cow(int age, int weight, string food, string gender) : base(age, weight, food, gender)
        {

        }

        public void CanWalk()
        {
            Console.WriteLine($"{this} CAN WALK!");
        }

        public override void Eat()
        {
            Console.WriteLine($"{this} eats {this.food}!");
        }

        public override void Sound()
        {
            Console.WriteLine($"{this} Make the {this.sound} Sound!");
        }

        public override void ProducesMilk()
        {
            Console.WriteLine(this.gender);

            if (this.gender == "Female")
            {
                Console.WriteLine($"{this} produces milk!");
            }
            else
            {
                Console.WriteLine($"{this} doesn't produce milk!");
            }
        }

    }
    class Sheep : Mammal, ICanWalk
    {
        public string sound = "Baa";

        public Sheep(int age, int weight, string food, string gender) : base(age, weight, food, gender)
        {

        }
        public void CanWalk()
        {
            Console.WriteLine($"{this} CAN WALK!");
        }

    }

    class Pigeon : Bird, ICanFly
    {
        public string sound = "Coo";

        public Pigeon(int age, int weight, string food, string gender) : base(age, weight, food, gender)
        {
        }
        public void CanFly()
        {
            Console.WriteLine($"{this} CAN FLY!");
        }
    }

    class Shark : Fish, ICanSwim
    {
        public string sound = null;

        public Shark(int age, int weight, string food, string gender) : base(age, weight, food, gender)
        {
        }
        public void CanSwim()
        {
            Console.WriteLine($"{this} CAN SWIM!");
        }
    }

    class Dolphin : Fish, ICanSwim
    {
        
        public string sound = "Click or Whislte";

        public Dolphin(int age, int weight, string food, string gender) : base(age, weight, food, gender)
        {
        }

        public void CanSwim()
        {
            Console.WriteLine($"{this} CAN SWIM!");
        }
    }

    //Interfaces
    interface ICanWalk
    {
        public void CanWalk();
    }

    interface ICanSwim
    {
        public void CanSwim();
    }

    interface ICanFly
    {
        public void CanFly();
    }
}
