using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace RxNetwithADO
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Count1
    {
        static void Main(string[] args)
        {
            var source = new Subject<Account>();
            //Evil code. It modifies the Account object.
           // source.Subscribe(account => account.Name = "Garbage");
            //unassuming well behaved code
            source.Subscribe(account => Console.WriteLine("{0} {1}", account.Id, account.Name),
            () => Console.WriteLine("completed"));
            source.OnNext(new Account { Id = 1, Name = "Microsoft" });
            source.OnNext(new Account { Id = 2, Name = "Google" });
            source.OnNext(new Account { Id = 3, Name = "IBM" });
            source.OnCompleted();
        }
    }
}
