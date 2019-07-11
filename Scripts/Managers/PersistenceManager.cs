using System;

namespace Managers
{
   public class PersistenceManager
   { 
       public int num = 5;
       public ContentManager cm = new ContentManager();

       public int Increment(int num)
       {
           ChooseDeviceScreen cds;
           return ++num;
       }
       
        public string Concat(string val)
        { 
            return val += "!";
        }

        public int CMIncrement(int num)
        {
            return cm.Increment(num);
        }
   }

}
