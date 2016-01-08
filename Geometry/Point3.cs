namespace SimpleGeometryLibrary.Geometry
{
    /// <summary>
    /// 3차원 벡터 클래스
    /// </summary>
    /// <typeparam name="T">값 유형</typeparam>
    public class Point3<T> : Point2<T>
    {
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public Point3()
            : base(3)
        {
        }

        /// <summary>
        /// X, Y, Z 값을 입력하여 객체를 생성
        /// </summary>
        /// <param name="x">X 값</param>
        /// <param name="y">Y 값</param>
        /// <param name="z">Z 값</param>
        public Point3(T x, T y, T z)
            : base(3, x, y)
        {
            this.Factor[2] = z;
        }

        /// <summary>
        /// Z 값을 가져옴
        /// </summary>
        public T Z => this.Factor[2];

        public new Point3<T> Clone() => new Point3<T>(this.X, this.Y, this.Z);
    }
}