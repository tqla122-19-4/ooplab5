using System;

namespace ooplab5
{
    class Program
    {

        class Prong
        {
            ProngInterface prong;
            public Prong(ProngInterface prng)
            {
                prong = prng;
            }
            public void Source()
            {
                prong.Type();
            }
        }

        class Fruit : ProngInterface
        {
            public void Type()
            {
                Console.WriteLine("Вилка для фруктов");
            }
        }
        class Dessert : ProngInterface
        {
            public void Type()
            {
                Console.WriteLine("Вилка для десертов");
            }
        }

        interface ProngInterface
        {
            void Type();
        }



        class Spoon
        {
            SpoonInterface spoon;
            public Spoon(SpoonInterface spn)
            {
                spoon = spn;
            }
            public void Source()
            {
                spoon.Type();
            }
        }

        class Table : SpoonInterface
        {
            public void Type()
            {
                Console.WriteLine("Столовая ложка");
            }
        }
        class Tea : SpoonInterface
        {
            public void Type()
            {
                Console.WriteLine("Чайная ложка");
            }
        }

        interface SpoonInterface
        {
            void Type();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Интерфейс ProngInterface:");

            Prong dsrt = new Prong(new Dessert());
            Prong frt = new Prong(new Fruit());
            
            dsrt.Source();
            frt.Source();

            Console.WriteLine();
            Console.WriteLine("Интерфейс SpoonInterface:");

            Spoon table = new Spoon(new Table());
            Spoon tea = new Spoon(new Tea());
            
            table.Source();
            tea.Source();

            Console.ReadKey();
        }
    }
}
