// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Vector3.cs" company="Conaonda">
//     The MIT License (MIT)
//     Copyright (c) 2016 Conaonda
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the "Software"), to deal
//     in the Software without restriction, including without limitation the rights
//     to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//     copies of the Software, and to permit persons to whom the Software is
//     furnished to do so, subject to the following conditions:
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//     LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//     SOFTWARE.
//  </copyright>
//  <summary>
//    Vector3.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
namespace SimpleGeometryLibrary.Geometry
{
    using Numeric;

    /// <summary>3차원 벡터 클래스</summary>
    /// <typeparam name="T">값 유형</typeparam>
    public class Vector3<T> : Point3<T>
    {
        public Vector3()
        {
            this.FactorChanged += this.CalcSize;
        }

        /// <summary>X, Y, Z 값을 입력하여 객체를 생성</summary>
        /// <param name="x">X 값</param>
        /// <param name="y">Y 값</param>
        /// <param name="z">Z 값</param>
        public Vector3(T x, T y, T z)
            : base(x, y, z)
        {
        }

        /// <summary>벡터의 크기를 가져옴</summary>
        public double Size { get; private set; }

        public Vector3<double> Normalize()
            => new Vector3<double>(
                (Number<T>)this[0] / this.Size, 
                (Number<T>)this[1] / this.Size, 
                (Number<T>)this[2] / this.Size);

        /// <summary>크기를 계산</summary>
        private void CalcSize()
        {
            this.Size = (
                ((Number<T>)this[0] * this[0]) +
                ((Number<T>)this[1] * this[1]) +
                ((Number<T>)this[2] * this[2])).Sqrt();
        }
    }
}