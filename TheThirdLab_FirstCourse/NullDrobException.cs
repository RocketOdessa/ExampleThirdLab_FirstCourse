using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheThirdLab_FirstCourse
{
    class NullDrobException : Exception
    {
        public NullDrobException()
        {
            Console.WriteLine("UUuuups. we have a probleb with drob");
        }

        public NullDrobException(string message)
        {

        }

        public NullDrobException (string message , Exception drobException)
        {

        }
    }
}
