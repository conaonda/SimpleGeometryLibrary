// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Point2.cs" company="Conaonda">
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
//    Point2.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using SimpleGeometryLibrary.Numeric;

namespace SimpleGeometryLibrary.Geometry
{
    /// <summary>2차원 벡터 클래스</summary>
    /// <typeparam name="T">값 유형</typeparam>
    public class Point2<T> : Vector2<T> where T : IComparable, IConvertible 
    {
        /// <summary>기본 생성자</summary>
        public Point2()
        {
        }

        /// <summary>X, Y 값을 입력하여 객체를 생성</summary>
        /// <param name="x">X 값</param>
        /// <param name="y">Y 값</param>
        public Point2(T x, T y) : base(x, y)
        {
        }

        /// <summary>
        /// Vector2를 입력하여 객체를 생성
        /// </summary>
        /// <param name="a">Vector2 객체</param>
        public Point2(Vector2<T> a) : base(a[0], a[1])
        {
        }

        /// <summary>X 값을 가져옴</summary>
        public T X
        {
            get { return this[0]; }
            set { this[0] = value; }
        }

        /// <summary>Y 값을 가져옴</summary>
        public T Y
        {
            get { return this[1]; }
            set { this[1] = value; }
        }

        /// <summary>
        /// 배열 객체를 암묵적으로 Vector2 객체로 변환
        /// </summary>
        /// <param name="a">배열 객체</param>
        public static implicit operator Point2<T>(T[] a)
        {
            return new Point2<T>(a[0], a[1]);
        }
    }
}