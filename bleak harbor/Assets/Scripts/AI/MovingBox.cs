using System;
using UnityEngine;

namespace BleakHarbor.AI
{
    public class MovingBox : Core.EntityBase
    {
        public override Func<Vector2> DirectionFactory => GetDirection;
        private Vector2 GetDirection()
        {
            return new Vector2(1f, 0f);
        }
    }
}
