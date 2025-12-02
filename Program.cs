/*Практическая работа № 10

Использование принципов ООП

Задание: 
1.Написать код, показывающий работу 4-ех принципов ООП
2. В решение добавить проект, реализовать перегрузку методов, операторов и преобразование типов
3. Реализовать программу, представленную на блок-схеме (отступать от действий, показанных на ней, нельзя)*/


using System;

//Задание 1
namespace OOP
{
    //Инкапсуляция
    class Camarero
    {
        private bool estaListo;

        private void Preparar()
        {
            Console.WriteLine("Блюдо готовиться");

            estaListo = true;

            Console.WriteLine("Блюдо готово");
        }

        public void Servicio()
        {
            if (!estaListo)
            {
                Console.WriteLine("Блюдо не готово");
                Preparar();
            }
            Console.WriteLine("Ваше жаренные гвозди, сеньор \n");
            estaListo = false;
        }

    }

    //Наследование и полиморфизм
    class Pizza
    {
        public string Ingredientes { get; set; }
        public string CookingTime { get; set; }

        public void ToCook()
        {
            Console.WriteLine($"У нас есть пицца с {Ingredientes}. Она будет готова примерно через {CookingTime}");
        }

        public void Cooking()
        {
            Console.WriteLine("Ваша пицца готовиться \n");
        }
    }

    class Margarita : Pizza
    {
        public void Order()
        {
            Console.WriteLine("Вы выбрали пиццу Маргарита \n");
        }

        public void Cooking()
        {
            Console.WriteLine("Ваша Маргарита готовиться \n");

        }
    }

    //Абстракция
    abstract class CookingPizza
    {
        public abstract void Cook();
    }

    class CookingMargarita : CookingPizza
    {
        public override void Cook()
        {
            Console.WriteLine("Начинка для Маргариты выкладывается на тесто");
        }
    }

    class Pizzayolo
    {
        public void Cook(CookingPizza cookingPizza)
        {
            cookingPizza.Cook();
        }
    }





    class Programm
    {
        static void Main(string[] args)
        {
            //Инкапсуляция
            Console.WriteLine("Инкапсуляция: ");
            Camarero camarero = new Camarero();
            camarero.Servicio();

            //Наследование
            Console.WriteLine("Наследование: ");
            Margarita margarita = new Margarita { Ingredientes = "Томатный соус, сыр", CookingTime = "42 минуты" };
            margarita.ToCook();
            margarita.Order();

            //Полиморфизм
            Console.WriteLine("Полиморфизм: ");
            Pizza pizza = new Margarita { Ingredientes = "Томатный соус, сыр", CookingTime = "52 минуты" };
            pizza.Cooking();

            //Абстракция
            Console.WriteLine("Абстракция: ");
            Pizzayolo pizzayolo = new Pizzayolo();
            CookingMargarita cookingMargarita = new CookingMargarita();
            pizzayolo.Cook(cookingMargarita);
        }
    }
}



