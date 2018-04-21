using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour {

    public List<GameObject> objectsInRoom;

	// Use this for initialization
	void Start () {
        foreach (var item in objectsInRoom)
        {
            item.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        foreach (var item in objectsInRoom)
        {
            item.SetActive(true);
        }
    }
}
