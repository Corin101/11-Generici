using System;

namespace Vsite.CSharp
{
    abstract class Životinja
    {
        public abstract void PokreniSe();
    }
    class Riba : Životinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("Plivam");
        }
    }

    class Gmaz : Životinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("Gmižem");
        }
    }

    class Ptica : Životinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("Letim");
        }
    }

    class Sisavac : Životinja
    {
        public override void PokreniSe()
        {
            Console.WriteLine("Trčim");
        }
    }
}
