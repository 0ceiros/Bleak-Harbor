using System;
using UnityEngine;

namespace BleakHarbor.AI
{
    public class WaypointWalker : Core.EntityWithFraction
    {
        [SerializeField]
        private Waypoint start;

        private WaypointDirectionFactory directionFactory;

        public override Func<Vector2> DirectionFactory => directionFactory.GetDirection;

        public new void Start()
        {
            base.Start();
            directionFactory = new WaypointDirectionFactory(start, () => Position);
        }
    }

}
