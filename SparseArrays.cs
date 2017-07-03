using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] str = new string[n];
            for(int i=0;i<n;i++)
            {
                str[i] = Console.ReadLine();
            }
            int q = Convert.ToInt32(Console.ReadLine());
            string[] query = new string[q];

            for (int i = 0; i < q; i++)
            {
                query[i] = Console.ReadLine();
            }

            for(int i=0;i<q;i++)
            {
                string temp = query[i];
                int count = 0;
                foreach(string x in str)
                {
                    if(temp.Contains(x))
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }

            Console.ReadLine();
        }
    }
}
