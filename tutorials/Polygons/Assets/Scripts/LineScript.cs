// LineScript.cs
// wookay.noh@gmail.com

using UnityEngine;
using System.Collections;

public class LineScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LineRenderer lineRenderer = GetComponent<LineRenderer>();
		lineRenderer.SetVertexCount(4);
		lineRenderer.SetPosition(0, GameObject.Find("PointA").transform.position);
		lineRenderer.SetPosition(1, GameObject.Find("PointB").transform.position);
		lineRenderer.SetPosition(2, GameObject.Find("PointC").transform.position);
		lineRenderer.SetPosition(3, GameObject.Find("PointD").transform.position);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
