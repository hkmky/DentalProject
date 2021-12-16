﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Business.Workers
{
    public interface IWorker : IDisposable
    {
        bool HasChanges();
        void DetectChanges();
        bool Commit();
    }
}
