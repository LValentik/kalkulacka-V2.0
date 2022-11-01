using System;

namespace trénink
{
    class Program
    {
        static void Main(string[] args)
        {
            double cislo = 0;
            double cislo2 = 0;
            double vysledek = 0.0;
            string num;
            int count = 0;
            bool run = false;
            Console.WriteLine("Chcete spustit program?");
            string start = Console.ReadLine();
            if (start == "ano")
            {
                run = true;
            }

            else
            {
                run = false;
            }

            while (run == true)
            {
                Console.WriteLine("Kolik čísel má váš příklad?");
                count = int.Parse(Console.ReadLine());
               

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Vložte číslo/operátor");
                    num = Console.ReadLine();

                    if (num == "+")
                    {
                        vysledek = vysledek + cislo2;
                    }

                    else if (num == "-")
                    {
                        vysledek = vysledek - cislo2;
                    }

                    else if (num == "/")
                    {
                        vysledek = vysledek / cislo2;
                    }

                    else if (num == "*")
                    {
                        vysledek = vysledek * cislo2;
                    }
                    else
                    {
                        cislo = double.Parse(num);
                        cislo2 = cislo2 + cislo;
                        num = num.ToString();
                    }
                }
                Console.WriteLine("Váš výsledek je: " + vysledek);
                vysledek = 0;
                Console.WriteLine("Chcete program spustit znovu?");
                start = Console.ReadLine();
                if (start == "ano")
                {
                    run = true;
                }

                else
                {
                    run = false;
                }




                


            }
            Console.ReadLine();




            





        }
    }
}
