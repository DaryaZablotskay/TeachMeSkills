using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lesson15
{
    public class Demo
    {
        private readonly IA _a;
        public Demo(IA a)
        {
            _a = a;
        }
        public void DemoMethods()
        {
            var a = _a;
        }
    }
    public class A :IA
    {
        private readonly IB _b;

        public A(IB b)
        {
            _b = b;
        }
    }
    public class B :IB
    {
        private readonly IC _c;

        public B(IC c)
        {
            _c = c;
            _c.Execute();
        }
    }
    public class C :IC
    {
        public void Execute()
        {

        }
    }
    public interface IA
    { }
    public interface IB
    { }
    public interface IC
    {
        public void Execute();
    }

}
