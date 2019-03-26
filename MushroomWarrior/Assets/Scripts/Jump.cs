using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour{
	private int maxJumpHeight = 15;
	public Vector3 jumpVector;
	public float jumpForce = 4.0f;
	public bool isGrounded;
	Rigidbody2D rgbd;
    public Button jumpButton;
    public int jumpCounter = 0;

    public void JumpButton(){
        Debug.Log("Jump button pressed");
        rgbd.AddForce(jumpVector * jumpForce, ForceMode2D.Impulse);
        isGrounded = false;
    }

    void Start(){
        rgbd = GetComponent<Rigidbody2D>();
		jumpVector = new Vector3(0.0f, 0.25f, 0.0f);
	}
    
	void Update(){
		if(Input.GetKey(KeyCode.UpArrow)){
			if(isGrounded){														//If the player is not in the middle of a jump
				rgbd.AddForce(jumpVector * jumpForce, ForceMode2D.Impulse);		//Make the player jump with 2.0f force in the Y direction
				jumpCounter++;
				if(jumpCounter == maxJumpHeight)
					isGrounded = false;												//Dont allow the player to double jump
                Debug.Log("You have jumped " + jumpCounter + " times");
			}
		}
	}
    
	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.CompareTag("ground")){							//check to see if the contact was made with ground
			isGrounded = true;													//If contact was made allow the player to jump again
			jumpCounter = 0;
		}
	}
}
