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
    /// <summary>사각형 정보 관리 인터페이스</summary>
    /// <typeparam name="T">사각형의 위치, 크기에 대한 자료형</typeparam>
    public interface IRectangle<T>
    {
        /// <summary>시작 X 위치</summary>
        T StartX { get; set; }

        /// <summary>시작 Y 위치</summary>
        T StartY { get; set; }

        /// <summary>끝 X 위치</summary>
        T EndX { get; set; }

        /// <summary>끝 Y 위치</summary>
        T EndY { get; set; }

        /// <summary>가로 크기</summary>
        T Width { get; }

        /// <summary>세로 크기</summary>
        T Height { get; }
    }
}