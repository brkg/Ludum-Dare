using UnityEngine;
using System.Collections;

public class changeTrigger : MonoBehaviour {
	
	// counts how many times player has entered trigger. 
	public int triggerCount; 
	
	//initial message upon game start.
	public GameObject welcome1, welcome2;
	
	//end[i] is the ith bit of text to display.
	public GameObject end1, end2, end3, end4, end5;
	public GameObject end6, end7, end8, end9;
	
	public GameObject endLights;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(){
		triggerCount++;
		//if player has entered trigger 6+ times, a new message appears. 
		if (triggerCount > 5) 
		{
			Destroy (welcome1);
			Destroy (welcome2);
			end1.renderer.enabled = true;
			end2.renderer.enabled = true;
			end3.renderer.enabled = true;
			end4.renderer.enabled = true;
			end5.renderer.enabled = true;
			end6.renderer.enabled = true;
			end7.renderer.enabled = true;
			end8.renderer.enabled = true;
			end9.renderer.enabled = true;
			
			//turn on the halo as well, to show player something new in the world has appeared
			(endLights.GetComponent("Halo") as Behaviour).enabled = true; 
			
		}
	}
}
