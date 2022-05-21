using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalprograms
{
    internal class coupannumber
    {
        public void coupan()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string result = new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]) .ToArray());

            Console.WriteLine(result);

        }
    }
}
