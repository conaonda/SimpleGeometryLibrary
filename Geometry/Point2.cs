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
//    Point2.cs Ŭ������ �����մϴ�.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using SimpleGeometryLibrary.Numeric;

namespace SimpleGeometryLibrary.Geometry
{
    /// <summary>2���� ���� Ŭ����</summary>
    /// <typeparam name="T">�� ����</typeparam>
    public class Point2<T> : Vector2<T> where T : IComparable, IConvertible 
    {
        /// <summary>�⺻ ������</summary>
        public Point2()
        {
        }

        /// <summary>X, Y ���� �Է��Ͽ� ��ü�� ����</summary>
        /// <param name="x">X ��</param>
        /// <param name="y">Y ��</param>
        public Point2(T x, T y) : base(x, y)
        {
        }

        /// <summary>
        /// Vector2�� �Է��Ͽ� ��ü�� ����
        /// </summary>
        /// <param name="a">Vector2 ��ü</param>
        public Point2(Vector2<T> a) : base(a[0], a[1])
        {
        }

        /// <summary>X ���� ������</summary>
        public T X
        {
            get { return this[0]; }
            set { this[0] = value; }
        }

        /// <summary>Y ���� ������</summary>
        public T Y
        {
            get { return this[1]; }
            set { this[1] = value; }
        }

        /// <summary>
        /// �迭 ��ü�� �Ϲ������� Vector2 ��ü�� ��ȯ
        /// </summary>
        /// <param name="a">�迭 ��ü</param>
        public static implicit operator Point2<T>(T[] a)
        {
            return new Point2<T>(a[0], a[1]);
        }
    }
}