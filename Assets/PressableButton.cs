using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressableButton : Interactable {

    public Activatable thingToActivate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnInteract()
    {
        base.OnInteract();
        thingToActivate.OnActivate();
    }
}
