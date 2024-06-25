using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*int num;
             Console.WriteLine(" Enter the number 1 to 50:");
             num= Convert.ToInt32(Console.ReadLine());
             if(num>=50)
             {
            if (num % 2 == 0 && num % 3 == 0)
                 {
                     Console.WriteLine(" it is divisable by 2 and 3 {0}", num);

                 }
                 else 
                 {
                     Console.WriteLine(" it is not divisable by 2 and 3");
                 }


             }     

           Console.ReadLine();
            int i = 1, j = 100;
            Console.WriteLine("  all the multiples of 4 and 6 from 1 to 100 ");
            Console.ReadLine();
            for (i=1;i<=j;i++)
            {
                if(i%4==0 || i%6==0)
                {
                    Console.WriteLine(i);

                }
                
            }
            Console.ReadLine();

            int i = 1;int j = 50;
            int n=0;
            
            Console.ReadLine();
            for(i=1;i<=j;i++)
            {
                if(i%4==0 ||i%6==0)
                {
                    
                    n += i;

                }
            }

            Console.WriteLine("  the sum of all multiples of 4 and 6 from 1 to 50 " + n);
            Console.ReadLine();
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;

            }
            while (i < 5);
            

            Console.ReadLine();
            //int num1, num2, num3;
            int[] number = new int[5];
            number[0] = 10;
            number[1] = 20;
            number[2] = 30;
            number[3] = 40;
            number[4] = 50;
            string[] lastname = new string[10];
            lastname[0] = "sw";
            lastname[1] = "dd";
            double[] cost= new double[10];
            cost[0] = 110.5;
            string[] name = { "cat", "dog","kitten" };
            for(int i=0; i<number.Length; i++)
            Console.WriteLine(name[1]);

            for(int i=0;i<number.Length;i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.ReadLine();

            string[] animal = { "cat", "dog" };
            for (int i = 0; i < animal.Length; i++) {
                Console.WriteLine(animal[i]); }

            foreach (string i in animal)
            {

            Console.WriteLine(i); }
            Console.ReadLine();
            double[] price = {1.50, 2.75, 4.99, 3.20};//creating my double array
            double total = 0;
            for (int i = 0; i < price.Length; i++)
            {
                total += price[i];
            }
            Console.WriteLine("the total price is $" + total);
            Console.WriteLine(price[0]);
            Console.WriteLine(price[1]);
            Console.ReadLine();
            char[] letters = { 'a', 'e', 'i', 'o', 'u' };
            char largest = letters[0];
            for (int i = 1; i < letters.Length; i++)
            {
                if (letters[i] > largest)
                {
                    largest = letters[i];
                }
            }
            Console.WriteLine("the largest char is:  " + largest);
            Console.ReadLine();
            string[] menu = {"pizza", "pasta", "salad", "drinks"};
            int choice;
            Console.WriteLine(" welcome to restaurant");
            Console.WriteLine("here are option");
            for (int i = 0; i < menu.Length; i++) {
                Console.WriteLine((i + 1) + "." + menu[i]);
            }
            Console.WriteLine("enter the choice" + menu.Length + ");");

                choice=Convert.ToInt32(Console.ReadLine());
            if (choice >= 1 && choice <= menu.Length)
            {
                Console.WriteLine("you select" + menu[choice - 1]);
            }
            else
            {
                Console.WriteLine("invaild choice");
            }



            Console.ReadLine();  */
            int numa = 49;
            int numb = 35;
            char yes= 'y';
            char no = 'n';
            string result = "pass";
            Console.WriteLine(numa+numb);
            Console.WriteLine(yes + "or" + no);
            Console.WriteLine(result);
            Console.ReadLine();
            
        }
    }
}
