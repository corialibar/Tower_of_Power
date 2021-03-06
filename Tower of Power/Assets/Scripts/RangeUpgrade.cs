﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RangeUpgrade : MonoBehaviour
{

    public GameObject phaseController;

    // Use this for initialization
    void Start()
    {
        phaseController = GameObject.Find("PhaseController");
    }

    // Update is called once per frame
    void Update()
    {
        if (!phaseController.GetComponent<PhaseController>().upgradePhase)
        {
            Destroy(gameObject);
        }
    }

    //Allows the player to pick up the upgrade and increases the range of fireballs.
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            collision.gameObject.GetComponent<PlayerController>().range += 0.10f;
            phaseController.GetComponent<PhaseController>().upgradePickedUp = true;
        }
    }
}
