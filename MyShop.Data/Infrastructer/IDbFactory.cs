using System;

namespace MyShop.Data.Infrastructer
{
    public interface IDbFactory :IDisposable
    {
        MyShopDbContext Init();
    }
}