using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(Movement))]
public class MovementEditor : Editor {
	Movement movement;
 
	void OnEnable()
    {
		movement = target as Movement;
	}
	
	void OnDisable()
    {
    }
	
	public override void OnInspectorGUI()
    {
		// EditorGUILayout.LabelField("Speed", EditorStyles.boldLabel);
		string[] speedNames = new string[] { "slow", "normal", "fast", "fastest" };
		int[] speedValues = new int[] 	   { 1,      5,        10,      20       };
		movement.speed = EditorGUILayout.IntPopup("Rotate Speed", 10, speedNames, speedValues);
		movement.targetPosition = EditorGUILayout.Vector3Field("Target Position", movement.targetPosition);
	}
	
	public void OnSceneGUI()
    {
        Handles.color = Color.red;
        Handles.CubeCap(0, movement.targetPosition, Quaternion.identity, 1.0f);
 
        Handles.color = Color.green;
        Handles.DrawLine(movement.gameObject.transform.position, movement.targetPosition);
 
        Handles.BeginGUI();
        {
            if (movement.gameObject.transform.position != movement.targetPosition) {
                Vector2 buttonPositoin = HandleUtility.WorldToGUIPoint(movement.targetPosition);
                Rect buttonRect = new Rect(buttonPositoin.x, buttonPositoin.y - 40, 200, 20);
                if (GUI.Button(buttonRect, "Move To Target Position")) {
                    movement.gameObject.transform.position = movement.targetPosition;
				}
            }
        }
		Handles.EndGUI();
	}
}