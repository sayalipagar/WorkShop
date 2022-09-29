using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdditionUsinGeneric
{
    public class Addition<T>
    {
        T result;
        public void addme(T a1 ,T b1)
        {
            dynamic x=a1;
            dynamic y=b1;
            Console.WriteLine("Addition is");
            result = x + y;
            Console.WriteLine(result);
           
        }
    }
}
 