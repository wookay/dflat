using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed = 10;
	public Vector3 targetPosition = new Vector3(3, 3, 0);
	
	void Start()
	{
	}
	
	void Update ()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed, Space.World);
    }
}
