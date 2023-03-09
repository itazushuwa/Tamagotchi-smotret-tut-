using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagochi
{
    public struct Fruit
    {
        public int heath;
        public string type;
    }
    class Cat
    {
        private string name;
        private string color;
        private int health;

        public Cat(string name = "Кентик", string color = "Пурпурный")
        {
            this.name = name;
            this.color = color;
            health = 100;
        }
        public static void Meow(Cat a)
        {
            Console.WriteLine("Meow");
        }
        public void Eat(Fruit f)
        {
            Console.WriteLine($"Кошка скушонькала {f.type}.{f.heath} здоровья");
        }
        public static void DoMeal(Cat c, Fruit f)
        {
            c.Eat(f);
            c.health = c.health + f.heath;
        }
        public static void LapkiCarapki(Cat a)
        {
            Random rnd = new Random();
            if (rnd.Next(1, 101) > 70)
            {
                int damage = 10;
                a.health -= damage;
            }
            else
            {
                int damage = rnd.Next(1, 5);
                a.health -= damage;
            }
        }
        public static void Kus(Cat a)
        {
            Random rnd = new Random();
            if (rnd.Next(1, 101) > 90)
            {
                int damage = 20;
                a.health -= damage;
            }
            else
            {
                int damage = rnd.Next(1, 5);
                a.health -= damage;
            }
        }
        public static void Fight(Cat a, Cat b)
        {
            Console.WriteLine("Список ударов: 1. Цап царап, 2. злой кусь, 3. закругление битвы");
            int u = int.Parse(Console.ReadLine());
            switch (u)
            {
                case 1:
                    Cat.LapkiCarapki(b);
                    break;
                case 2:
                    Cat.Kus(b);
                    break;
                default:
                    break;
            }

        }
        public static void Info(Cat a)
        {
            Console.WriteLine($"{a.name}, {a.color}, {a.health}");
        }


    }
}