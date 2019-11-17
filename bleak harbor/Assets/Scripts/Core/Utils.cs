using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace BleakHarbor.Core
{
    /// <summary>
    /// В классе реализованы популярные общие методы.
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Возвращает истину, если вектор <paramref name="a"/> попадает в 
        /// <paramref name="radius"/> окрестность вокруг вектора <paramref name="b"/>.
        /// </summary>
        /// <param name="radius">Радиус окрестности.</param>
        public static bool Near(Vector2 a, Vector2 b, float radius = 0.5f)
        {
            return (b - a).magnitude < radius;
        }
    }
}
