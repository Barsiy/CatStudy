using System;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Buttle b1 = new Buttle();
            Buttle b2 = new Buttle("red");
            Buttle b3 = new Buttle("black", 0.5);
            b1.Display();
            b2.Display();
            b3.Display();

        }
    }

  public class Buttle
    {
        #region Fields
        //Поля
        private double _vol;
        private string _color;
        private double _koeff = 1.5;

        #endregion


        // Свойства
        public string Color;
        public double Vol
        {
           get { return _vol * _koeff; }
             set 
            {
                if (value > 0) 
                { 
                _vol = value;
                   
                }
                else
                {
                    Console.WriteLine("Значение не может быть отрицательным");
                    _vol = Math.Abs(value);
                }  
                     
            }                           //get => _vol;//return
        
        }

        public Buttle() :this("NaN", 0.5)
        {

        }
         public Buttle(string c):this(c, 0.5)
        {

        }

         public Buttle(string c, double v)
        {
            Color = c;

            _color = Color;

            Vol = v;
        }
    
          public void Display()
        {
            Console.WriteLine($"Color = {Color}, vol= {Vol}");


        }
    
    
    }

}
