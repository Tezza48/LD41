using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatableDoor : Activatable {

    public Transform activatedTransform;
    public Transform inacticeTransform;
    public Transform doorTransform;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnActivate()
    {
        base.OnActivate();
        doorTransform.SetPositionAndRotation(activatedTransform.position, activatedTransform.rotation);
    }
}
