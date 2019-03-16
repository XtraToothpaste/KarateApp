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

	void OnCollisionStay(){
			isGrounded = true;
		}


	// Button , tap screen to jump
	public Button jumpButton;

	//Function for jump button
	/*public void JumpButton(){
		if(isGrounded){
			rgbd.AddForce(jumpVector * jumpForce, ForceMode2D.Impulse);
			isGrounded = false;
		}
	}*/

	void Update(){
		/*if(Input.touchCount == 1){
			if(isGrounded){
				rgbd.AddForce(jumpVector * jumpForce, ForceMode2D.Impulse);
				isGrounded = false;
			}
		}*/
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			if(isGrounded){
				rgbd.AddForce(jumpVector * jumpForce, ForceMode2D.Impulse);
				isGrounded = false;
			}
		}
	}

	/*
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.CompareTag("Ground")){
			isGrounded = true;
		}
	}

	void OnCollisionExit(Collision collision){
		if(collision.gameObject.CompareTag("Ground")){
			isGrounded = false;
		}
	}
	*/
}
