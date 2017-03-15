using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test
{
    public abstract class Class1
    {
        public int ii;
        public abstract void T();
       
    }
    public class la : Class1
    {
        int i;
        public override void T()
        {
            throw new NotImplementedException();
        }
        public void t1() {
            i = 1;
        }
    }
       public class cl1
        {
            la laa = new la();
        Class1 clll = new la();
        void ts()
        {
            la a = new la();
        }
        
        }

   
}