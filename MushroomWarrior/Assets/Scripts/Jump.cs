using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour{

	public Vector3 jumpVector;
	public float jumpForce = 2.0f;

	public bool isGrounded;
	Rigidbody2D rgbd;

	void Start(){
		rgbd = GetComponent<Rigidbody2D>();
		jumpVector = new Vector3(0.0f, 2.0f, 0.0f);
	}
    /* 
	void OnCollisionStay(){
			isGrounded = true;
	}*/


	// Button , tap screen to jump
	public Button jumpButton;

	//Function for jump button
	public void JumpButton(){
		if(isGrounded){
			rgbd.AddForce(jumpVector * jumpForce, ForceMode2D.Impulse);
			isGrounded = false;
		}
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			if(isGrounded){														//If the player is not in the middle of a jump
				rgbd.AddForce(jumpVector * jumpForce, ForceMode2D.Impulse);		//Make the player jump with 2.0f force in the Y direction
				isGrounded = false;												//Dont allow the player to double jump
			}
		} 
	}

	
	void OnCollisionEnter2D(Collision2D collision){
		//Debug.Log("This is a collision");
		//Debug.Log("isGrounded == " + isGrounded);
		if(collision.gameObject.CompareTag("ground")){							//check to see if the contact was made with ground
			isGrounded = true;													//If contact was made allow the player to jump again
		}
	}
	/*
	void OnCollisionExit(Collision collision){
		if(collision.gameObject.CompareTag("ground2")){
			isGrounded = false;
		}
	}
	*/
}
