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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace SimpleGeometryLibrary.Numeric
{
    /// <summary>제네릭 숫자 클래스</summary>
    /// <typeparam name="T">숫자 유형</typeparam>
    public abstract class Number<T> where T : IComparable, IConvertible
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
                var maxValueField = typeof (T).GetField("MaxValue",
                    BindingFlags.Public | BindingFlags.Static);
                if (maxValueField == null)
                    throw new NotSupportedException(typeof (T).Name);
                return (T) maxValueField.GetValue(null);
            }
        }

        /// <summary>값의 최소치를 가져옴</summary>
        /// <value>값의 최소치</value>
        public static Number<T> MinValue
        {
            get
            {
                var maxValueField = typeof (T).GetField("MinValue",
                    BindingFlags.Public | BindingFlags.Static);
                if (maxValueField == null)
                    throw new NotSupportedException(typeof (T).Name);
                return (T) maxValueField.GetValue(null);
            }
        }

        /// <summary>암시적으로 제네릭 숫자 객체를 double 값으로 변환</summary>
        /// <param name="self">제네릭 숫자 객체</param>
        public static explicit operator double(Number<T> self)
            => Convert.ToDouble(self.Value);

        /// <summary>암시적으로 제네릭 숫자 객체를 값으로 변환</summary>
        /// <param name="self">제네릭 숫자 객체</param>
        public static implicit operator T(Number<T> self) => self.Value;

        /// <summary>암시적으로 값을 제네릭 숫자 객체로 변환</summary>
        /// <param name="v"></param>
        public static implicit operator Number<T>(T v)
            => NumberFactory.CreateNumeric<T>(v) as Number<T>;

        /// <summary>두 값을 더함</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>더한 결과 값을 가지는 제네릭 숫자 객체</returns>
        public static Number<T> operator +(Number<T> a, Number<T> b) => a.Sum(b);

        /// <summary>두 값을 뺌</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>뺀 결과 값을 가지는 제네릭 숫자 객체</returns>
        public static Number<T> operator -(Number<T> a, Number<T> b)
            => a.Subtract(b);

        /// <summary>두 값을 곱함</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>곱한 결과 값을 가지는 제네릭 숫자 객체</returns>
        public static Number<T> operator *(Number<T> a, Number<T> b)
            => a.Multiply(b);

        /// <summary>두 값을 나눔</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>결과 값을 가지는 제네릭 숫자 객체</returns>
        public static Number<T> operator /(Number<T> a, Number<T> b)
            => a.Subdivision(b);

        /// <summary>반대 부호의 값을 가져옴</summary>
        /// <param name="a">입력 값</param>
        /// <returns>반대 부호의 값</returns>
        public static Number<T> operator -(Number<T> a) => a * FromNumber(-1);

        /// <summary>첫 번째 값의 두 번째 값보다 작음 여부를 가져옴</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>첫 번째 값의 두 번째 값보다 작음 여부</returns>
        public static bool operator <(Number<T> a, Number<T> b)
            => a.Value.CompareTo(b.Value) < 0;

        /// <summary>첫 번째 값의 두 번째 값보다 큼 여부를 가져옴</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>첫 번째 값의 두 번째 값보다 큼 여부</returns>
        public static bool operator >(Number<T> a, Number<T> b)
            => 0 < a.Value.CompareTo(b.Value);

        /// <summary>두 값의 다름 여부를 가져옴</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>두 값의 다름 여부</returns>
        public static bool operator !=(Number<T> a, Number<T> b)
        {
            return !(a == b);
        }

        /// <summary>두 값의 같음 여부를 가져옴</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>두 값의 같음 여부</returns>
        public static bool operator ==(Number<T> a, Number<T> b)
        {
            if (object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (object.ReferenceEquals(a, null) || object.ReferenceEquals(b, null))
            {
                return false;
            }

            return a.Value.CompareTo(b.Value) == 0;
        }

        /// <summary>첫 번째 값의 두 번째 값과 같거나 작음 여부를 가져옴</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>첫 번째 값의 두 번째 값과 같거나 작음 여부</returns>
        public static bool operator <=(Number<T> a, Number<T> b)
            => a == b || a < b;

        /// <summary>첫 번째 값의 두 번째 값과 같거나 큼 여부를 가져옴</summary>
        /// <param name="a">첫 번째 값</param>
        /// <param name="b">두 번째 값</param>
        /// <returns>첫 번째 값의 두 번째 값과 같거나 큼 여부</returns>
        public static bool operator >=(Number<T> a, Number<T> b)
            => a == b || a > b;

        /// <summary>IConvertible을 상속받은 객체로부터 객체를 생성</summary>
        /// <param name="i">IConvertible을 상속받은 객체</param>
        /// <returns>생성된 객체</returns>
        public static Number<T> FromNumber(IConvertible i)
        {
            return NumberFactory.CreateNumeric<T>(i) as Number<T>;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Number<T> Sum(IEnumerable<Number<T>> value)
        {
            return value.Aggregate(default(T), (current, v) => current + v);
        }

        /// <summary>지정한 개체와 현재 개체가 같은지 여부를 확인합니다.</summary>
        /// <returns>지정한 개체가 현재 개체와 같으면 true이고, 그렇지 않으면 false입니다.</returns>
        /// <param name="obj">현재 개체와 비교할 개체입니다. </param>
        /// <filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() &&
                   this.Equals((Number<T>) obj);
        }

        /// <summary>기본 해시 함수로 작동합니다.</summary>
        /// <returns>현재 개체의 해시 코드입니다.</returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            return EqualityComparer<T>.Default.GetHashCode(this.Value);
        }

        /// <summary>
        /// 현재 개체를 나타내는 문자열을 반환합니다.
        /// </summary>
        /// <returns>
        /// 현재 개체를 나타내는 문자열입니다.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            return this.Value.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>제곱근을 계산</summary>
        /// <returns>계산된 제곱근</returns>
        public abstract Number<T> Sqrt();

        /// <summary>입력 값과 비교하여 작은 값을 가져옴</summary>
        /// <param name="a">입력 값</param>
        /// <returns>입력 값과 비교하여 작은 값</returns>
        public abstract Number<T> Min(Number<T> a);

        /// <summary>입력 값과 비교하여 큰 값을 가져옴</summary>
        /// <param name="a">입력 값</param>
        /// <returns>입력 값과 비교하여 큰 값</returns>
        public abstract Number<T> Max(Number<T> a);

        /// <summary>지정한 개체와 현재 개체가 같은지 여부를 확인합니다.</summary>
        /// <returns>지정한 개체가 현재 개체와 같으면 true이고, 그렇지 않으면 false입니다.</returns>
        /// <param name="other">현재 개체와 비교할 개체입니다. </param>
        /// <filterpriority>2</filterpriority>
        protected bool Equals(Number<T> other)
        {
            return this == other;
        }

        /// <summary>값을 합함</summary>
        /// <param name="a">입력 값</param>
        /// <returns>합한 결과 값</returns>
        protected abstract Number<T> Sum(Number<T> a);

        /// <summary>값을 뺌</summary>
        /// <param name="a">입력 값</param>
        /// <returns>뺀 결과 값</returns>
        protected abstract Number<T> Subtract(Number<T> a);

        /// <summary>값을 곱함</summary>
        /// <param name="a">입력 값</param>
        /// <returns>곱한 결과 값</returns>
        protected abstract Number<T> Multiply(Number<T> a);

        /// <summary>값을 나눔</summary>
        /// <param name="a">입력 값</param>
        /// <returns>나눈 결과 값</returns>
        protected abstract Number<T> Subdivision(Number<T> a);
    }

    public static class NumericHelper
    {
        public static Number<T> Sum<T>(this IEnumerable<Number<T>> values)
            where T : IComparable, IConvertible
        {
            return Number<T>.Sum(values);
        }
    }
}