using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд. 
             * Реализовать класс, в котором указанные значения представлены в виде свойств. Для свойств предусмотреть проверку корректности данных. 
             * Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы. 
             * Создать объект на основе разработанного класса. Осуществить использование объекта в программе.*/
           
            MyTriangle myTriangle_one = new MyTriangle (180,0,0);
            myTriangle_one.ToRadians();
            Console.ReadKey();

        }
            class MyTriangle //Созданный класс
        {
            private int gradus;
            private int minutes;
            private int secund;
            private double radians;
          
            public int Gradus //Свойство с градусом
            {
                set
                {
                    if (value >= 0)
                    {
                        gradus = value;
                    }
                    else
                    {
                        Console.WriteLine("Значения угла не может быть отрицательным");
                    }
                }
                get
                {
                    return gradus;
                }
            }  
                public int Minutes //Свойство с минутами
            {
                set
                {
                    if (value >= 0)
                    {
                        minutes = value;
                    }
                    else
                    {
                        Console.WriteLine("Значение минут не может быть отрицательным");
                    }
                }
                get
                {
                    return minutes;
                }
            }
            public int Secund //Свойство с секундами
            {
                set
                {
                    if (value >= 0)
                    {
                        secund = value;
                    }
                    else
                    {
                        Console.WriteLine("Значение секунд не может быть отрицательным");
                    }
                }
                get
                {
                    return secund;
                }
            }
            public MyTriangle(int gradus, int minutes, int secund) //перегруженый метод
            {
                Gradus = gradus;
                Minutes = minutes;
                Secund = secund;
            }
            
            public void ToRadians() //Метод перевода в радианы
            {
                radians = (Convert.ToDouble(Gradus) + (Convert.ToDouble(Minutes) + Convert.ToDouble(Secund) / 60) / 60 )* Math.PI/180;
                Console.WriteLine("Значение угла в радианах равно {0:f4} рад.", radians);
            }

            }

        }



        }
    

