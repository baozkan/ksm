using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new Foo();
            foo.Bar();

            var ifoo = foo as IFoo;

            ifoo.Foo();

            foo.Hello();

            Console.ReadKey();
        }
    }
}
