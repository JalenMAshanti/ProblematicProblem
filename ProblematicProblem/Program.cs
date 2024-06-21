using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Threading;

namespace ProblematicProblem
{
     public class Program
     {
               
        static void Main(string[] args)
        {            
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.RunApplication();             
        }
     }
}