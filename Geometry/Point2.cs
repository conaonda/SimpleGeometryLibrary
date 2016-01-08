namespace SimpleGeometryLibrary.Geometry
{
    using System;

    /// <summary>2���� ���� Ŭ����</summary>
    /// <typeparam name="T">�� ����</typeparam>
    public class Point2<T>
    {
        /// <summary>�� ���</summary>
        protected T[] Factor;


        /// <summary>�⺻ ������</summary>
        public Point2()
            : this(2)
        {
        }

        protected delegate void FactorChangedEventHandler();
        protected event FactorChangedEventHandler FactorChanged;

        /// <summary>X, Y ���� �Է��Ͽ� ��ü�� ����</summary>
        /// <param name="x">X ��</param>
        /// <param name="y">Y ��</param>
        public Point2(T x, T y)
            : this(2, x, y)
        {
        }

        protected Point2(byte dimension)
        {
            this.Factor = new T[dimension];
        }

        /// <summary>��� ���� ������</summary>
        /// <param name="dimension">���� ��</param>
        /// <param name="x">X ��</param>
        /// <param name="y">Y ��</param>
        protected Point2(byte dimension, T x, T y)
            : this(dimension)
        {
            this.Factor[0] = x;
            this.Factor[1] = y;
        }

        /// <summary>X ���� ������</summary>
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

        /// <summary>Y ���� ������</summary>
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

        /// <summary>i��° ���� ������</summary>
        /// <param name="i">�� �ε���</param>
        /// <returns>i��° ��</returns>
        protected T this[byte i] => this.Factor[i];

        public Point2<T> Clone() => new Point2<T>(this.X, this.Y);
    }
}