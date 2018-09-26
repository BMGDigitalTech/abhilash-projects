using System;

namespace MultClassInheritance
{
    public interface IA
    {
        void AMethod();
    }

    public class A : IA
    {
        public void AMethod()
        {
            Console.WriteLine("A Method from class A");
        }
    }

    public interface IB
    {
        void BMethod();
    }

    public class B: IB
    {
        public void BMethod()
        {
            Console.WriteLine("B Method from class B");
        }
    }

    public class C: IA, IB
    {
        A aclass = new A();
        B bclass = new B();

        public void AMethod()
        {
            aclass.AMethod();
        }

        public void BMethod()
        {
            bclass.BMethod();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C cclass = new C();
            cclass.AMethod();
            cclass.BMethod();
        }
    }
}
