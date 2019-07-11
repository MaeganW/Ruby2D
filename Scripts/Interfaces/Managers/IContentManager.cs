namespace Managers.ManagerInterfaces
{
    public interface IContentManager
    {
        int Increment(int num);
        int InstantiatedGlobalCDSIncrement(int num);
        int SingletonPMIncrement(int num);
    }
}