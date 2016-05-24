using System;
using System.Collections.Generic;
using System.Linq;
using SimpleGeometryLibrary.Numeric;

namespace SimpleGeometryLibrary.Geometry
{
    public class Vector<T> where T : IComparable, IConvertible
    {
        /// <summary>값 목록</summary>
        protected readonly T[] Values;

        /// <summary>벡터의 크기를 입력하여 객체를 생성</summary>
        /// <param name="size">벡터의 크기</param>
        public Vector(byte size)
        {
            this.Size = size;
            this.Values = new T[this.Size];
        }

        /// <summary>값 목록을 입력하여 객체를 생성</summary>
        /// <param name="values">값 목록</param>
        public Vector(IEnumerable<T> values)
            : this((byte) values.Count())
        {
            for (byte i = 0; i < this.Size; i++)
            {
                this[i] = values.ElementAt(i);
            }
        }

        /// <summary>벡터의 크기를 가져옴</summary>
        public int Size { get; }

        /// <summary>
        /// 암시적으로 벡터를 배열로 변환
        /// </summary>
        /// <param name="a">벡터 객체</param>
        public static implicit operator T[](Vector<T> a)
        {
            return a.Values;
        }

        /// <summary>
        /// 암시적으로 배열을 벡터로 변환
        /// </summary>
        /// <param name="a">배열 객체</param>
        public static implicit operator Vector<T>(T[] a)
        {
            return new Vector<T>(a);
        }

        /// <summary>벡터에 스칼라 값을 더함</summary>
        /// <param name="a">입력 벡터</param>
        /// <param name="b">스칼라 값</param>
        /// <returns>더한 벡터</returns>
        public static T[] operator +(Vector<T> a, T b)
        {
            return a.Values.Select(v => (Number<T>)v + b).ToArray();
        }

        /// <summary>스칼라 값에 벡터를 더함</summary>
        /// <param name="a">스칼라 값</param>
        /// <param name="b"></param>
        /// <returns>더한 벡터</returns>
        public static T[] operator +(T a, Vector<T> b)
        {
            return b + a;
        }

        /// <summary>
        /// 두 벡터를 더함
        /// </summary>
        /// <param name="a">첫 번째 벡터</param>
        /// <param name="b">두 번째 벡터</param>
        /// <returns>더한 벡터</returns>
        /// <exception cref="VectorDimensionNotAgreeException{T}">두 벡터의 크기가 다름</exception>
        public static T[] operator +(Vector<T> a, Vector<T> b)
        {
            if (a.Size != b.Size)
            {
                throw new VectorDimensionNotAgreeException<T>(a, b);
            }

            return a.Values.Zip(b.Values, (v1, v2) => (Number<T>)v1 + v2).ToArray();
        }

        /// <summary>벡터에 스칼라 값을 뺌</summary>
        /// <param name="a">입력 벡터</param>
        /// <param name="b">스칼라 값</param>
        /// <returns>뺀 벡터</returns>
        public static T[] operator -(Vector<T> a, T b)
        {
            return a.Values.Select(v => (Number<T>)v - b).ToArray();
        }

        /// <summary>스칼라 값에 벡터를 뺌</summary>
        /// <param name="a">스칼라 값</param>
        /// <param name="b"></param>
        /// <returns>뺀 벡터 </returns>
        public static T[] operator -(T a, Vector<T> b)
        {
            return b.Values.Select(v => (Number<T>)a - v).ToArray();
        }

        /// <summary>
        /// 두 벡터를 뺌
        /// </summary>
        /// <param name="a">첫 번째 벡터</param>
        /// <param name="b">두 번째 벡터</param>
        /// <returns>뺀 벡터</returns>
        /// <exception cref="VectorDimensionNotAgreeException{T}">두 벡터의 크기가 다름</exception>
        public static T[] operator -(Vector<T> a, Vector<T> b)
        {
            if (a.Size != b.Size)
            {
                throw new VectorDimensionNotAgreeException<T>(a, b);
            }

            return a.Values.Zip(b.Values, (v1, v2) => (Number<T>)v1 - v2).ToArray();
        }

        /// <summary>벡터에 스칼라 값을 곱함</summary>
        /// <param name="a">입력 벡터</param>
        /// <param name="b">스칼라 값</param>
        /// <returns>곱한 벡터</returns>
        public static T[] operator *(Vector<T> a, T b)
        {
            return a.Values.Select(v => (Number<T>)v * b).ToArray();
        }

        /// <summary>스칼라 값에 벡터를 곱함</summary>
        /// <param name="a">스칼라 값</param>
        /// <param name="b">입력 벡터</param>
        /// <returns>곱한 벡터</returns>
        public static T[] operator *(T a, Vector<T> b)
        {
            return b * a;
        }

        /// <summary>벡터에 스칼라 값을 나눔</summary>
        /// <param name="a">입력 벡터</param>
        /// <param name="b">스칼라 값</param>
        /// <returns>나눈 벡터</returns>
        public static T[] operator /(Vector<T> a, T b)
        {
            return a.Values.Select(v => (Number<T>)v / b).ToArray();
        }

        /// <summary>객체를 복사</summary>
        /// <returns>생성된 객체</returns>
        public Vector<T> Clone() => new Vector<T>(this.Values);

        /// <summary>
        /// 벡터의 노름(Norm)를 계산함
        /// </summary>
        /// <returns>벡터의 노름(Norm)</returns>
        public Number<T> Norm()
        {
            return this.Values.Aggregate((Number<T>)default(T), (current, v) => current + (Number<T>)v*v).Sqrt();
        }

        /// <summary>
        /// 단위 벡터를 가져옴
        /// </summary>
        /// <returns>단위 벡터</returns>
        public Vector<T> Normalize()
        {
            var size = this.Norm();
            return new Vector<T>(this.Values.Select(v => v / size));
        }

        /// <summary>
        /// 벡터곱(내적)을 수행
        /// </summary>
        /// <param name="a">첫 번째 벡터</param>
        /// <param name="b">두 번째 벡터</param>
        /// <returns>내적 값</returns>
        public static T DotProduct(Vector<T> a, Vector<T> b)
        {
            return a.Values.Zip(b.Values, (va, vb) => (Number<T>)((Number<T>)va * vb)).Sum();
        }

        /// <summary>
        /// 벡터곱(내적)을 수행
        /// </summary>
        /// <param name="a">입력 벡터</param>
        /// <returns>내적 값</returns>
        public T DotProduct(Vector<T> a)
        {
            return DotProduct(this, a);
        }

        /// <summary>i번째 값을 가져옴</summary>
        /// <param name="i">값 인덱스</param>
        /// <returns>i번째 값</returns>
        public T this[byte i]
        {
            get { return this.Values[i]; }
            set { this.Values[i] = value; }
        }
    }

    /// <summary>
    /// 벡터의 크기가 다름을 나타나는 오류
    /// </summary>
    /// <typeparam name="T">값의 유형</typeparam>
    public class VectorDimensionNotAgreeException<T> : Exception where T : IComparable, IConvertible
    {
        /// <summary>
        /// 두 벡터 객체를 입력하여 객체를 생성
        /// </summary>
        /// <param name="a">첫 번째 벡터 객체</param>
        /// <param name="b">두 번째 벡터 객체</param>
        public VectorDimensionNotAgreeException(Vector<T> a, Vector<T> b)
        {
            this.Message = $"두 벡터의 크기는 서로 같아야 합니다. {a.Size} != {b.Size}";
        }

        /// <summary>
        /// 현재 예외를 설명하는 메시지를 가져옵니다.
        /// </summary>
        /// <returns>
        /// 예외의 원인을 설명하는 오류 메시지 또는 빈 문자열("").입니다.
        /// </returns>
        /// <filterpriority>1</filterpriority>
        public override string Message { get; }
    }
}
