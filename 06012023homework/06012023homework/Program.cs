using System;

namespace _06012023homework
{
    internal class Program
    {
 

        static void Main(string[] args)
        {
            var nt1 = new Notebook { Name = "Acer1", Price = 1200, RAM = 2, Storage = 500 };
            var nt2 = new Notebook { Name = "Acer2", Price = 1400, RAM = 2, Storage = 500 };
            var nt3 = new Notebook { Name = "Acer3", Price = 1600, RAM = 2, Storage = 500 };
            var ph1 = new Phone { Name = "Iphone1", Price = 500, Camera = 4, SimCount = 1 };
            var ph2 = new Phone { Name = "Iphone11", Price = 1500, Camera = 4, SimCount = 1 };
            var ph3 = new Phone { Name = "Iphone12", Price = 2500, Camera = 4, SimCount = 1 };
            var ph4 = new Phone { Name = "Iphone13", Price = 3500, Camera = 4, SimCount = 1 };
            Product[] products = { nt1, ph1, nt2, ph2, nt3, ph3, ph4 };
         


            string opt;
            do
            {
                
                Console.WriteLine("1. Butun mehsullara bax");
                Console.WriteLine("2. Notebooklara bax");
                Console.WriteLine("3. Telefonlara bax");
                Console.WriteLine("4. Notebooklarin sayina bax");
                Console.WriteLine("5. Telefonlarin sayina bax");
                Console.WriteLine("6. Notebooklarin ortalama qiymetine bax");
                Console.WriteLine("7. Telefonlarin ortalama qiymetine bax");
                Console.WriteLine("0. Exit");
                
                opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine(products[i].Name + "-" + products[i].Price);
                        }
                        break;
                    case "2":
                        for (int i = 0; i < products.Length; i++)
                        {if (products[i] is Notebook)
                            Console.WriteLine(products[i].Name + "-" + products[i].Price);
                        }
                        break;
                    case "3":
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Phone)
                                Console.WriteLine(products[i].Name + "-" + products[i].Price);
                        }
                        break;
                    case "4":
                        int NotebookCount = 0;
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Notebook)
                                NotebookCount++;
                            Console.WriteLine("Notebook sayi:" + NotebookCount);

                        }
                        break;
                    case "5":
                        int PhoneCount = 0;
                        for (int i = 0; i < products.Length; i++)
                        {
                            if (products[i] is Phone)
                                PhoneCount++;
                            Console.WriteLine("Phone sayi:" + PhoneCount);

                        }
                        break;
                    case "6":
                        int sum = 0;
                        int count = 0;
                        int avg = 0;
                        Product[] notebooks = products;

                        for (int i = 0; i < products.Length; i++)
                        {
                            if (notebooks[i] is Notebook)
                            {
                                count++;
                                sum +=notebooks[i].Price;
                               
                            }
                            

                        }
                        if (count == 0)

                            Console.WriteLine("Notebook yoxdur:");
                        else
                        {
                            avg = sum / count;

                        }
                        Console.WriteLine($"avg price:{avg}");

                        break;
                    case "7":
                        int sumphone = 0;
                        int countphone = 0;
                        int avgphone = 0;
                        Product[] phones = products;

                        for (int i = 0; i < products.Length; i++)
                        {
                            if (phones[i] is Phone)
                            {
                                countphone++;
                                sumphone += phones[i].Price;

                            }
                            
                        }
                        if (countphone == 0)
                            Console.WriteLine("Phones yoxdur");
                        else { avgphone = sumphone / countphone; }
                        Console.WriteLine($"avg price:{avgphone}");
                        break;
                    case "0":
                        Console.WriteLine("Proses bitdi");
                        break;
                    default:
                        Console.WriteLine("Duzgun sechim et");
                        break;

                }
            } while (opt!="0");


        }
    }
}
