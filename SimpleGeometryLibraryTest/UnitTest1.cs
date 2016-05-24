using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleGeometryLibrary.Geometry;
using SimpleGeometryLibrary.KdTree;

namespace SimpleGeometryLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EnvelopeTest()
        {
            var env = GeometryFactory<int>.CreatEnvelope();
            var rect1 = GeometryFactory<int>.CreateRectangle(1, -20, 40, -10);
            var rect2 = GeometryFactory<int>.CreateRectangle(-20, -10, 10, 0);

            env.Expand(rect1);
            env.Expand(rect2);

            Assert.AreEqual(env.Start.X, -20);
            Assert.AreEqual(env.Start.Y, -20);

            Assert.AreEqual(env.End.X, 40);
            Assert.AreEqual(env.End.Y, 0);
        }

        class Point
        {
            public Point(string name, double[] xyz)
            {
                this.Name = name;
                this.XYZ = xyz;
            }

            public string Name { get; }

            public double[] XYZ { get; }
        }

        [TestMethod]
        public void KdTreeTest()
        {
            var lines = File.ReadLines("../../xyz.csv", Encoding.GetEncoding("euc-kr"));
            Assert.IsTrue(lines.Any());

            var tree = new KdTree<double,Point>(3);
            var points = new List<Point>();
            foreach (var line in lines)
            {
                var values = line.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
                var xyz = values.Skip(1).Select(Convert.ToDouble).ToArray();
                var point = new Point(values[0], xyz);
                points.Add(point);
                tree.Add(xyz, point);
            }

            var ret = tree.GetNearestNeighbours(points[12].XYZ, 2);
            Assert.IsTrue(ret.Any());

            var retNames = ret.Select(a => a.Value.Name).ToArray();
            foreach (var retName in retNames)
            {
                Console.WriteLine(retName);
            }

            Assert.AreEqual("나", retNames[1]);
        }
    }
}
