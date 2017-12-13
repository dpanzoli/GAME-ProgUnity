using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveControllerInputTest : MonoBehaviour {

	private SteamVR_TrackedObject trackedObj;

	private SteamVR_Controller.Device Controller
	{
		get { return SteamVR_Controller.Input((int)trackedObj.index); }
	}

	void Awake()
	{
		trackedObj = GetComponent<SteamVR_TrackedObject>();

		Debug.Log ("ici");
		GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube.transform.position = new Vector3(0, 0, 1);
		//cube.transform.parent = trackedObj.GetComponent<Transform>();
	}


	// Update is called once per frame
	void Update () {
	
		if (Controller.GetHairTriggerDown())
		{
			Debug.Log ("trigger down");
			this.transform.Find("Cube").transform.localScale.Set(0.3f,0.3f,0.3f);
		}

		// 3
		if (Controller.GetHairTriggerUp())
		{
			this.transform.Find ("Cube").transform.localScale.Set (0.2f, 0.2f, 0.2f);
		}

	}



}
