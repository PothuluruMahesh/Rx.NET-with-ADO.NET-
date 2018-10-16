using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RxNetwithADO
{
    class Any1
    {
        static void Main(string[] args)
        {
            var subject = new Subject<int>();
            subject.Subscribe(Console.WriteLine, () => Console.WriteLine("Subject completed"));
            var any = subject.Any();
            any.Subscribe(b => Console.WriteLine("The subject has any values? : {0}", b));
           // subject.OnNext(1);
           // subject.OnNext(2);
           // subject.OnNext(3);
           // subject.OnNext(4);
            subject.OnCompleted();
        }
    }
}
