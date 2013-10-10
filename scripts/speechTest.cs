using UnityEngine;
using System.Collections;

public class speechTest : MonoBehaviour {
	
	public TextMesh testing;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter() {
	
		testing.text = "I am a murderer.";	
	}
}
