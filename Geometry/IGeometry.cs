using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeometryLibrary.Geometry
{
    /// <summary>
    /// 지오메트리 인터페이스
    /// </summary>
    /// <typeparam name="T">지오메트리의 자료형</typeparam>
    public interface IGeometry<T> where T : IComparable, IConvertible
    {
        /// <summary>
        /// 입력하는 지오메트리와 겹치는지 확인
        /// </summary>
        /// <param name="other">입력 지오메트리</param>
        /// <returns>겹침 여부</returns>
        ////bool Intersects(IGeometry<T> other);

        /// <summary>
        /// 객체를 복사
        /// </summary>
        /// <returns>복사한 객체</returns>
        ////IGeometry<T> Clone();
    }
}
