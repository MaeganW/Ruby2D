namespace Managers.ManagerInterfaces
{
    public interface IPersistenceManager
    {
        int Increment(int num);
        int InstantiatedCMIncrement(int num);
        int InstantiatedGlobalCDSIncrement(int num);
    }
}