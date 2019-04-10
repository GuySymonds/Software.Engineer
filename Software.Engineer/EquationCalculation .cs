﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Software.Engineer
{
    public class EquationCalculation
    {
        #region Fields
        private readonly float[] _array;
        private readonly int _length;
        private readonly int _c;
        #endregion Fields

        #region Constructors
        public EquationCalculation(int c, float[] array) : this(c, array, array.Length) { }

        public EquationCalculation(int c, float[] array, int length)
        {
            _array = array;
            _length = length;
            _c = c;
        }
        #endregion Constructors

        #region Methods
        public float GetResult(int k, int j)
        {
            float sumOfArray = 0;
            for (int i = _c; i < _length; i++)
            {
                sumOfArray += _array[i];
            }

            float resultK = _array[k];
            float resultJ = _array[j];

            return sumOfArray * resultK * resultJ;
        }
        #endregion Methods
    }
}
