﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestEj
{
    public struct ShelvePosition
    {
        public ShelvePosition(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public int Row { get; set; }
        public int Col { get; set; }

        
    }
}
