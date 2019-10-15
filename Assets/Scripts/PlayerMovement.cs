using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody RB;
	Camera Cam;
	
	public float MoveSpeed = 10;
	public float JumpHeight = 5;
	
	public bool IsGrounded = false;

	private void Start()
	{
		RB = GetComponent<Rigidbody>();
		Cam = Camera.main;
	}

	private void FixedUpdate()
	{
		Move();
	}

	void Move() {
		float X = Input.GetAxis("Horizontal");
		float Z = Input.GetAxis("Vertical");
		Vector3 direction = new Vector3(X, 0, Z);

		Vector3 velocity = Quaternion.Euler(0, Cam.transform.eulerAngles.y, 0) * direction * MoveSpeed * Time.deltaTime;
		
		RB.rotation = Quaternion.Euler(0, Cam.transform.eulerAngles.y, 0);
		
		RB.AddForce(velocity, ForceMode.Impulse);
		
		if (Input.GetKeyDown(KeyCode.Space) && IsGrounded){
            RB.AddForce(new Vector3(0, JumpHeight, 0), ForceMode.Impulse);
        }
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
		{
			IsGrounded = true;
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
		{
			IsGrounded = false;
		}
	}

}
