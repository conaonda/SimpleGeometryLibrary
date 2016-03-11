// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="NumberFactory.cs" company="Conaonda">
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
//    NumberFactory.cs Ŭ������ �����մϴ�.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
namespace SimpleGeometryLibrary.Numeric
{
    using System;

    /// <summary>���� ��ü ���� ���͸�</summary>
    internal class NumberFactory
    {
        /// <summary>���� ��ü�� ����</summary>
        /// <typeparam name="T">���� ����</typeparam>
        /// <param name="v">���� ��</param>
        /// <returns>���� ��ü</returns>
        public static object CreateNumeric<T>(IConvertible v)
        {
            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.Int32:
                    return new IntNumber(Convert.ToInt32(v));
                case TypeCode.Double:
                    return new DoubleNumber(Convert.ToDouble(v));
            }

            return new NotImplementedException("int�� double�� �ܿ��� ���������Դϴ�.");
        }
    }
}