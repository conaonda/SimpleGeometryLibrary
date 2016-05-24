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

using System;
using SimpleGeometryLibrary.Numeric;

namespace SimpleGeometryLibrary.Geometry
{
    /// <summary>3차원 벡터 클래스</summary>
    /// <typeparam name="T">값 유형</typeparam>
    public class Vector3<T> : Vector<T> where T : IComparable, IConvertible
    {
        /// <summary>기본 생성자</summary>
        public Vector3() : base(3)
        {
        }

        /// <summary>X, Y, Z 값을 입력하여 객체를 생성</summary>
        /// <param name="x">X 값</param>
        /// <param name="y">Y 값</param>
        /// <param name="z">Z 값</param>
        public Vector3(T x, T y, T z)
            : base(new[]{x, y, z})
        {
        }
        
        /// <summary>
        /// Point3 객체를 입력하여 객체를 생성
        /// </summary>
        /// <param name="a">Point2 객체</param>
        public Vector3(Point3<T> a) : this(a.X, a.Y, a.Z)
        {
        }

        /// <summary>
        /// 벡터곱(외적)을 수행
        /// </summary>
        /// <param name="a">첫 번째 벡터</param>
        /// <param name="b">두 번째 벡터</param>
        /// <returns>곱해진 벡터</returns>
        public static Vector3<T> CrossProduct(Vector3<T> a, Vector3<T> b)
        {
            return new Vector3<T>(
                (Number<T>)((Number<T>)a[1] * b[2]) - (Number<T>)a[2] * b[1],
                (Number<T>)((Number<T>)a[2] * b[0]) - (Number<T>)a[0] * b[2],
                (Number<T>)((Number<T>)a[0] * b[1]) - (Number<T>)a[1] * b[0]
                );
        }

        /// <summary>
        /// 벡터곱(외적)을 수행
        /// </summary>
        /// <param name="other">입력 벡터</param>
        /// <returns>곱해진 벡터</returns>
        public Vector3<T> CrossProduct(Vector3<T> other)
        {
            return CrossProduct(this, other);
        }

        /// <summary>
        /// 배열 객체를 암묵적으로 Vector2 객체로 변환
        /// </summary>
        /// <param name="a">배열 객체</param>
        public static implicit operator Vector3<T>(T[] a)
        {
            return new Vector3<T>(a[0], a[1], a[2]);
        }
    }
}