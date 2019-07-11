using System;

namespace Managers
{
    public class ContentManager
    {
        private ChooseDeviceScreen cds;
        
        public int Increment(int num)
        {
            return ++num;
        }
        
        public int SingletonPMIncrement(int num)
        {
            ChooseDeviceScreen cds;
            return PersistenceManager.Singleton.Increment(num);
        }
    }
}