using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Door : Interactable {

    public float closedRotation;
    public float openRotation;
    public bool isOpen = false;

    public override void OnInteract()
    {
        base.OnInteract();
        isOpen = !isOpen;
        transform.rotation =Quaternion.AngleAxis(isOpen ? openRotation : closedRotation, Vector3.up);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
