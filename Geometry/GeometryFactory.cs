// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="GeometryFactory.cs" company="Conaonda">
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
//    GeometryFactory.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------

using System;
using SimpleGeometryLibrary.Numeric;

namespace SimpleGeometryLibrary.Geometry
{
    /// <summary>도형 생성기</summary>
    /// <typeparam name="T">값의 유형</typeparam>
    public class GeometryFactory<T> where T : IComparable, IConvertible
    {
        /// <summary>
        /// 기본 직사각형을 생성
        /// </summary>
        /// <returns>기본 직사각형</returns>
        public static IRectangle<T> CreateRectangle()
        {
            return new Rectangle<T>();
        } 

        /// <summary>직사각형을 생성</summary>
        /// <param name="startx">시작 X 좌표</param>
        /// <param name="starty">시작 Y 좌표</param>
        /// <param name="endx">끝 X 좌표</param>
        /// <param name="endy">끝 Y 좌표</param>
        /// <returns>직사각형 인터페이스</returns>
        public static IRectangle<T> CreateRectangle(Number<T> startx, Number<T> starty, Number<T> endx, Number<T> endy)
        {
            return new Rectangle<T>(startx, starty, endx, endy);
        }

        /// <summary>직사각형을 생성</summary>
        /// <param name="start">시작 좌표</param>
        /// <param name="end">끝 좌표</param>
        /// <returns>직사각형 인터페이스</returns>
        public static IRectangle<T> CreateRectangle(Point2<T> start, Point2<T> end)
        {
            return new Rectangle<T>(start.X, start.Y, end.X, end.Y);
        }

        /// <summary>직사각형을 생성</summary>
        /// <param name="start">시작 좌표</param>
        /// <param name="size">직사각형 크기</param>
        /// <returns>직사각형 인터페이스</returns>
        public static IRectangle<T> CreateRectangle(Point2<T> start, Vector2<T> size)
        {
            return new Rectangle<T>(start, start+size);
        }

        /// <summary>영역 정보 관리 객체를 생성</summary>
        /// <returns>영역 정보 관리 객체</returns>
        public static IEnvelope<T> CreatEnvelope()
        {
            return new Envelope<T>();
        }
    }
}