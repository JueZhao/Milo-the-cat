using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadButton : MonoBehaviour
{
   PlayerMovement player;

   public void LoadPlayer()
   {
       PlayerData data = Save.LoadPlayer();

       Vector3 position;
       position.x = data.position[0];
       position.y = data.position[1];
       position.z = data.position[2];
   }
}
