using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Menampilkan Menu
                while (true)
                {
                    //Menu pembuka
                    Console.WriteLine("Input number from 1-4");

                    //Pilihan Menu
                    Console.WriteLine("1. Body Mas Index");
                    Console.WriteLine("2. Reprint Name");
                    Console.WriteLine("3. Print Even\'s Character");
                    Console.WriteLine("4. Sum The Inputted Array");
                    Console.WriteLine("");

                    //User memilih
                    string inputUserString = Console.ReadLine();
                    int inputUser = 0;

                    if (int.TryParse(inputUserString, out inputUser))
                    {
                        switch (inputUser)
                        {
                            //1. Body Mas Index
                            case 1:
                                Console.Write("Input your weight(kg): ");
                                int weight = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");

                                Console.Write("Input your height(cm): ");
                                int height = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");
                                if (height != 0)
                                {
                                    //Kalkulasi
                                    float bmi = (float)weight * 100 * 100 / (height * height);

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
                                else
                                {
                                    throw new DivideByZeroException();
                                }
                                break;

                            //2. Reprint Name
                            case 2:
                                Console.WriteLine("Please input your name ");
                                string inputNama = Console.ReadLine();
                                Console.WriteLine("");

                                //output
                                int i = 0; //iterator
                                while (i < inputNama.Length)
                                {
                                    Console.WriteLine("Huruf ke-{0} adalah {1}", i + 1, inputNama[i]);
                                    i++;
                                }
                                Console.WriteLine(" ");
                                break;

                            //3. Print Even's Character
                            case 3:
                                Console.WriteLine("Please input your name ");
                                string inputNama2 = Console.ReadLine();
                                Console.WriteLine("");

                                //output
                                int j = 1; //iterator
                                while (j < inputNama2.Length)
                                {
                                    Console.WriteLine(inputNama2[j]);
                                    j += 2;
                                }

                                Console.WriteLine(" ");
                                break;

                            //4. Sum the inputted Array
                            case 4:
                                Console.WriteLine("Please input the array size ");
                                int inputArrSize = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");

                                //Looping input nilai array
                                int k = 0;
                                int sum = 0;
                                int[] arr = new int[inputArrSize];
                                
                                if (inputArrSize > 0)
                                {
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

                                    Console.WriteLine("The sum of the inputted array is {0}", sum);
                                    Console.WriteLine(" ");
                                }
                                else
                                {
                                    throw new ArithmeticException();
                                }
                                break;

                            default:
                                Console.WriteLine("Please input number from 1-4!");
                                Console.WriteLine(" ");
                                break;
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                    //Menu restart
                    Console.WriteLine("Type \'yes\' to restart program");

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
                Console.WriteLine("INPUT SHOULD BE STRING");
            }   
        }


    }
}
