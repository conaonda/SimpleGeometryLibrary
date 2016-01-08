// --------------------------------------------------------------------------------------------------------------------
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
    using SimpleGeometryLibrary.Numeric;

    /// <summary>직사각형 정보 관리 클래스</summary>
    /// <typeparam name="T"></typeparam>
    internal class Rectangle<T> : IRectangle<T>
    {
        /// <summary>최대 위치</summary>
        private readonly Point2<T> max;

        /// <summary>최소 위치</summary>
        private readonly Point2<T> min;

        /// <summary>기본 생성자</summary>
        public Rectangle()
        {
            this.min = new Point2<T>(Number<T>.MaxValue, Number<T>.MaxValue);
            this.max = new Point2<T>(Number<T>.MinValue, Number<T>.MinValue);
        }

        /// <summary>두 개의 위치로부터 객체를 생성</summary>
        /// <param name="pt1">첫 번째 위치</param>
        /// <param name="pt2">두 번째 위치</param>
        public Rectangle(Point2<T> pt1, Point2<T> pt2)
            : this(pt1.X, pt1.Y, pt2.X, pt2.Y)
        {
        }

        /// <summary>두 개의 위치로부터 객체를 생성</summary>
        /// <param name="x1">첫 번째 X 값</param>
        /// <param name="y1">첫 번째 Y 값</param>
        /// <param name="x2">두 번째 X 값</param>
        /// <param name="y2">두 번째 Y 값</param>
        public Rectangle(T x1, T y1, T x2, T y2)
            :this()
        {
            this.FromPoints(x1, y1, x2, y2);
        }

        /// <summary>시작 위치</summary>
        public Point2<T> Min
        {
            get { return this.min; }
            set { this.FromPoints(value.X, value.Y, this.max.X, this.max.Y); }
        }

        /// <summary>끝 위치</summary>
        public Point2<T> Max
        {
            get { return this.max; }
            set { this.FromPoints(value.X, value.Y, this.min.X, this.min.Y); }
        }

        /// <summary>가로 크기</summary>
        public T Width => (Number<T>)this.max.X - this.min.X;

        /// <summary>세로 크기</summary>
        public T Height => (Number<T>)this.max.Y - this.min.Y;

        /// <summary>위치를 설정</summary>
        /// <param name="x1">첫 번째 X 값</param>
        /// <param name="y1">첫 번째 Y 값</param>
        /// <param name="x2">두 번째 X 값</param>
        /// <param name="y2">두 번째 Y 값</param>
        private void FromPoints(T x1, T y1, T x2, T y2)
        {
            this.min.X = ((Number<T>)x1).Min(x2);
            this.max.X = ((Number<T>)x1).Max(x2);

            this.min.Y = ((Number<T>)y1).Min(y2);
            this.max.Y = ((Number<T>)y1).Max(y2);
        }
    }
}