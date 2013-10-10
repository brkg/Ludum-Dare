using UnityEngine;
using System.Collections;

public class levelZero : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetMouseButtonDown(0))
		{
			Application.LoadLevel (1);
		}
		
		if (Time.time > 30f)
		{
			Application.LoadLevel (1);
		}
		
	}
}
