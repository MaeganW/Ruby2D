using System;
using UnityEngine;
using Zenject;
using Managers.ManagerInterfaces;

namespace Managers
{
    public class BaseSceneManager
    {
        [Inject] protected IContentManager contentManager;
        [Inject] protected IPersistenceManager persistenceManager;

        public int Increment(int num)
        {
            return ++num;
        }

        public int InjectedCMIncrement(int num)
        {
            return contentManager.Increment(num);
        }

        public int InjectedPMIncrement(int num)
        {
            return persistenceManager.Increment(num);
        }

        public int SingletonPMIncrement(int num)
        {
            return PersistenceManager.Singleton.Increment(num);
        }
    }
}