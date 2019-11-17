using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static BleakHarbor.Core.Utils;

namespace BleakHarbor.AI
{
    /// <summary>
    /// Представляет точку патрулирования.
    /// Из таких точек собирается маршрут патрулирования.
    /// </summary>
    class Waypoint : MonoBehaviour
    {
        private new Transform transform;

        /// <summary>
        /// Показывает следующую точку патрулирования.
        /// </summary>
        public Waypoint Next { get => next; }
        [SerializeField]
        private Waypoint next;
        

        /// <summary>
        /// Показывает, что на этой точке следует остановиться.
        /// </summary>
        public bool StopHere { get; }
        [SerializeField]
        private bool stopHere;

        

        public Vector2 Position { get => new Vector2(transform.position.x, transform.position.y); }

        public void Start()
        {
            transform = this.GetComponent<Transform>();
        }

        public void Update()
        {
            Debug.DrawLine(Position, Next.Position);
        }
    }
}
