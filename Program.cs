using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_36_module_5_homework_xmas_tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pp_36_module_5_homework_xmas_tree");
            Console.WriteLine(  );
            //此homework 使用[主控台應用程式(.NET Framework)]專案
            /*
             todo #0 請印出如下

    *
   ***
  *****
 *******
*********

            */

            Console.WriteLine("Choose a method: 0) Loop; 1) Recursive: ");
            int m = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please Enter an Old Number:");
            int width = Convert.ToInt16(Console.ReadLine());
            int test = width % 2;
            if (Convert.ToBoolean(test))
            {
                if (m == 0)
                {
                    for (int i = 0; i <= width / 2; i++)
                    {
                        int x_temp = 2 * i + 1;
                        int padding = width / 2 - i;
                        string temp = "";
                        for (int j = 1; j <= x_temp; j++)
                        {
                            temp += '*';
                        }
                        int temp2 = padding + temp.Length;
                        //Console.WriteLine(temp2);
                        string temp3 = temp.PadLeft(temp2,' ');
                        //Console.Write(temp3);
                        Console.WriteLine(temp3);
                        //Console.WriteLine("\n");
                    }
                }
                else if (m == 1)
                {
                    star(width, -1);
                }
            }
            else
            {
                Console.WriteLine("{0} Is Not an Old Number;", width);
                Console.WriteLine("Please Enter an Old Number.");
            }
            //int count = Recursive(width,0);

            Console.WriteLine();
            Console.WriteLine();
        }

        public static int star(int width0, int cnt)
        {
            if (cnt == width0 - 1)
            {
                return 1;
            }

            int i = ++cnt;
            int x_temp = Math.Abs(width0 - 2 * i - 1);
            int padding = Math.Abs(x_temp / 2 - width0 / 2);
            int x = ++x_temp;
            string temp = "";
            for (int j = 1; j <= x; j++)
            {
                temp += '*';
            }

            Console.WriteLine(temp.PadLeft(padding + temp.Length));
            return star(width0, cnt);
        }
    }
}
