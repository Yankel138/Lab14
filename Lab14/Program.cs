using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кот");
            cat.ShowInfo();
            Dog dog = new Dog("Пёс");
            dog.ShowInfo();

            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        public abstract string Name { set; get; }
        public Animal(string name = "Животное")
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine("Название животного: " + Name);
            Console.Write(Name + " издает звук: ");
            Say();
        }



    }

    class Cat : Animal
    {
        string name;
        public override string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return name;
            }
        }

        public Cat(string name)
        : base(name)
        {
            Name = name;
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
        public new void ShowInfo()
        {
            base.ShowInfo();
        }

    }

    class Dog : Animal
    {
        string name;
        public override string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return name;
            }
        }
        public Dog(string name)
        : base(name)
        {
            Name = name;
        }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
        public new void ShowInfo()
        {
            base.ShowInfo();
        }

    }
}
