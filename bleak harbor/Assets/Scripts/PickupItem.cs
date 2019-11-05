using UnityEngine;
using UnityEngine.UI;

namespace BleakHarbor
{
    public class PickupItem : MonoBehaviour
    {
        [SerializeField]
        private Text pickupText;
        [SerializeField]
        private string pickupString;
        private bool pickupAllowed;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (pickupAllowed && Input.GetKeyDown(KeyCode.E))
            { PickedUp(); }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.name.Equals("player"))
            {
                pickupText.text = pickupString;
                pickupText.gameObject.SetActive(true);
                pickupAllowed = true;
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.name.Equals("player"))
            {
                pickupText.gameObject.SetActive(false);
                pickupAllowed = false;
            }
        }

        private void PickedUp()
        {
            Destroy(gameObject);
        }
    }
}
