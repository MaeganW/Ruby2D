using System;
using Managers.ManagerInterfaces;

namespace Managers
{
   public class PersistenceManager: IPersistenceManager
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
       

       public int Increment(int num)
       {
           return ++num;
       }
       
       public int InstantiatedCMIncrement(int num)
       {
           ContentManager cm = new ContentManager();
           return cm.Increment(num);
       }

       public int InstantiatedGlobalCDSIncrement(int num)
       {
           var cds = new ChooseDeviceScreen();
           return cds.Increment(num);
       }
       
   }

}
