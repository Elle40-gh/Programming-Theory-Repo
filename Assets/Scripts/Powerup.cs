using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerController playerControllerScript = other.gameObject.GetComponent<PlayerController>();
            PowerupAction(playerControllerScript); // ABSTRACTION
        }
    }

    protected virtual void PowerupAction(PlayerController playerController)
    {
        playerController.HasPowerup = true;
        Destroy(gameObject);      
    }

    void FixedUpdate()
    {
        transform.Rotate(0, 1, 0);
    }
}
