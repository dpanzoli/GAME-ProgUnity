using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		string[] devices = UnityEngine.Input.GetJoystickNames ();
		for(int i = 0; i < devices.Length ; i++)
		{
			Debug.Log (devices [i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
