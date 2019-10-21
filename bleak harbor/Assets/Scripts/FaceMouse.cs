using UnityEngine;

namespace BleakHarbor
{
    public class FaceMouse : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D playerBody;
        private Vector3 mousePos;

        // Start is called before the first frame update
        void Start()
        {
            playerBody = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float targetAngle = Mathf.Atan2(x: transform.position.x - mousePos.x,
                                            y: transform.position.y - mousePos.y) * Mathf.Rad2Deg + 90f;
            playerBody.rotation = targetAngle;
        }
    }
}
