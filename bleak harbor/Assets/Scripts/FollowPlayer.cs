using UnityEngine;

namespace BleakHarbor
{
    public class FollowPlayer : MonoBehaviour
    {
        public GameObject player;
        private Vector3 offset;
        public float smoothFactor = 0.1f;

        // Start is called before the first frame update
        void Start()
        {
            transform.LookAt(player.transform.position);
            offset = transform.position - player.transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 newPos = player.transform.position + offset;
            transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);
        }
    }
}
