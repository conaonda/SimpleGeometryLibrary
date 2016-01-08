namespace SimpleGeometryLibrary.Geometry
{
    using System;

    /// <summary>2차원 벡터 클래스</summary>
    /// <typeparam name="T">값 유형</typeparam>
    public class Point2<T>
    {
        /// <summary>값 목록</summary>
        protected T[] Factor;


        /// <summary>기본 생성자</summary>
        public Point2()
            : this(2)
        {
        }

        protected delegate void FactorChangedEventHandler();
        protected event FactorChangedEventHandler FactorChanged;

        /// <summary>X, Y 값을 입력하여 객체를 생성</summary>
        /// <param name="x">X 값</param>
        /// <param name="y">Y 값</param>
        public Point2(T x, T y)
            : this(2, x, y)
        {
        }

        protected Point2(byte dimension)
        {
            this.Factor = new T[dimension];
        }

        /// <summary>상속 전용 생성자</summary>
        /// <param name="dimension">차원 수</param>
        /// <param name="x">X 값</param>
        /// <param name="y">Y 값</param>
        protected Point2(byte dimension, T x, T y)
            : this(dimension)
        {
            this.Factor[0] = x;
            this.Factor[1] = y;
        }

        /// <summary>X 값을 가져옴</summary>
        public T X
        {
            get
            {
                return this[0];
            }

            set
            {
                this.Factor[0] = value;
                this.FactorChanged?.Invoke();
            }
        }

        /// <summary>Y 값을 가져옴</summary>
        public T Y
        {
            get
            {
                return this[1];
            }

            set
            {
                this.Factor[1] = value;
                this.FactorChanged?.Invoke();
            }
        }

        /// <summary>i번째 값을 가져옴</summary>
        /// <param name="i">값 인덱스</param>
        /// <returns>i번째 값</returns>
        protected T this[byte i] => this.Factor[i];

        public Point2<T> Clone() => new Point2<T>(this.X, this.Y);
    }
}