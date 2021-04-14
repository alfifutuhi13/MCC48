using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    //Object Menu
                    Menu m = new Menu();
                    //inisiasi menu
                    m.initiateMenu();

                    //User memilih
                    string inputUserString = Console.ReadLine();
                    int inputUser = 0;

                    if (int.TryParse(inputUserString, out inputUser))
                    {

                        switch (inputUser)
                        {
                            case 1:
                                //Membuat objek menu 1
                                Menu1 m1 = new Menu1();

                                //Meminta input berat dan tinggi
                                Console.Write("Input your weight(kg): ");
                                int weight = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");

                                Console.Write("Input your height(cm): ");
                                int height = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");

                                if (height != 0)
                                {
                                    //Melakukan perhitungan
                                    m1.Calc(weight, height);
                                }
                                else
                                {
                                    throw new DivideByZeroException();
                                }
                                break;
                            case 2:
                                //Membuat Objek Menu 2
                                Menu2 m2 = new Menu2();

                                //Meminta input Nama
                                Console.WriteLine("Please input your name ");
                                string inputNama = Console.ReadLine();
                                Console.WriteLine("");

                                m2.Calc(inputNama);

                                break;
                            case 3:
                                //Membuat Objek Menu 3
                                Menu3 m3 = new Menu3();
                                //Meminta input Nama
                                Console.WriteLine("Please input your name ");
                                string inputNama2 = Console.ReadLine();
                                Console.WriteLine("");

                                m3.Calc(inputNama2);

                                break;
                            case 4:
                                //Membuat objek Menu 4
                                Menu4 m4 = new Menu4();
                                //Meminta input array size
                                Console.WriteLine("Please input the array size ");
                                int inputArrSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");

                                if (inputArrSize > 0)
                                {
                                    m4.Calc(inputArrSize);
                                    //Encapsulation
                                    Console.WriteLine("The sum of the inputted array is {0}", m4.getSum());
                                    Console.WriteLine(" ");
                                }
                                else
                                {
                                    throw new ArithmeticException();
                                }
                                break;
                            default:
                                Console.WriteLine("Please input number from 1-5! \n");
                                break;
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                    //Menu Restart
                    m.restartMenu();
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
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("CANNOT DIVIDED BY ZERO");
            }
            catch (ArithmeticException e1)
            {
                Console.WriteLine("ARRAY SIZE SHOULD BE POSITIF INTEGER!");
            }
            catch (Exception e2)
            {
                Console.WriteLine("INPUT SHOULD BE INTEGER");
            }
        }
    }

    abstract class DesignMenu
    {
        public abstract void initiateMenu();
        public abstract void restartMenu();
        
    }

    class Menu : DesignMenu
    {
        //attribute
        //no 1
        protected int weight;
        protected int height;

        //no 2
        protected string inputNama;

        //no 3
        protected string inputNama2;

        //no4
        protected int inputArrSize;


        //Constructor
        public Menu()
        {
            Console.WriteLine("Loading...");
        }

        //method-method
        public override void initiateMenu()
        {
            Console.WriteLine("Input number from 1-4");
            Console.WriteLine("1. Body Mas Index \n" +
                "2. Reprint Name \n" +
                "3. Print Even\'s Character \n" +
                "4. Sum The Inputted Array \n");

        }
        public override void restartMenu()
        {
            Console.WriteLine("Type \'yes\' to restart program \n");
        }
    }
    

    class Menu1 : Menu
    {
        private float bmi;

        public virtual void Calc(int w, int h)
        {
            this.weight = w;
            this.height = h;
            //Kalkulasi
            bmi = (float)weight * 100 * 100 / (height * height);

            //Output
            Console.Write("Your BMI\'s ");
            Console.Write(Math.Round((decimal)bmi, 1)); //membulatkan 1 angka dibelakang koma
            if (bmi < 18.1)
            {
                Console.WriteLine(". You\'re underweight");
            }
            else if (bmi >= 18.1 && bmi <= 23.1)
            {
                Console.WriteLine(". You\'re normal.");
            }
            else if (bmi > 23.1 && bmi <= 28.1)
            {
                Console.Write(". You\'re overweight.");
            }
            else
            {
                Console.Write(". You\'re obesity.");
            }

            Console.WriteLine(" ");
        }

        //Untuk Menu 2 dan 3
        public virtual void Calc(string n)
        {
            //Dummy
        }

        //Untuk Menu 4
        public virtual void Calc(int size)
        {
            //Dummy
        }

    }

    class Menu2 : Menu1
    {
        private int i = 0;
        public override void Calc(string n)
        {
            this.inputNama = n;
            //output
            while (i < inputNama.Length)
            {
                Console.WriteLine("Huruf ke-{0} adalah {1}", i + 1, inputNama[i]);
                i++;
            }
            Console.WriteLine(" ");

        }
    }

    class Menu3 : Menu1
    {
        private int j = 1;
        public override void Calc(string n)
        {
            this.inputNama2 = n;
            while (j < inputNama2.Length)
            {
                Console.WriteLine(inputNama2[j]);
                j += 2;
            }
            Console.WriteLine(" ");
        }
    }

    class Menu4 : Menu1
    {
        private int k = 0;
        private int sum = 0;

        public override void Calc(int size)
        {
            this.inputArrSize = size;
            int[] arr = new int[inputArrSize];
            Console.WriteLine("Please input the array element ");
            while (k < inputArrSize)
            {
                int inputArray = Convert.ToInt32(Console.ReadLine());
                arr[k] = inputArray;
                k++;
            }
            foreach (int l in arr)
            {
                sum += l;
            }

        }
        //Encapsulation
        public int getSum()
        {
            return sum;
        }
    }
}
