using System;
using Zenject;

namespace Managers
{
    public class BaseSceneManager
    {
        [Inject] protected ContentManager contentManager;
    }
}