using System;

namespace Managers
{
    public class ContentManager
    {
        public int Increment(int num)
        {
            return ++num;
        }
        
        public int SingletonPMIncrement(int num)
        {
            return PersistenceManager.Singleton.Increment(num);
        }

        public int InstantiatedGlobalCDSIncrement(int num)
        {
            var cds = new ChooseDeviceScreen();

            return cds.Increment(num);
        }
    }
}