using System;
using System.Collections.Generic;
using System.Linq;
using SimpleGeometryLibrary.Numeric;

namespace SimpleGeometryLibrary.Geometry
{
    /// <summary>
    /// 3차원 벡터 클래스
    /// </summary>
    /// <typeparam name="T">값 유형</typeparam>
    public class Point3<T> : Vector3<T> where T : IComparable, IConvertible
    {
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public Point3()
        {
        }

        /// <summary>
        /// X, Y, Z 값을 입력하여 객체를 생성
        /// </summary>
        /// <param name="x">X 값</param>
        /// <param name="y">Y 값</param>
        /// <param name="z">Z 값</param>
        public Point3(Number<T> x, Number<T> y, Number<T> z)
            : base(x, y, z)
        {
        }

        /// <summary>X 값을 가져옴</summary>
        public Number<T> X
        {
            get { return this[0]; }
            set { this[0] = value; }
        }

        /// <summary>Y 값을 가져옴</summary>
        public Number<T> Y
        {
            get { return this[1]; }
            set { this[1] = value; }
        }

        /// <summary>
        /// Z 값을 가져옴
        /// </summary>
        public Number<T> Z
        {
            get { return this[2]; }
            set { this[2] = value; }
        }

        /// <summary>
        /// 배열 객체를 암묵적으로 Vector2 객체로 변환
        /// </summary>
        /// <param name="a">배열 객체</param>
        public static explicit operator Point3<T>(Number<T>[] a)
        {
            return new Point3<T>(a[0], a[1], a[2]);
        }
    }
}