﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IStrategy
    {
        object DoAlgoritm(object data);
    }
}