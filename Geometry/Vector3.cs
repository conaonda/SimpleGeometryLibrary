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
namespace SimpleGeometryLibrary.Geometry
{
    using SimpleGeometryLibrary.Numeric;

    /// <summary>
    /// 3���� ���� Ŭ����
    /// </summary>
    /// <typeparam name="T">�� ����</typeparam>
    public class Vector3<T> : Vector2<T>
    {
        /// <summary>
        /// �⺻ ������
        /// </summary>
        public Vector3()
            : base(3)
        {
        }

        /// <summary>
        /// X, Y, Z ���� �Է��Ͽ� ��ü�� ����
        /// </summary>
        /// <param name="x">X ��</param>
        /// <param name="y">Y ��</param>
        /// <param name="z">Z ��</param>
        public Vector3(T x, T y, T z)
            : base(3, x, y)
        {
            this.Factor[2] = z;
        }

        /// <summary>
        /// Z ���� ������
        /// </summary>
        public T Z => this.Factor[2];

        /// <summary>���̸� ������</summary>
        public override double Length
            => ((Number<T>)this[0] * this[0] + (Number<T>)this[1] * this[1] + (Number<T>)this[2] * this[2]).Sqrt();
    }
}