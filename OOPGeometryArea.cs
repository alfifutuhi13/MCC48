using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGeometryArea
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Menu m = new Menu();
                    m.InitiateMenu();

                    //Pilihan User
                    string inputUserString = Console.ReadLine();
                    int inputUser = 0;

                    if (int.TryParse(inputUserString, out inputUser))
                    {
                        switch (inputUser)
                        {
                            case 1:
                                Menu1 m1 = new Menu1();

                                //Meminta input user
                                Console.WriteLine("Please input the  lengh of side of square: ");
                                double side = Convert.ToDouble(Console.ReadLine());

                                if (side > 0)
                                {
                                    m1.Area(side);
                                    m1.Perimeter(side);
                                    //Encapsulation
                                    Console.WriteLine("Perimeter of the square is {0}\n", m1.getKeliling1());
                                }
                                else 
                                {
                                    throw new ArithmeticException();
                                }
                                
                                break;
                            case 2:
                                Menu2 m2 = new Menu2();
                                //Meminta input panjang dan lebar
                                Console.WriteLine("Please input the length of rectangle");
                                double length = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("\nPlease input the width of rectangle");
                                double width = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("");

                                if (length > 0 && width > 0)
                                {
                                    m2.Area(length, width);
                                    m2.Perimeter(length, width);
                                    //Encapsulation
                                    Console.WriteLine("Perimeter of the rectangle is {0}\n", m2.getKeliling2());
                                }
                                else 
                                {
                                    throw new ArithmeticException();
                                }
                                break;
                            case 3:
                                Menu3 m3 = new Menu3();
                                Console.WriteLine("Please input the length of first side of triangle");
                                double side1Triangle = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Please input the length of second side of triangle");
                                double side2Triangle = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Please input the length of third side of triangle");
                                double side3Triangle = Convert.ToDouble(Console.ReadLine());

                                if (side1Triangle > 0 && side2Triangle > 0 && side3Triangle > 0)
                                {
                                    m3.Perimeter(side1Triangle, side2Triangle, side3Triangle);
                                    m3.Area(side1Triangle, side2Triangle, side3Triangle);
                                    Console.WriteLine("Perimeter of the triangle is {0}\n", m3.getKeliling3());
                                }
                                else 
                                {
                                    throw new ArithmeticException();
                                }
                                
                                break;
                            case 4:
                                Menu4 m4 = new Menu4();
                                Console.WriteLine("Please input the radius of circle");
                                double radius = Convert.ToDouble(Console.ReadLine());

                                if (radius > 0)
                                {
                                    m4.Area(radius);
                                    m4.Perimeter(radius);
                                    Console.WriteLine("Perimeter of the circle is {0}\n", m4.getKeliling4());
                                }
                                else 
                                {
                                    throw new ArithmeticException();
                                }
                                
                                break;
                            case 5:
                                Menu5 m5 = new Menu5();
                                Console.WriteLine("Please input the first parallel side of trapezoid");
                                double side1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Please input the second parallel side of trapezoid");
                                double side2 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Please input the height of trapezoid");
                                double heightTrapezoid = Convert.ToDouble(Console.ReadLine());

                                if (side1 > 0 && side2 > 0 && heightTrapezoid > 0)
                                {
                                    m5.Area(side1, side2, heightTrapezoid);
                                    m5.Perimeter(side1, side2, heightTrapezoid);
                                    Console.WriteLine("Perimeter of the trapezoid is {0}\n", m5.getKeliling5());
                                }
                                else 
                                {
                                    throw new ArithmeticException();
                                }
                                
                                break;
                            default:
                                Console.WriteLine("Please choose only number 1-5\n");
                                break;

                        }
                    }
                    else 
                    {
                        throw new Exception();
                    }
                    //Menu Restart
                    m.RestartMenu();
                    string inputRestart = Console.ReadLine();
                    if (inputRestart == "yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("THE LENGTH OF SHAPE SHOULD BE HIGHER THAN 0\n");
            }
            catch (Exception)
            {
                Console.WriteLine("INPUT SHOULD BE INTEGER\n");
            }
            finally 
            {
                Console.WriteLine("Program has been ended.\n");
            }
        }
    }

    public interface IMenu 
    {
        void InitiateMenu();
        void RestartMenu();
    }

    class Menu : IMenu
    {
        protected double area;

        //Constructor
        public Menu() 
        {
            Console.WriteLine("Loading...\n");
        }

        //Method-method
        public void InitiateMenu() 
        {
            Console.WriteLine("Calculating Area Program. Choose your menu (1-5)");
            Console.WriteLine("" +
                "1. Square \n" +
                "2. Rectangle \n" +
                "3. Triangle \n" +
                "4. Circle \n" +
                "5. Trapezoid \n");
        }

        public void RestartMenu()
        {
            Console.WriteLine("Type \'yes\' to restart program \n");
        }
    }

    //Menu1: Square
    class Menu1 : Menu 
    {
        private double _keliling1;
        //Encapsulation
        public double getKeliling1() 
        {
            return _keliling1;
        }

        //Method, polymorphism (override & overlod)
        public virtual void Area(double s)
        {
            this.area = s * s;
            Console.WriteLine("Area of the square is {0}\n", area);
        }
        public virtual void Area(double l, double h) 
        { 
            //Dummy
        }
        public virtual void Area(double s1, double s2, double h) 
        { 
            //Dummy
        }
        public virtual void Perimeter(double s) 
        {
            _keliling1 = 4 * s;
        }
    }
    //Menu2: Rectangle
    class Menu2 : Menu1 
    {
        private double _keliling2;
        //Encapsulation
        public double getKeliling2()
        {
            return _keliling2;
        }

        //Method
        public override void Area(double l, double w) 
        {
            area = l * w;
            Console.WriteLine("Area of the rectangle is {0}\n", area);
        }
        public void Perimeter(double l, double w) 
        {
            _keliling2 = 2 * (l + w);
        }
    }
    //Menu3: Triangle
    class Menu3 : Menu1 
    {
        private double _keliling3;
        //Encapsulation
        public double getKeliling3() 
        {
            return _keliling3;
        }
        //Method
        public override void Area(double s1, double s2, double s3) 
        {
            area = Math.Round(Math.Sqrt(0.5*_keliling3 * (0.5*_keliling3-s1) * (0.5*_keliling3-s2) * (0.5*_keliling3-s3)) , 2);
            Console.WriteLine("Area of the triangle is {0}\n", area);
        }
        public void Perimeter(double s1, double s2, double s3) 
        {
            _keliling3 = s1 + s2 + s3;
        }
    }
    //Menu4: Circle
    class Menu4 : Menu1 
    {
        private double _keliling4;
        //Encapsulation
        public double getKeliling4() 
        {
            return _keliling4;
        }

        //Method
        public override void Area(double r) 
        {
            area = Math.PI * r * r;
            Console.WriteLine("Area of the circle is {0}\n", Math.Round(area,2));
        }
        public override void Perimeter(double r) 
        {
            _keliling4 = Math.Round((Math.PI * 2 * r ), 2);
        }
    }
    //Menu5: Trapezoid
    class Menu5 : Menu1 
    {
        private double _keliling5;
        private double side34;
        //Encapsulation
        public double getKeliling5() 
        {
            return _keliling5;
        }
        public override void Area(double s1, double s2, double h) 
        {
            area = (s1 + s2) * h * 0.5 ;
            Console.WriteLine("Area of the trapezoid is {0}\n", Math.Round(area,2));
        }
        public void Perimeter(double s1, double s2, double h) 
        {
            side34 = Math.Sqrt(Math.Pow(0.5 * Math.Abs(s1 - s2),2) + Math.Pow(h,2)) ;
            _keliling5 = Math.Round(s1 + s2 + 2 * side34 , 2);
        }
    }
}
