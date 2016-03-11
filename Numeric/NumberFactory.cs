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
//    NumberFactory.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
namespace SimpleGeometryLibrary.Numeric
{
    using System;

    /// <summary>숫자 객체 생성 팩터리</summary>
    internal class NumberFactory
    {
        /// <summary>숫자 객체를 생성</summary>
        /// <typeparam name="T">숫자 유형</typeparam>
        /// <param name="v">숫자 값</param>
        /// <returns>숫자 객체</returns>
        public static object CreateNumeric<T>(IConvertible v)
        {
            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.Int32:
                    return new IntNumber(Convert.ToInt32(v));
                case TypeCode.Double:
                    return new DoubleNumber(Convert.ToDouble(v));
            }

            return new NotImplementedException("int와 double형 외에는 지원예정입니다.");
        }
    }
}