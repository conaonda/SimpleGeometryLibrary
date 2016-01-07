// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="IntNumber.cs" company="Conaonda">
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
//    IntNumber.cs Ŭ������ �����մϴ�.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
namespace SimpleGeometryLibrary.Numeric
{
    using System;

    /// <summary>
    /// ������ ���� Ŭ����
    /// </summary>
    public class IntNumber : Number<int>
    {
        /// <summary>
        /// �⺻ ������
        /// </summary>
        public IntNumber()
            : base(default(int))
        {
        }

        /// <summary>
        /// ���� ���� �Է��Ͽ� ��ü�� ����
        /// </summary>
        /// <param name="v">���� ��</param>
        public IntNumber(int v)
            : base(v)
        {
        }

        /// <summary>
        /// �Ͻ������� ���� ���� ���� ���� ��ü�� ��ȯ
        /// </summary>
        /// <param name="v">���� ��</param>
        public static implicit operator IntNumber(int v) => new IntNumber(v);

        /// <summary>���� ����</summary>
        /// <param name="a">�Է� ��</param>
        /// <returns>���� ��� ��</returns>
        protected override Number<int> Sum(int a) => this + a;

        /// <summary>���� ��</summary>
        /// <param name="a">�Է� ��</param>
        /// <returns>�� ��� ��</returns>
        protected override Number<int> Subtract(int a) => this - a;

        /// <summary>���� ����</summary>
        /// <param name="a">�Է� ��</param>
        /// <returns>���� ��� ��</returns>
        protected override Number<int> Multiply(int a) => this * a;

        /// <summary>���� ����</summary>
        /// <param name="a">�Է� ��</param>
        /// <returns>���� ��� ��</returns>
        protected override double Subdivision(int a) => this / a;

        /// <summary>�������� ���</summary>
        /// <returns>���� ������</returns>
        public override double Sqrt() => Math.Sqrt(this);

        /// <summary>�Է� ���� ���Ͽ� ���� ���� ������</summary>
        /// <param name="a">�Է� ��</param>
        /// <returns>�Է� ���� ���Ͽ� ���� ��</returns>
        public override int Min(int a) => Math.Min(this, a);

        /// <summary>�Է� ���� ���Ͽ� ū ���� ������</summary>
        /// <param name="a">�Է� ��</param>
        /// <returns>�Է� ���� ���Ͽ� ū ��</returns>
        public override int Max(int a) => Math.Max(this, a);
    }
}