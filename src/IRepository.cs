using System;
using System.Collections.Generic;

namespace AspnetcoreAutofac
{
    public interface IRepository<T> : IDisposable
    {
        IEnumerable<T> GetAll();
    }
}

