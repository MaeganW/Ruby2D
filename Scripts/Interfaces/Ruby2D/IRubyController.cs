using UnityEngine;

namespace Ruby2DInterfaces
{
    public interface IRubyController
    {
        void ChangeHealth(int amount);
        int Increment(int num);
        int InjectedCMIncrement(int num);
    }
}