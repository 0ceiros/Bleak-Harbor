using UnityEngine;
using UnityEngine.UI;

namespace BleakHarbor
{
    public class PlayerControllerAddForce : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D playerBody;
        [SerializeField]
        private Text pickUpText;
        public float speed;
        private Vector2 movement;

        // Start is called before the first frame update
        void Start()
        {
            pickUpText.gameObject.SetActive(false);
            playerBody = GetComponent<Rigidbody2D>();
            speed = 600000f;
        }

        // Шаг обновления физики
        void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            movement = new Vector2(moveHorizontal, moveVertical) * speed * Time.deltaTime;
            playerBody.AddForce(movement, ForceMode2D.Force);
        }
    }
}