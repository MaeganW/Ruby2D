using System;

namespace Managers
{
    public class ContentManager
    {
        public int Increment(int num)
        {
            ChooseDeviceScreen cds;
            return PersistenceManager.Singleton.Increment(num);
        }
    }
}