// --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Program.cs" company="Conaonda">
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
//    Program.cs 클래스를 정의합니다.
//  </summary>
//  --------------------------------------------------------------------------------------------------------------------

using System.IO;

namespace Test
{
    using System;

    using SimpleGeometryLibrary.Geometry;

    /// <summary>테스트 클래스</summary>
    public class Program
    {
        public static void EnvelopeTest()
        {
            Console.WriteLine("Start of envelope test.");

            var env = GeometryFactory<int>.CreatEnvelope();
            var rect1 = GeometryFactory<int>.CreateRectangle(1, -20, 40, -10);
            var rect2 = GeometryFactory<int>.CreateRectangle(-20, -10, 10, 0);

            env.Expand(rect1);
            env.Expand(rect2);

            Console.WriteLine("min = {0}, {1}", env.Min.X, env.Min.Y);
            Console.WriteLine("max = {0}, {1}", env.Max.X, env.Max.Y);

            Console.WriteLine("End of envelope test.");
        }

        public static void KdTreeTest()
        {
            Console.WriteLine("Start KdTreeTest.");

            var lines = File.ReadLines("xyz.csv");
            

            Console.WriteLine("End of KdTreeTest.");
        }

        /// <summary>메인 함수</summary>
        /// <param name="args">가변 인자</param>
        public static void Main(string[] args)
        {
            ////EnvelopeTest();
            KdTreeTest();

            Console.Read();
        }
    }
}