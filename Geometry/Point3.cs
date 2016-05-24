using System;
using System.Collections.Generic;
using System.Linq;
using SimpleGeometryLibrary.Numeric;

namespace SimpleGeometryLibrary.Geometry
{
    /// <summary>
    /// 3���� ���� Ŭ����
    /// </summary>
    /// <typeparam name="T">�� ����</typeparam>
    public class Point3<T> : Vector3<T> where T : IComparable, IConvertible
    {
        /// <summary>
        /// �⺻ ������
        /// </summary>
        public Point3()
        {
        }

        /// <summary>
        /// X, Y, Z ���� �Է��Ͽ� ��ü�� ����
        /// </summary>
        /// <param name="x">X ��</param>
        /// <param name="y">Y ��</param>
        /// <param name="z">Z ��</param>
        public Point3(T x, T y, T z)
            : base(x, y, z)
        {
        }

        /// <summary>X ���� ������</summary>
        public T X
        {
            get { return this[0]; }
            set { this[0] = value; }
        }

        /// <summary>Y ���� ������</summary>
        public T Y
        {
            get { return this[1]; }
            set { this[1] = value; }
        }

        /// <summary>
        /// Z ���� ������
        /// </summary>
        public T Z
        {
            get { return this[2]; }
            set { this[2] = value; }
        }

        /// <summary>
        /// �迭 ��ü�� �Ϲ������� Vector2 ��ü�� ��ȯ
        /// </summary>
        /// <param name="a">�迭 ��ü</param>
        public static explicit operator Point3<T>(T[] a)
        {
            return new Point3<T>(a[0], a[1], a[2]);
        }
    }
}