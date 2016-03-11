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

using System;

namespace SimpleGeometryLibrary.Geometry
{
    using Numeric;

    /// <summary>2차원 벡터 클래스</summary>
    /// <typeparam name="T">값 유형</typeparam>
    public class Vector2<T> : Vector<T> where T : IComparable, IConvertible
    {
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public Vector2() : base(2)
        {
        }

        /// <summary>
        /// 두 개의 값을 입력하여 객체를 생성
        /// </summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        public Vector2(Number<T> a, Number<T> b)
            : base(new[] {a, b})
        {
        }

        /// <summary>
        /// Point2 객체를 입력하여 객체를 생성
        /// </summary>
        /// <param name="a">Point2 객체</param>
        public Vector2(Point2<T> a) : this(a.X, a.Y)
        {
        }

        /// <summary>
        /// 배열 객체를 암묵적으로 Vector2 객체로 변환
        /// </summary>
        /// <param name="a">배열 객체</param>
        public static implicit operator Vector2<T>(Number<T>[] a)
        {
            return new Vector2<T>(a[0], a[1]);
        }
    }
}