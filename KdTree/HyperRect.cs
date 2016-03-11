using System;
using SimpleGeometryLibrary.Numeric;

namespace SimpleGeometryLibrary.KdTree
{
	public struct HyperRect<T> where T : IComparable, IConvertible
    {
		private T[] minPoint;
		public T[] MinPoint
		{
			get
			{
				return minPoint;
			}
			set
			{
				minPoint = new T[value.Length];
				value.CopyTo(minPoint, 0);
			}
		}

		private T[] maxPoint;
		public T[] MaxPoint
		{
			get
			{
				return maxPoint;
			}
			set
			{
				maxPoint = new T[value.Length];
				value.CopyTo(maxPoint, 0);
			}
		}

		public static HyperRect<T> Infinite(int dimensions)
        {
			var rect = new HyperRect<T>();

			rect.MinPoint = new T[dimensions];
			rect.MaxPoint = new T[dimensions];

			for (var dimension = 0; dimension < dimensions; dimension++)
			{
				rect.MinPoint[dimension] = Number<T>.MinValue;
				rect.MaxPoint[dimension] = Number<T>.MaxValue;
			}

			return rect;
		}

		public T[] GetClosestPoint(T[] toPoint)
		{
			T[] closest = new T[toPoint.Length];

			for (var dimension = 0; dimension < toPoint.Length; dimension++)
			{
				if (this.minPoint[dimension].CompareTo(toPoint[dimension]) > 0)
				{
					closest[dimension] = this.minPoint[dimension];
				}
				else if (this.maxPoint[dimension].CompareTo(toPoint[dimension]) < 0)
				{
					closest[dimension] = this.maxPoint[dimension];
				}
				else
					// Point is within rectangle, at least on this dimension
					closest[dimension] = toPoint[dimension];
			}

			return closest;
		}

		public HyperRect<T> Clone()
		{
		    var rect = new HyperRect<T>
		    {
		        MinPoint = this.MinPoint,
		        MaxPoint = this.MaxPoint
		    };

		    return rect;
		}
	}
}
