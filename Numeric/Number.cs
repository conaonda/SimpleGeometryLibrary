// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Number.cs" company="Conaonda">
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
//    Number.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
namespace SimpleGeometryLibrary.Numeric
{
    using System;
    using System.Reflection;

    /// <summary>제네릭 숫자 클래스</summary>
    /// <typeparam name="T">숫자 유형</typeparam>
    public abstract class Number<T>
    {
        /// <summary>상속 전용 생성자</summary>
        /// <param name="v">숫자 값</param>
        protected Number(T v)
        {
            this.Value = v;
        }

        /// <summary>값을 가져옴</summary>
        public T Value { get; }

        // public static implicit operator Number<T>(T v) => new Number<T>(v);
        /// <summary>값의 최대치를 가져옴</summary>
        /// <value>값의 최대치</value>
        public static Number<T> MaxValue
        {
            get
            {
                var maxValueField = typeof(T).GetField("MaxValue", BindingFlags.Public | BindingFlags.Static);
                if (maxValueField == null) throw new NotSupportedException(typeof(T).Name);
                return (T)maxValueField.GetValue(null);
            }
        }

        /// <summary>값의 최소치를 가져옴</summary>
        /// <value>값의 최소치</value>
        public static Number<T> MinValue
        {
            get
            {
                var maxValueField = typeof(T).GetField("MinValue", BindingFlags.Public | BindingFlags.Static);
                if (maxValueField == null) throw new NotSupportedException(typeof(T).Name);
                return (T)maxValueField.GetValue(null);
            }
        }

        /// <summary>암시적으로 제네릭 숫자 객체를 값으로 변환</summary>
        /// <param name="self">제네릭 숫자 객체</param>
        public static implicit operator T(Number<T> self) => self.Value;

        /// <summary>암시적으로 값을 제네릭 숫자 객체로 변환</summary>
        /// <param name="v"></param>
        public static implicit operator Number<T>(T v) => NumericFactory.CreateNumeric<T>(v) as Number<T>;

        /// <summary>두 값을 더함</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>더한 결과 값을 가지는 제네릭 숫자 객체</returns>
        public static Number<T> operator +(Number<T> a, Number<T> b) => a.Sum(b);

        /// <summary>두 값을 뺌</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>뺀 결과 값을 가지는 제네릭 숫자 객체</returns>
        public static Number<T> operator -(Number<T> a, Number<T> b) => a.Subtract(b);

        /// <summary>두 값을 곱함</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>곱한 결과 값을 가지는 제네릭 숫자 객체</returns>
        public static Number<T> operator *(Number<T> a, Number<T> b) => a.Multiply(b);

        /// <summary>두 값을 나눔</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns> 결과 값을 가지는 제네릭 숫자 객체</returns>
        public static double operator /(Number<T> a, Number<T> b) => a.Subdivision(b);

        /// <summary>제곱근을 계산</summary>
        /// <returns>계산된 제곱근</returns>
        public abstract double Sqrt();

        /// <summary>입력 값과 비교하여 작은 값을 가져옴</summary>
        /// <param name="a">입력 값</param>
        /// <returns>입력 값과 비교하여 작은 값</returns>
        public abstract T Min(T a);

        /// <summary>입력 값과 비교하여 큰 값을 가져옴</summary>
        /// <param name="a">입력 값</param>
        /// <returns>입력 값과 비교하여 큰 값</returns>
        public abstract T Max(T a);

        /// <summary>값을 합함</summary>
        /// <param name="a">입력 값</param>
        /// <returns>합한 결과 값</returns>
        protected abstract Number<T> Sum(T a);

        /// <summary>값을 뺌</summary>
        /// <param name="a">입력 값</param>
        /// <returns>뺀 결과 값</returns>
        protected abstract Number<T> Subtract(T a);

        /// <summary>값을 곱함</summary>
        /// <param name="a">입력 값</param>
        /// <returns>곱한 결과 값</returns>
        protected abstract Number<T> Multiply(T a);

        /// <summary>값을 나눔</summary>
        /// <param name="a">입력 값</param>
        /// <returns>나눈 결과 값</returns>
        protected abstract double Subdivision(T a);
    }
}