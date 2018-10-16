using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RxNetwithADO
{
    class DefaltIfEmpty
    {
        static void Main(string[] args)
        {
            var subject = new Subject<int>();
            subject.Subscribe(Console.WriteLine,() => Console.WriteLine("Subject completed"));
/*
            var defaultIfEmpty = subject.DefaultIfEmpty();
            defaultIfEmpty.Subscribe(b => Console.WriteLine("defaultIfEmpty value: {0}", b),
            () => Console.WriteLine("defaultIfEmpty completed"));
*/
            var defaultIfEmpty1 = subject.DefaultIfEmpty(42);
            defaultIfEmpty1.Subscribe( b => Console.WriteLine("defaultIfEmpty1 value: {0}", b),
            () => Console.WriteLine("defaultIfEmpty1 completed"));

        //    subject.OnNext(1);
        //    subject.OnNext(2);
        //    subject.OnNext(3);
            subject.OnCompleted();
        }
    }
}
