namespace MyShop.Data.Infrastructer
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}