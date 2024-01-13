using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuke : Powerup
{
    // POLYMORPHISM
    protected override void PowerupAction(PlayerController playerController)
    {
        playerController.Nuke();
        base.PowerupAction(playerController);
    }
}

