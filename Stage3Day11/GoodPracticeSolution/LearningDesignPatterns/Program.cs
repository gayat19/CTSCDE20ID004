using System;
using System.Collections.Generic;

namespace LearningDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            //ConnectionSingleton singleton1 = ConnectionSingleton.GetInstance();
            //singleton1.check = 100;
            //Console.WriteLine("After getting the first instance "+singleton1.check);
            //ConnectionSingleton singleton2 = ConnectionSingleton.GetInstance();
            //Console.WriteLine("After getting the second instance " + singleton2.check);
            //Console.WriteLine("Hello World!");
            //AccountFactory factory = new AccountFactory();
            //accounts.Add(factory.CreateAccounts("0000099881"));
            //accounts.Add(factory.CreateAccounts("1111099881"));
            //accounts.Add(factory.CreateAccounts("0000099882"));
            //foreach (var item in accounts)
            //{
            //    Console.WriteLine(item.AccountNumber+" "+item.AccountType);
            //}
            //IBuildCompany builder = new CompanyBuilder();
            //CompanyDirector director = new CompanyDirector();
            //director.Construct(builder);
            //MyCompany company = builder.GetCompany();
            //Console.WriteLine(company);
            //ISource source = new SourceAdapter();
            //source.CheckSource();
            //OtherSenior root = new OtherSenior("SerniorMost1");
            //root.Add(new Student("RamuStudent"));
            //root.Add(new Student("SomuStudent"));
            //root.Add(new Student("BimuStudent"));
            //OtherSenior branch = new OtherSenior("SerniorJunior1");
            //branch.Add(new Student("RamuJrStudent"));
            //branch.Add(new Student("SomuJrStudent"));
            //branch.Add(new Student("BimuJrStudent"));
            //root.Add(branch);
            //Student leaf = new Student("DirectRamu");
            //root.Add(new Student("Check1"));
            //root.Add(new Student("Check2"));
            //root.Add(leaf);
            //root.Display(1);
            AggregateChild c = new AggregateChild();
            c[0] = "Element 1";
            c[1] = "Element 2";
            c[2] = "Element 3";
            MyIteraror i = c.GetIterator();
            object fi = i.First();
            while(fi != null)
            {
                Console.WriteLine(fi);
                fi = i.Next();
            }
            Console.ReadKey();
        }
    }
}
