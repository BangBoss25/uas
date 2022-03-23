using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uas.Helper
{
    public class BanyakBantuan
    {
        public int BuatOTP()
        {
            Random start = new Random();

            int nilainya = start.Next(1000, 9999);

            return nilainya;
        }
    }
}
