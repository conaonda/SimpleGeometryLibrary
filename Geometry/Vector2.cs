// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Vector2.cs" company="Conaonda">
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
//    Vector2.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
namespace SimpleGeometryLibrary.Geometry
{
    using SimpleGeometryLibrary.Numeric;

    /// <summary>2차원 벡터 클래스</summary>
    /// <typeparam name="T">값 유형</typeparam>
    public class Vector2<T> : VectorBase<T>
    {
        /// <summary>상속 전용 생성자</summary>
        /// <param name="dimension">차원 수</param>
        protected Vector2(byte dimension)
            : base(dimension)
        {
        }

        /// <summary>상속 전용 생성자</summary>
        /// <param name="dimension">차원 수</param>
        /// <param name="x">X 값</param>
        /// <param name="y">Y 값</param>
        protected Vector2(byte dimension, T x, T y)
            : base(dimension)
        {
            this.Factor[0] = x;
            this.Factor[1] = y;
        }

        /// <summary>기본 생성자</summary>
        public Vector2()
            : base(2)
        {
        }

        /// <summary>X, Y 값을 입력하여 객체를 생성</summary>
        /// <param name="x">X 값</param>
        /// <param name="y">Y 값</param>
        public Vector2(T x, T y)
            : this(2, x, y)
        {
        }

        /// <summary>X 값을 가져옴</summary>
        public T X => this[0];

        /// <summary>Y 값을 가져옴</summary>
        public T Y => this[1];

        /// <summary>길이를 가져옴</summary>
        public override double Length => ((Number<T>)this[0] * this[0] + (Number<T>)this[1] * this[1]).Sqrt();
    }
}