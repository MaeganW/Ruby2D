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
       
       ChooseDeviceScreen cds;

       public int Increment(int num)
       {
           return ++num;
       }
       
       public int InstantiatedCMIncrement(int num)
       {
           ContentManager cm = new ContentManager();
           return cm.Increment(num);
       }
   }

}
