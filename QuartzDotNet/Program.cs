using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzDotNet
{
    class Program
    {
       public static void Main(string[] args)
        {
            JobExecute.ExecuteJob().GetAwaiter();
            Console.ReadLine();
        }

       
    }
   

}
