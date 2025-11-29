using UnityEngine;

public class TeleportOnCollision : MonoBehaviour
{
    public Vector3 teleportPosition = new Vector3(0, 2, 0);
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TeleportBox"))
        {
            Debug.Log("Teleport triggered!");

            controller.enabled = false;            // stop movement override
            transform.position = teleportPosition; // teleport safely
            controller.enabled = true;             // re-enable controller
        }
    }
}