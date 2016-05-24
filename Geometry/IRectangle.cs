// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="IRectangle.cs" company="Conaonda">
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
//    IRectangle.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------

namespace SimpleGeometryLibrary.Geometry
{
    using System;
    using Numeric;

    /// <summary>사각형 정보 관리 인터페이스</summary>
    /// <typeparam name="T">사각형의 위치, 크기에 대한 자료형</typeparam>
    public interface IRectangle<T> : IGeometry<T> where T : IComparable, IConvertible
    {
        /// <summary>시작 위치</summary>
        Point2<T> Start { get; set; }

        /// <summary>끝 위치</summary>
        Point2<T> End { get; set; }

        /// <summary>가로 크기</summary>
        T Width { get; set; }

        /// <summary>세로 크기</summary>
        T Height { get; set; }

        /// <summary>
        /// 시작 X 위치
        /// </summary>
        T X { get; set; }

        /// <summary>
        /// 시작 Y 위치
        /// </summary>
        T Y { get; set; }

        /// <summary>
        /// 끝 X 위치
        /// </summary>
        T EndX { get; set; }

        /// <summary>
        /// 끝 Y 위치
        /// </summary>
        T EndY { get; set; } 

        /// <summary>
        /// 입력하는 위치가 영역에 포함되는지 확인
        /// </summary>
        /// <param name="pt">입력 위치</param>
        /// <returns>포함 여부</returns>
        bool IsIn(Point2<T> pt);

        /// <summary>
        /// 입력하는 직사각형과 겹치는지 확인
        /// </summary>
        /// <param name="other">입력 직사각형</param>
        /// <returns>겹침 여부</returns>
        bool Intersects(IRectangle<T> other);

        /// <summary>
        /// 입력하는 직사각형을 포함하는지 확인
        /// </summary>
        /// <param name="other">입력 직사각형</param>
        /// <returns>포함 여부</returns>
        bool Contains(IRectangle<T> other);

        /// <summary>
        /// 객체를 복사
        /// </summary>
        /// <returns>복사한 객체</returns>
        IRectangle<T> Clone();

        /// <summary>
        /// 면적 값을 가져옴
        /// </summary>
        /// <returns>면적 값</returns>
        T Area();
    }
}