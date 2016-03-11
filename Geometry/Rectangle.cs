﻿// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Rectangle.cs" company="Conaonda">
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
//    Rectangle.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------

namespace SimpleGeometryLibrary.Geometry
{
    using System;
    using Numeric;

    /// <summary>직사각형 정보 관리 클래스</summary>
    /// <typeparam name="T"></typeparam>
    internal class Rectangle<T> : IRectangle<T> where T : IComparable, IConvertible
    {
        /// <summary>최대 위치</summary>
        private readonly Point2<T> end;

        /// <summary>최소 위치</summary>
        private readonly Point2<T> start;

        /// <summary>기본 생성자</summary>
        public Rectangle()
        {
            this.start = new Point2<T>(Number<T>.MaxValue, Number<T>.MaxValue);
            this.end = new Point2<T>(Number<T>.MinValue, Number<T>.MinValue);
        }

        /// <summary>두 개의 위치로부터 객체를 생성</summary>
        /// <param name="pt1">첫 번째 위치</param>
        /// <param name="pt2">두 번째 위치</param>
        public Rectangle(Point2<T> pt1, Point2<T> pt2)
            : this(pt1.X, pt1.Y, pt2.X, pt2.Y)
        {
        }

        public Rectangle(Point2<T> start, Vector2<T> size):this(start, start + size)
        {
        }

        /// <summary>두 개의 위치로부터 객체를 생성</summary>
        /// <param name="x1">첫 번째 X 값</param>
        /// <param name="y1">첫 번째 Y 값</param>
        /// <param name="x2">두 번째 X 값</param>
        /// <param name="y2">두 번째 Y 값</param>
        public Rectangle(Number<T> x1, Number<T> y1, Number<T> x2, Number<T> y2)
            :this()
        {
            this.FromPoints(x1, y1, x2, y2);
        }

        /// <summary>시작 위치</summary>
        public Point2<T> Start
        {
            get { return this.start; }
            set { this.FromPoints(value.X, value.Y, this.EndX, this.EndY); }
        }

        /// <summary>끝 위치</summary>
        public Point2<T> End
        {
            get { return this.end; }
            set { this.FromPoints(this.X, this.Y, value.X, value.Y); }
        }

        /// <summary>가로 크기</summary>
        public Number<T> Width
        {
            get { return this.EndX - this.X; }
            set { this.EndX = this.X + value; }
        }

        /// <summary>세로 크기</summary>
        public Number<T> Height
        {
            get { return this.EndY - this.Y; }
            set { this.EndY = this.Y + value; }
        }

        public Number<T> X
        {
            get { return this.start.X; }
            set { this.start.X = value; }
        }

        public Number<T> Y
        {
            get { return this.start.Y; }
            set { this.start.Y = value; }
        }

        public Number<T> EndX
        {
            get { return this.end.X; }
            set { this.end.X = value; }
        }

        public Number<T> EndY
        {
            get { return this.end.Y; }
            set { this.end.Y = value; }
        }

        /// <summary>
        /// 입력하는 위치가 영역에 포함되는지 확인
        /// </summary>
        /// <param name="pt">입력 위치</param>
        /// <returns>포함 여부</returns>
        public bool IsIn(Point2<T> pt)
        {
            return pt.X >= this.start.X && pt.Y >= this.start.Y &&
                   this.end.X >= pt.X && this.end.Y >= pt.Y;
        }

        /// <summary>
        /// 입력하는 직사각형과 겹치는지 확인
        /// </summary>
        /// <param name="other">입력 직사각형</param>
        /// <returns>겹침 여부</returns>
        public bool IsIntersects(IRectangle<T> other)
        {
            return other.End.X >= this.start.X && this.end.X >= other.Start.X &&
                   other.End.Y >= this.start.Y && this.end.Y >= other.Start.Y;
        }

        /// <summary>위치를 설정</summary>
        /// <param name="x1">첫 번째 X 값</param>
        /// <param name="y1">첫 번째 Y 값</param>
        /// <param name="x2">두 번째 X 값</param>
        /// <param name="y2">두 번째 Y 값</param>
        private void FromPoints(Number<T> x1, Number<T> y1, Number<T> x2, Number<T> y2)
        {
            this.start.X = x1.Min(x2);
            this.end.X = x1.Max(x2);

            this.start.Y = y1.Min(y2);
            this.end.Y = y1.Max(y2);
        }
    }
}