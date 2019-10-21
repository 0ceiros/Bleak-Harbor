using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace BleakHarbor.Assets.Scripts.AI
{
    class TargetFollower : Core.EntityBase
    {
        /// <summary>
        /// Цель, за которой нужно следить.
        /// </summary>
        public Transform target;
        public override Func<Vector2> DirectionFactory => GetDirection;

        private Vector2 GetDirection()
        {
            var direction = new Vector2(target.position.x, target.position.y) - this.Position;
            direction = Vector2.ClampMagnitude(direction, 1);
            return direction;
        }
    }
}
