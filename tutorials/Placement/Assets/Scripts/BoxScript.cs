using UnityEngine;
using System.Collections;

public class BoxScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		renderer.material.color = new Color(Random.value, Random.value, Random.value, 1);
	}
	
	void LateUpdate () {
		Camera.main.transform.LookAt(transform);
	}
}
