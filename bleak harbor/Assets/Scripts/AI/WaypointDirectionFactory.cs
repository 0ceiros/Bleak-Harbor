using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static BleakHarbor.Core.Utils;

namespace BleakHarbor.AI
{
    internal class WaypointDirectionFactory
    {
        private Waypoint currentTarget;

        /// <summary>
        /// Точка, из в которой начинается движение.
        /// </summary>
        public Waypoint Start { get => start; }
        private Waypoint start;

        public Vector2 Position { get => positionFunc(); }
        Func<Vector2> positionFunc;

        public WaypointDirectionFactory(Waypoint start, Func<Vector2> position)
        {
            this.start = start;
            positionFunc = position;
            currentTarget = Start;
        }

        public Vector2 GetDirection()
        {
            if(Near(Position, currentTarget.Position))
            {
                currentTarget = currentTarget.Next;
            }
            return Vector2.ClampMagnitude(currentTarget.Position - Position, 1);
        }
    }
}
