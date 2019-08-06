using Blog.Core.IRepository;
using Blog.Core.IServices;
using Blog.Core.Repository;
using System;

namespace Blog.Core.Services
{
    public class AdvertisementServices : IAdvertisementServices
    {
        IAdvertisementRepository dal = new AdvertisementRepository();
        public int Sum(int i, int j)
        {
            return dal.Sum(i, j);
        }
    }
}
