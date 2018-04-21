using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CableSpline : MonoBehaviour {

    public LineRenderer cableRenderer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cableRenderer.positionCount = transform.childCount;
        for (int i = 0; i < transform.childCount; i++)
        {
            cableRenderer.SetPosition(i, transform.GetChild(i).position);
        }
	}
}
