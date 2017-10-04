using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {
	GameObject script;

	// Use this for initialization
	void Start () {
		script = GameObject.Find ("Pin");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 TargetPosition;
		MoveScript ms = script.GetComponent<MoveScript> ();
		TargetPosition.Position = ms.Pos;
	}
}
