// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="IEnvelope.cs" company="Conaonda">
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
//    IEnvelope.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------

namespace SimpleGeometryLibrary.Geometry
{
    using System;

    /// <summary>사각형 형태 영역 정보 관리 인터페이스</summary>
    /// <typeparam name="T">영역의 위치, 크기에 대한 자료형</typeparam>
    public interface IEnvelope<T> : IRectangle<T> where T : IComparable, IConvertible
    {
        /// <summary>다른 영역 객체를 포함하도록 영역을 확장</summary>
        /// <param name="other">다른 영역 객체</param>
        void Expand(IRectangle<T> other);

        /// <summary>
        /// 입력하는 위치를 포함하도록 영역을 확장
        /// </summary>
        /// <param name="pt">입력 위치</param>
        void Expand(Point2<T> pt);

        /// <summary>
        /// 객체를 복사
        /// </summary>
        /// <returns>복사한 객체</returns>
        IEnvelope<T> Clone();
    }
}