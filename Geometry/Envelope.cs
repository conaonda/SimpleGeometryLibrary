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

using System;

namespace SimpleGeometryLibrary.Geometry
{
    /// <summary>사각형 형태 영역 정보 관리 클래스</summary>
    /// <typeparam name="T">값의 유형</typeparam>
    internal class Envelope<T> : Rectangle<T>, IEnvelope<T> where T : IComparable, IConvertible
    {
        /// <summary>다른 영역 객체를 포함하도록 영역을 확장</summary>
        /// <param name="other">다른 영역 객체</param>
        public void Expand(IRectangle<T> other)
        {
            this.Start.X = this.Start.X.Min(other.Start.X);
            this.Start.Y = this.Start.Y.Min(other.Start.Y);

            this.End.X = this.End.X.Max(other.End.X);
            this.End.Y = this.End.Y.Max(other.End.Y);
        }

        /// <summary>
        /// 입력하는 위치를 포함하도록 영역을 확장
        /// </summary>
        /// <param name="pt">입력 위치</param>
        public void Expand(Point2<T> pt)
        {
            this.Start.X = this.Start.X.Min(pt.X);
            this.Start.Y = this.Start.Y.Min(pt.Y);

            this.End.X = this.End.X.Max(pt.X);
            this.End.Y = this.End.Y.Max(pt.Y);
        }

        /// <summary>
        /// 객체를 복사
        /// </summary>
        /// <returns>복사한 객체</returns>
        public new IEnvelope<T> Clone()
        {
            var ret = new Envelope<T>();
            ret.Expand(this);
            return ret;
        }
    }
}