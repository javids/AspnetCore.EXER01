using Session08.StateManagement.Dal;
using Session08.StateManager;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Session08.StateManagement.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new Session08Context())
            {
                
              //  Person person = ctx.People.FirstOrDefault();
               // ctx.Update<Person>(person, p => p.FirstName, p => p.LastName);
               // ctx.RemoveAll<Person>();
                ctx.SaveChanges();
            }


            Console.ReadLine();
        }
     

       
        //private static void UseModified(Session08Context ctx)
        //{
        //    Person person = ctx.People.FirstOrDefault();
        //    Console.WriteLine("Person: " + ctx.Entry(person).State);//Unchanged
        //    Console.WriteLine(ctx.Entry(person).Property(c => c.FirstName).IsModified);
        //    ctx.Entry(person).Property(c => c.FirstName).IsModified = true;
        //    Console.WriteLine("Person: " + ctx.Entry(person).State);//modified
        //    Console.WriteLine(ctx.Entry(person).Property(c => c.FirstName).IsModified);
        //    ctx.SaveChanges();
        //    Console.WriteLine("Person: " + ctx.Entry(person).State);//Unchanged
        //    Console.WriteLine(ctx.Entry(person).Property(c => c.FirstName).IsModified);
        //}


        //private static void Update02(Session08Context ctx)
        //{
        //    Person person = ctx.People.FirstOrDefault();
        //    Console.WriteLine("Person: " + ctx.Entry(person).State);//Unchanged
        //    ctx.People.Update(person);
        //    Console.WriteLine("Person: " + ctx.Entry(person).State);//Modified
        //    ctx.SaveChanges();
        //    Console.WriteLine("Person: " + ctx.Entry(person).State);//Unchanged
        //}

        //private static void update01(Session08Context ctx)
        //{
        //    Person person = ctx.People.FirstOrDefault();
        //    Console.WriteLine("Person: " + ctx.Entry(person).State);//Unchanged
        //    person.FirstName = "sa javid";
        //    Console.WriteLine("Person: " + ctx.Entry(person).State);//modified
        //}

        //private static void delete02(Session08Context ctx)
        //{
        //    Person person = ctx.People.FirstOrDefault();
        //    JobData job = new JobData
        //    {
        //        Title = "businessMan",
        //    };
        //    person.JobData = job;
        //    Console.WriteLine("Person: " + ctx.Entry(person).State);//Unchanged
        //    Console.WriteLine("JobData: " + ctx.Entry(job).State);//added
        //    ctx.People.Remove(person);
        //    Console.WriteLine("Person: " + ctx.Entry(person).State);//Deleted
        //    Console.WriteLine("JobData: " + ctx.Entry(job).State);//added
        //    ctx.SaveChanges();
        //    Console.WriteLine("Person: " + ctx.Entry(person).State);//Detached
        //    Console.WriteLine("JobData: " + ctx.Entry(job).State);//Detached
        //}

        //private static void delete01(Session08Context ctx)
        //{
        //    Person person = ctx.People.FirstOrDefault();
        //    JobData job = new JobData
        //    {
        //        Title = "businessMan",
        //    };
        //    Console.WriteLine("Person: " + ctx.Entry(person).State);//Unchanged
        //    Console.WriteLine("JobData: " + ctx.Entry(job).State);//Detached
        //    ctx.People.Remove(person);
        //    Console.WriteLine("Person: " + ctx.Entry(person).State);//Deleted
        //    Console.WriteLine("JobData: " + ctx.Entry(job).State);//
        //    ctx.SaveChanges();
        //    Console.WriteLine("Person: " + ctx.Entry(person).State);//Detached
        //    Console.WriteLine("JobData: " + ctx.Entry(job).State);//Detached
        //}

        //private static void Add03(Session08Context ctx)
        //{
        //    Person p = ctx.People.FirstOrDefault();
        //    JobData jb = new JobData
        //    {
        //        Title = "Programmer",
        //    };
        //    p.JobData = jb;
        //    Console.WriteLine("Person: " + ctx.Entry(p).State);//unchanged
        //    Console.WriteLine("JobData: " + ctx.Entry(jb).State);//Added becuse person tracked..            
        //    ctx.SaveChanges();
        //    Console.WriteLine("Person: " + ctx.Entry(p).State);//unchanged
        //    Console.WriteLine("JobData:  " + ctx.Entry(jb).State);//unchanged
        //}

        //private static void Add02(Session08Context ctx)
        //{
        //    Person p = new Person
        //    {
        //        FirstName = "ali",
        //        LastName = "hosseini",
        //        Age = 40,
        //    };
        //    JobData jb = ctx.Jobs.FirstOrDefault();
        //    p.JobData = jb;
        //    Console.WriteLine("Person: " + ctx.Entry(p).State);//detachd
        //    Console.WriteLine("JobData: " + ctx.Entry(jb).State);//unchanged
        //    ctx.People.Add(p);
        //    Console.WriteLine("Person: " + ctx.Entry(p).State);//added
        //    Console.WriteLine("JobData: " + ctx.Entry(jb).State);//modified
        //    ctx.SaveChanges();
        //    Console.WriteLine("Person: " + ctx.Entry(p).State);//unchanged
        //    Console.WriteLine("JobData:  " + ctx.Entry(jb).State);// unchanged
        //}

        //private static void Add01(Session08Context ctx)
        //{
        //    Person p = new Person
        //    {
        //        FirstName = "ali",
        //        LastName = "hosseini",
        //        Age = 40,
        //    };
        //    JobData jb = new JobData
        //    {
        //        Title = "Programmer",
        //    };
        //    p.JobData = jb;
        //    Console.WriteLine("Person: " + ctx.Entry(p).State);//detachd
        //    Console.WriteLine("JobData: " + ctx.Entry(jb).State);//detachd
        //    ctx.People.Add(p);
        //    Console.WriteLine("Person: " + ctx.Entry(p).State);//added
        //    Console.WriteLine("JobData: " + ctx.Entry(jb).State);//added
        //    ctx.SaveChanges();
        //    Console.WriteLine("Person: " + ctx.Entry(p).State);//unchanged
        //    Console.WriteLine("JobData:  " + ctx.Entry(jb).State);//unchanged
        //}
    }
}
