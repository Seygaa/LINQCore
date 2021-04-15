using System;
using System.Windows;

namespace LINQ
{
    enum NPC
    {
        Vesna= 0,
        Shani=1,
        Leo=2,
        Vesemir=3,
        Savolla=4,
        Eskel=5
    }
    class Menu
    {
        string newCity1 = "Cintra";
        string newCity2 = "Maribor";
        string CITY="";
        public Menu(string city)
        {
            this.CITY = city;
        }
        public int whatToDo()
        {
            Random rnd = new Random();
            int firstNPC = rnd.Next(0, 5);
            int secondNPC= rnd.Next(0, 5);
            while(secondNPC== firstNPC)
                secondNPC = rnd.Next(0, 5);
            Console.WriteLine("Znajdujesz się w: {0}. Co chcesz zrobić?", CITY);
            Console.WriteLine("[1] Porozmawiaj z {0}", (NPC)firstNPC);
            Console.WriteLine("[2] Porozmawiaj z {0}", (NPC)secondNPC);
            Console.WriteLine("[T] Podróżuj");
            Console.WriteLine("[X] Zamknij program");
            char option = Convert.ToChar(Console.ReadLine());
            clear();
            if (option == 'X' || option == 'x')
                Closing();
            if (option == 'T' || option == 't')
                whereToGo();
            if (option == '1')
                return firstNPC;
            else
                return secondNPC;

        }
        public void whereToGo()
        {
            Console.WriteLine("Znajdujesz się w: {0}. Gdzie chcesz wyruszyć?", CITY);
            Console.WriteLine("[1] {0}", newCity1);
            Console.WriteLine("[2] {0}", newCity2);
            Console.WriteLine("[X] Powrót");
            string option = Console.ReadLine();
            clear();
            if (option == "X" || option == "x")
            {
                whatToDo();
            }
            if (option == "1")
            {
                string temp=CITY;
                CITY = newCity1;
                newCity1 = temp;
                whatToDo();
            }
            else
            {
                string temp = CITY;
                CITY = newCity2;
                newCity2 = temp;
                whatToDo();
            }
     
        }
        
        public static void clear()
        {
            Console.Clear();
        }
        private static void Closing()
        {
            System.Environment.Exit(0);
        }
    }

    class Zadanie4
    {
        public static void dialog(int enumName)
        {
            Console.WriteLine("{0}: Witaj, czy możesz mi pomóc dostać się do innego miasta?",(NPC)enumName);
            Console.WriteLine("Wybierz Odpowiedź: \n [1]„Tak, chętnie pomogę.” \n [2]„Nie, nie pomogę, żegnaj.”");
            int choise = Convert.ToInt32(Console.ReadLine());
            if (choise == 1)
            {
                Console.WriteLine("Ty: Tak, chętnie pomogę.");
                Console.WriteLine("{0}: Dziękuję! W nagrodę otrzymasz ode mnie 100 sztuk złota.", (NPC)enumName);
                Console.WriteLine("Wybierz Odpowiedź: \n [1]„Dam znać jak będę gotowy.” \n [2]„100 sztuk złota to za mało!”");
                choise = Convert.ToInt32(Console.ReadLine());
                if (choise == 1)
                {
                    Console.WriteLine("Ty: Dam znać jak będę gotowy.");
                    return;
                }
                Console.WriteLine("Ty: 100 sztuk złota to za mało!");
                Console.WriteLine("{0}: Niestety nie mam więcej. Jestem bardzo biedny.", (NPC)enumName);
                Console.WriteLine("Wybierz Odpowiedź: \n [1]„OK, może być 100 sztuk złota.” \n [2]„W takim razie radź sobie sam.”");
                choise = Convert.ToInt32(Console.ReadLine());
                if (choise == 1)
                {
                    Console.WriteLine("Ty: OK, może być 100 sztuk złota.");
                    Console.WriteLine("{0}: „Dziękuję", (NPC)enumName);
                    return;
                }
                Console.WriteLine("Ty: W takim razie radź sobie sam.");
                return;
            }
            Console.WriteLine("Ty: Nie, nie pomogę, żegnaj.");
            return;
        }
        /*
        static void Main()
        {
            string cityToGo = "Novigrad";
            Menu menu = new Menu(cityToGo);           
            int option = menu.whatToDo();
            Console.WriteLine("Rozmowa z NPC");
            dialog(option);

        }*/

    }
}
