﻿// PointScript.cs
// wookay.noh@gmail.com

using UnityEngine;
using System.Collections;

public class PointScript : MonoBehaviour {
	
	GameObject line;
	GameObject label;
	
	// Use this for initialization
	void Start () {
		line = GameObject.Find("Line");
		label = GameObject.Find("Label");
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	IEnumerator OnMouseDown() {
		Vector3 scrSpace = Camera.main.WorldToScreenPoint (transform.position);
		Vector3 offset = transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, scrSpace.z));
		 
		while (Input.GetMouseButton(0)) {
			Vector3 curScreenSpace = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, scrSpace.z);
			Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;
			transform.position = curPosition;
			
			LineRenderer lineRenderer = line.GetComponent<LineRenderer>();
			if ("PointA" == gameObject.name) {
				lineRenderer.SetPosition(0, curPosition);
			} else if ("PointB" == gameObject.name) {
				lineRenderer.SetPosition(1, curPosition);
			} else if ("PointC" == gameObject.name) {
				lineRenderer.SetPosition(2, curPosition);
			} else if ("PointD" == gameObject.name) {
				lineRenderer.SetPosition(3, curPosition);
			}
			GUIText guiText = label.GetComponent<GUIText>();
			guiText.text = gameObject.name + " " + curPosition.ToString();

			yield return null;
		}
	}
}
