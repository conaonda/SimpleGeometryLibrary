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
    using Numeric;

    internal class Rectangle<T> : IRectangle<T>
    {
        public Rectangle(T startx, T starty, T endx, T endy)
        {
            this.StartX = startx;
            this.StartY = starty;
            this.EndX = endx;
            this.EndY = endy;
        }

        public T StartX { get; set; }

        public T StartY { get; set; }

        public T EndX { get; set; }

        public T EndY { get; set; }

        public T Width => (Number<T>)this.EndX - this.StartX;

        public T Height => (Number<T>)this.EndY - this.StartY;
    }
}