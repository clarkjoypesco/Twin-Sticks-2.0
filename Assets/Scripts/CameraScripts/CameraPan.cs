using UnityEngine;
using System.Collections;

public class CameraPan : MonoBehaviour {

	private GameObject player;

	void Start () {
	

		player = GameObject.FindGameObjectWithTag ("Player");
	}
	

	void LateUpdate () {

		transform.LookAt (player.transform);
		//print ("RHoriz " + Input.GetAxis("RHoriz"));
		//print ("RVert " + Input.GetAxis("RVert"));
	}
}
