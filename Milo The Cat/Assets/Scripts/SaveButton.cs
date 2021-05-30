using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButton : MonoBehaviour
{
    PlayerMovement player;
   public void SavePlayer()
   {
       Save.SavePlayer(player);
    }
}
