// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Envelope.cs" company="Conaonda">
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
//    Envelope.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------
namespace SimpleGeometryLibrary.Geometry
{
    using Numeric;

    /// <summary>사각형 형태 영역 정보 관리 클래스</summary>
    /// <typeparam name="T">값의 유형</typeparam>
    internal class Envelope<T> : Rectangle<T>, IEnvelope<T>
    {
        /// <summary>다른 영역 객체를 포함하도록 영역을 확장</summary>
        /// <param name="other">다른 영역 객체</param>
        public void Expand(IRectangle<T> other)
        {
            this.Min.X = ((Number<T>)this.Min.X).Min(other.Min.X);
            this.Min.Y = ((Number<T>)this.Min.Y).Min(other.Min.Y);

            this.Max.X = ((Number<T>)this.Max.X).Max(other.Max.X);
            this.Max.Y = ((Number<T>)this.Max.Y).Max(other.Max.Y);
        }
    }
}