﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Blog.Core.Model;

namespace Blog.Core.IServices
{
    public interface IAdvertisementServices
    {
        int Sum(int i, int j);
        int Add(Advertisement model);
        bool Delete(Advertisement model);
        bool Update(Advertisement model);
        List<Advertisement> Query(Expression<Func<Advertisement, bool>> whereExpression);
    }
}
