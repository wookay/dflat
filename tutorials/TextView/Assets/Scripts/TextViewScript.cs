using UnityEngine;
using System.Collections;

public class TextViewScript : MonoBehaviour {
	public string text;
	public GUIStyle guiStyle;
	
	// Use this for initialization
	void Start () {
		string lorem = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
		text = lorem + lorem + lorem;
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnGUI() {
		text = GUI.TextField(new Rect (10, 10, 400, 400), text, 9999999, guiStyle);
	}
}