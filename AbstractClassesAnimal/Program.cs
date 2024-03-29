﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.exercisescsharp.com/oop/abstract-classes
namespace AbstractClassesAnimal
{
    public abstract class Animal
    {
        public virtual string Name { get; set; }
        public string SetName(string name)
        {
            this.Name = name;
            return name;
        }
        public string GetName()
        {
            return Name;
        }
        public virtual void Eat()
        {
            
        }
    }
    public class Dog : Animal
    {
        public override string Name { get; set; }
        public override void Eat()
        {
            Console.WriteLine("The dog is eating.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dog's name: ");
            var userInput = Console.ReadLine();
            
            var dog = new Dog();
            
            dog.SetName(userInput);
            Console.WriteLine("Dog's name: " + dog.GetName() + "\n"); 

            dog.Eat();
        }
    }
}