﻿using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Color:IEntity
    {
        public Color()
        {
        }

        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
