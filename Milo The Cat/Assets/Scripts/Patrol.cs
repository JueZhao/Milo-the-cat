using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
   
    public float speed;
    public float distance;
    private bool move = true;
    public  Transform groundDetection;

    public int health = 100;

    public GameObject deathEffect;

    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D checkPos = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if(checkPos.collider == false){
            if(move == true){
                transform.eulerAngles = new Vector3(0, -180,0 );
                move =  false;
            }else{
                transform.eulerAngles = new Vector3(0, 0 ,0 );
                move =  true;
            }

        }
    }
}
