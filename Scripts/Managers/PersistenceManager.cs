using System;

namespace Managers
{
   public class PersistenceManager
   { 
       #region Singleton

       private static PersistenceManager self;
       private static readonly object singletonLock = new object();

       public static PersistenceManager Singleton
       {
           get
           {
               lock (singletonLock)
               {
                   if (self == null)
                       self = new PersistenceManager();
               }

               return self;
           }
       }

       #endregion
       
       
       
       
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
