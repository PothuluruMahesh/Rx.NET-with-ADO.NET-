using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RxNetwithADO
{
    class ElementAt
    {
        static void Main(string[] args)
        {
            var subject = new Subject<int>();
            subject.Subscribe(Console.WriteLine,() => Console.WriteLine("Subject completed"));

            var elementAt1 = subject.ElementAt(5);
            elementAt1.Subscribe(b => Console.WriteLine("elementAt5 value: {0}", b),
            () => Console.WriteLine("elementAt5 completed"));
            subject.OnNext(11);
            subject.OnNext(22);
            subject.OnNext(33);
            subject.OnNext(44);
            subject.OnNext(55);
            subject.OnNext(66);
            subject.OnNext(77);
            subject.OnNext(88);
            subject.OnCompleted();
        }
    }
}
