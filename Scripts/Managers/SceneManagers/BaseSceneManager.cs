using System;
using Zenject;

namespace Managers
{
    public class BaseSceneManager
    {
        [Inject] protected ContentManager contentManager;
        [Inject] protected PersistenceManager persistenceManager;

        public int CMIncrement(int num)
        {
            return contentManager.Increment(num);
        }

        public int PMIncrement(int num)
        {
            return persistenceManager.Increment(num);
        }
    }
}