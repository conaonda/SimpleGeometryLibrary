namespace SimpleGeometryLibrary.Geometry
{
    /// <summary>
    /// 3���� ���� Ŭ����
    /// </summary>
    /// <typeparam name="T">�� ����</typeparam>
    public class Point3<T> : Point2<T>
    {
        /// <summary>
        /// �⺻ ������
        /// </summary>
        public Point3()
            : base(3)
        {
        }

        /// <summary>
        /// X, Y, Z ���� �Է��Ͽ� ��ü�� ����
        /// </summary>
        /// <param name="x">X ��</param>
        /// <param name="y">Y ��</param>
        /// <param name="z">Z ��</param>
        public Point3(T x, T y, T z)
            : base(3, x, y)
        {
            this.Factor[2] = z;
        }

        /// <summary>
        /// Z ���� ������
        /// </summary>
        public T Z => this.Factor[2];

        public new Point3<T> Clone() => new Point3<T>(this.X, this.Y, this.Z);
    }
}