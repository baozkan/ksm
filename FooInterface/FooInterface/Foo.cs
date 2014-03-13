using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooInterface
{
    class Foo : IFoo
    {
        //imp.
        public void Bar()
        {
            Console.WriteLine("I am bar.");
        }

        //Exp.
        void IFoo.Foo()
        {
            Console.WriteLine("I am foo.");
        }

        public void Hello()
        {
            Console.WriteLine("Hello world.");
        }
    }
}
