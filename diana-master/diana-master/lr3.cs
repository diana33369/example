   using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


namespace lr3
{
    class Airline
    {
        //Кол-во созданных объектов
        public static ulong RefCount { get; private set; }


        public string ArrivalPoint { get; set; }
        public int Number { get; set; }
        public string JetType { get; set; }
        public int Time { get; set; }
        public string Day { get; set; }

        //поле-константа
        public const int year = 2017;

        //поле для чтения
        public readonly string K = "Minsk National Airport";

        public Airline()
        {
            RefCount++;
        }

        public Airline(string aPoint, int n, int t) : this()
        {
            ArrivalPoint = aPoint;
            Number = n;
            Time = t;
        }

        public Airline(string aPoint, int n, string jType, int t, string d) : this()
        {
            ArrivalPoint = aPoint;
            Number = n;
            JetType = jType;
            Time = t;
            Day = d;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Airline(JetType={0}, ArrivalPoint={1}, FlightNumber={2}, Time={3}, Day={4})", JetType, ArrivalPoint, Number, Time, Day);
            return sb.ToString();
        }

        //статическое поле и статический метод 
        private static string about = "Статический метод и статиечское поле";

        static Airline()
        {
            about = "Статический метод и статическое поле";
        }

        public static string methodStatic()
        {
            return "Статический метод!!!";
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return this == obj;
        }

        public int methodRefOut(ref string str, out int num)
        {
            str = "Красницкая";
            num = 5;
            return num;
        }
    }
    //статический метод вывода инф о классе


    //закрытый конструктор////////////////////
    class MyClass
    {
        public int X { get; }

        private MyClass(int a)
        {
            X = a;
        }

        public void Show()
        {
            Console.WriteLine($"Object value = {X}");
        }

        public static MyClass Contructor(int a)
        {
            return new MyClass(a);
        }
    }
    /////////////////////////////////////////


    class Program
    {
        static void Main(string[] args)
        {
            //закрытый конструктор 
            var v = MyClass.Contructor(2);
            //создание объектов
            Airline a = new Airline("Минск", 1522, "Пассажирский", 15, "Среда");
            Airline b = new Airline("Москва", 102, "Грузовой", 21, "Суббота");
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(a.GetType().FullName);
            Console.WriteLine(a.Day + " " + a.Number);
            //анонимный тип
            var user = new {ArrivalPoint = "Minsk", Number = 34,JetType="Pass",Time=5,Day="Sunday"};
            Console.WriteLine(user);
            Console.WriteLine(user.GetType());
            if(a.Equals(b))
                Console.WriteLine("Объекты равны");
            else
                Console.WriteLine("Объекты не равны!");
            Console.WriteLine(Airline.methodStatic());

            string str = "Шура";
            int num;
            num = a.methodRefOut(ref str, out num);
            Console.WriteLine("Num: " + num + "\nString: " + str); ;
        
            Airline[] airlines = new Airline[]
            {
                new Airline("Минск", 1522, "Пассажирский", 15, "Среда"),
                new Airline("Минск", 1522, "Пассажирский", 15, "Четверг"),
                new Airline("Могилев", 1522, "Пассажирский", 15, "Среда"),
            };
            Console.WriteLine("До пункта назначения");
            foreach (var air in airlines)
            {
                if (air.ArrivalPoint.Equals("Минск"))
                {
                    Console.WriteLine(air.ToString());
                }
            }
            Console.WriteLine("\nДень недели");

            foreach (var air in airlines)
            {
                if(air.Day == "Среда")
                    Console.WriteLine(air.ToString());
            }
            Console.ReadLine();

        }
    }
}
    
    


