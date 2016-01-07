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
//    IntNumber.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
namespace SimpleGeometryLibrary.Numeric
{
    using System;

    /// <summary>
    /// 정수형 숫자 클래스
    /// </summary>
    public class IntNumber : Number<int>
    {
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public IntNumber()
            : base(default(int))
        {
        }

        /// <summary>
        /// 정수 값을 입력하여 객체를 생성
        /// </summary>
        /// <param name="v">정수 값</param>
        public IntNumber(int v)
            : base(v)
        {
        }

        /// <summary>
        /// 암시적으로 정수 값을 정수 숫자 객체로 변환
        /// </summary>
        /// <param name="v">정수 값</param>
        public static implicit operator IntNumber(int v) => new IntNumber(v);

        /// <summary>값을 합함</summary>
        /// <param name="a">입력 값</param>
        /// <returns>합한 결과 값</returns>
        protected override Number<int> Sum(int a) => this + a;

        /// <summary>값을 뺌</summary>
        /// <param name="a">입력 값</param>
        /// <returns>뺀 결과 값</returns>
        protected override Number<int> Subtract(int a) => this - a;

        /// <summary>값을 곱함</summary>
        /// <param name="a">입력 값</param>
        /// <returns>곱한 결과 값</returns>
        protected override Number<int> Multiply(int a) => this * a;

        /// <summary>값을 나눔</summary>
        /// <param name="a">입력 값</param>
        /// <returns>나눈 결과 값</returns>
        protected override double Subdivision(int a) => this / a;

        /// <summary>제곱근을 계산</summary>
        /// <returns>계산된 제곱근</returns>
        public override double Sqrt() => Math.Sqrt(this);

        /// <summary>입력 값과 비교하여 작은 값을 가져옴</summary>
        /// <param name="a">입력 값</param>
        /// <returns>입력 값과 비교하여 작은 값</returns>
        public override int Min(int a) => Math.Min(this, a);

        /// <summary>입력 값과 비교하여 큰 값을 가져옴</summary>
        /// <param name="a">입력 값</param>
        /// <returns>입력 값과 비교하여 큰 값</returns>
        public override int Max(int a) => Math.Max(this, a);
    }
}