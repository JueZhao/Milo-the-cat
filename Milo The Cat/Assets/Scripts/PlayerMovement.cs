using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 20f;

    float HorizontalMove = 0f;

    bool jump = false;

    bool crouch = false;
    
    // Update is called once per frame
    void Update()
    {
        
        HorizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("speed", Mathf.Abs(HorizontalMove));
        
        if (Input.GetButtonDown("Jump")){
            jump = true;
            animator.SetBool("IsJumping",true);
        }

        if (Input.GetButtonDown("Crouch")){
            crouch = true;
        } else if (Input.GetButtonUp("Crouch")){
            crouch = false;
        }
    }

    public void Onlanding ()
    {
        animator.SetBool("IsJumping",false);
    }

    public void OnCrouching (bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate ()
    {
        controller.Move(HorizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }

		if (other.tag == "PowerUpSpeed")
		{
			Destroy(other.gameObject);
			runSpeed = 40f;
			StartCoroutine(ResetPower());
		}
	}

	private IEnumerator ResetPower()
	{
		yield return new WaitForSeconds(20);
		runSpeed = 20f;
	}
}
