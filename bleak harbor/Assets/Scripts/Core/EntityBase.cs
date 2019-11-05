using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Accessibility;

namespace BleakHarbor.Core
{
    /// <summary>
    /// Базовый класс для сущностей, которые могут передвигаться.
    /// </summary>
    public abstract class EntityBase : MonoBehaviour
    {
        [SerializeField, Header("Скорость движения"), Tooltip("Можно опираться на число 750, с такой скоростью движется игрок.")]
        private float speed = 750;
        [Tooltip("Рекомендуется оставить пустым, чтобы оно подтянулось скриптом.")]
        [Header("Движущееся тело")]
        [SerializeField]
        private Rigidbody2D body;
        protected virtual float Speed { get => speed; set => speed = value; }
        public abstract Func<Vector2> DirectionFactory { get; }
        public Vector2 Position => body.position;

        /// <summary>
        /// Двигает сущность
        /// </summary>
        /// <param name="direction">Расстояние, на которое сущность должна передвинуться за один кадр.</param>
        protected virtual void Move(Vector2 direction)
        {
            var force = new Vector2(direction.x, direction.y) * Speed * Time.deltaTime;
            body.AddForce(force, ForceMode2D.Force);
        }

        void Start()
        {
            if (body == null)
            {
                body = GetComponent<Rigidbody2D>();
            }
        }
        void Update()
        {
            Move(DirectionFactory());
        }
    }
}
