using System;

namespace Managers
{
    public class ContentManager
    {
        public int num = 5;
//        public PersistenceManager pers = new PersistenceManager();

        public int Increment(int num)
        {
            ChooseDeviceScreen cds;
            return ++num;
        }
    }
}