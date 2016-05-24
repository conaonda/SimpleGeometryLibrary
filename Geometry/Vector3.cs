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
//    Vector3.cs Ŭ������ �����մϴ�.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------

using System;
using SimpleGeometryLibrary.Numeric;

namespace SimpleGeometryLibrary.Geometry
{
    /// <summary>3���� ���� Ŭ����</summary>
    /// <typeparam name="T">�� ����</typeparam>
    public class Vector3<T> : Vector<T> where T : IComparable, IConvertible
    {
        /// <summary>�⺻ ������</summary>
        public Vector3() : base(3)
        {
        }

        /// <summary>X, Y, Z ���� �Է��Ͽ� ��ü�� ����</summary>
        /// <param name="x">X ��</param>
        /// <param name="y">Y ��</param>
        /// <param name="z">Z ��</param>
        public Vector3(T x, T y, T z)
            : base(new[]{x, y, z})
        {
        }
        
        /// <summary>
        /// Point3 ��ü�� �Է��Ͽ� ��ü�� ����
        /// </summary>
        /// <param name="a">Point2 ��ü</param>
        public Vector3(Point3<T> a) : this(a.X, a.Y, a.Z)
        {
        }

        /// <summary>
        /// ���Ͱ�(����)�� ����
        /// </summary>
        /// <param name="a">ù ��° ����</param>
        /// <param name="b">�� ��° ����</param>
        /// <returns>������ ����</returns>
        public static Vector3<T> CrossProduct(Vector3<T> a, Vector3<T> b)
        {
            return new Vector3<T>(
                (Number<T>)((Number<T>)a[1] * b[2]) - (Number<T>)a[2] * b[1],
                (Number<T>)((Number<T>)a[2] * b[0]) - (Number<T>)a[0] * b[2],
                (Number<T>)((Number<T>)a[0] * b[1]) - (Number<T>)a[1] * b[0]
                );
        }

        /// <summary>
        /// ���Ͱ�(����)�� ����
        /// </summary>
        /// <param name="other">�Է� ����</param>
        /// <returns>������ ����</returns>
        public Vector3<T> CrossProduct(Vector3<T> other)
        {
            return CrossProduct(this, other);
        }

        /// <summary>
        /// �迭 ��ü�� �Ϲ������� Vector2 ��ü�� ��ȯ
        /// </summary>
        /// <param name="a">�迭 ��ü</param>
        public static implicit operator Vector3<T>(T[] a)
        {
            return new Vector3<T>(a[0], a[1], a[2]);
        }
    }
}