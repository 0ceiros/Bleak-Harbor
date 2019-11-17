using UnityEditor;
using UnityEngine;

namespace BleakHarbor.Core
{
    public enum Fraction
    {
        Player,
        Goberment
    }
    /// <summary>
    /// Сущность, относящаяся к какой-либо фракции.
    /// </summary>
    /// <remarks>
    /// Класс нужен, чтобы враги понимали что они враги а не друзья.
    /// Допускаю, что введение понятия "фракция" сейчас - избыточно, но
    /// таким образом у нас точно не возникнет ограничений. 
    /// </remarks>
    public abstract class EntityWithFraction : EntityBase
    {
        [SerializeField]
        private Fraction fraction;
        public Fraction Fraction { get => fraction; private set => fraction = value; }
    }
}
