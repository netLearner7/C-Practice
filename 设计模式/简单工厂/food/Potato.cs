﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 简单工厂
{
    public class Potato:food
    {
        public override void print()
        {
            Console.WriteLine("这是土豆！");
        }
    }
}
