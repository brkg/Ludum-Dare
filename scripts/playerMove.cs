using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour {
	
	//the desired speed of the player character
	float speed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	void Update(){
		//this block of code describes using the WASD keys to move.
		//GetKeyUp allows for smoother movement
		if(Input.GetKeyUp ("w"))
		{
			rigidbody.velocity = Vector3.zero;
		}
		if(Input.GetKeyUp ("a"))
		{
			rigidbody.velocity = Vector3.zero;
		}
		if(Input.GetKeyUp ("s"))
		{
			rigidbody.velocity = Vector3.zero;
		}
		if(Input.GetKeyUp ("d"))
		{
			rigidbody.velocity = Vector3.zero;
		}
		if (Input.GetKey("w"))
		{
			//rigidbody.velocity = Vector3.zero;
			rigidbody.AddForce(transform.forward * speed, ForceMode.VelocityChange);
		}
		if (Input.GetKey("a"))
		{
			//rigidbody.velocity = Vector3.zero;
			rigidbody.AddForce(-transform.right * speed, ForceMode.VelocityChange);
		}
		if (Input.GetKey("s"))
		{
			//rigidbody.velocity = Vector3.zero;
			rigidbody.AddForce(-transform.forward * speed, ForceMode.VelocityChange);
		}
		if (Input.GetKey("d"))
		{
			//rigidbody.velocity = Vector3.zero;
			rigidbody.AddForce(transform.right * speed, ForceMode.VelocityChange);
		}
		
		//this block of code describes using the mouse to look around.
						//Ray ray_mouse = Camera.main.ScreenPointToRay(Input.mousePosition); 
						//RaycastHit rayHit = new RaycastHit();
		//rotate player 90 degrees left and right by left and right clicking
		if(Input.GetMouseButtonDown(0))
		{
			transform.eulerAngles += -1 * Vector3.up * 90;
		}
		
		if(Input.GetMouseButtonDown(1))
		{
			transform.eulerAngles += Vector3.up * 90;
		}
		
		if(Input.GetKeyDown("space"))
		{
			transform.eulerAngles += -1 * Vector3.up * 180; 
		}
	}
	
	// Update is called once per frame
	void fixedUpdate () {
	
	}
}
