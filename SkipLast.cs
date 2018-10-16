using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RxNetwithADO
{
    class SkipLast
    {
        public static void Main(string[] args)
        {
            var subject = new Subject<int>();
            subject
            .SkipLast(3)
            .Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));
            // Console.WriteLine("Pushing 1");
            subject.OnNext(1);
           // Console.WriteLine("Pushing 2");
            subject.OnNext(2);
           // Console.WriteLine("Pushing 3");
            subject.OnNext(3);
           // Console.WriteLine("Pushing 4");
            subject.OnNext(4);
            subject.OnNext(5);
            subject.OnNext(6);
            subject.OnCompleted();
        }
    }
}
