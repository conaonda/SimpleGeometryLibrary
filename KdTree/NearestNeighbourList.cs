using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleGeometryLibrary.KdTree
{
	public interface INearestNeighbourList<TItem, TDistance> where TDistance : IComparable, IConvertible
    {
		bool Add(TItem item, TDistance distance);
		TItem GetFurtherest();
		TItem RemoveFurtherest();

		int MaxCapacity { get; }
		int Count { get; }
	}

	public class NearestNeighbourList<TItem, TDistance> : INearestNeighbourList<TItem, TDistance> where TDistance : IComparable, IConvertible
    {
		public NearestNeighbourList(int maxCapacity)
		{
			this.maxCapacity = maxCapacity;
		    this.queue = new PriorityQueue<TItem, TDistance>(maxCapacity);
		}

		private PriorityQueue<TItem, TDistance> queue;

		private int maxCapacity;
		public int MaxCapacity { get { return maxCapacity; } }

		public int Count { get { return queue.Count; } }

		public bool Add(TItem item, TDistance distance)
		{
			if (queue.Count >= maxCapacity)
			{
				// If the distance of this item is less than the distance of the last item
				// in our neighbour list then pop that neighbour off and push this one on
				// otherwise don't even bother adding this item
				if (distance.CompareTo(queue.GetHighestPriority()) < 0)
				{
					queue.Dequeue();
					queue.Enqueue(item, distance);
					return true;
				}
				else
					return false;
			}
			else
			{
				queue.Enqueue(item, distance);
				return true;
			}
		}

		public TItem GetFurtherest()
		{
			if (Count == 0)
				throw new Exception("List is empty");
			else
				return queue.GetHighest();
		}

		public TDistance GetFurtherestDistance()
		{
			if (Count == 0)
				throw new Exception("List is empty");
			else
				return queue.GetHighestPriority();
		}

		public TItem RemoveFurtherest()
		{
			return queue.Dequeue();
		}

		public bool IsCapacityReached
		{
			get { return Count == MaxCapacity; }
		}
	}
}
