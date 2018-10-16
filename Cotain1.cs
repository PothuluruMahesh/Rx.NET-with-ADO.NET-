using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RxNetwithADO
{
    class Contain
    {
        static void Main(string[] args)
        {
            var subject = new Subject<int>();
            subject.Subscribe(
            Console.WriteLine,() => Console.WriteLine("Subject completed"));
            var contains = subject.Contains(4);
            contains.Subscribe(b => Console.WriteLine("Contains the value 2? {0}", b),
            () => Console.WriteLine("contains completed"));
            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
          //  subject.OnNext(4); //true
            subject.OnNext(5);
            subject.OnNext(6);
            subject.OnCompleted();//false
        }
    }
}
