﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        ICarRepository CarRepository { get; }
    }
}
