using System;
using Zenject;

namespace Managers
{
    public class BaseSceneManager
    {
        [Inject] protected ContentManager contentManager;

        public int CMIncrement(int num)
        {
            return contentManager.Increment(num);
        }
    }
}