﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraExtension.Extension
{
    public interface ICleaner : ISalary
    {
        int cleanRoom(int rooms);
    }
}
