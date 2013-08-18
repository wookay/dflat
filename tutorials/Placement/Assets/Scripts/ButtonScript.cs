using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {
	
	public GameObject prefabBox;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		if (GUI.Button(new Rect(10, 10, 150, 100), "push")) {
			for (int idx=0; idx < 5; idx++) {
				Instantiate(prefabBox, new Vector3(1, 6, idx), Quaternion.identity);
			}
		}
	}
}
