﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveGoo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goo")
        {
            Destroy(collision.gameObject);
        }
    }
}
