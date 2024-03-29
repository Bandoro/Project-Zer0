﻿using UnityEngine;
using System.Collections;

public class PickupLife : MonoBehaviour {
	PlayerInventory inventory;
	// Use this for initialization
	void Start () {
		inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();
	}
	
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			if(inventory.GainLife(1) == true) {
				Invoke("ReActivate", 5);
				gameObject.SetActive(false);
			}
		}
	}
	
	void ReActivate() {
		gameObject.SetActive (true);
	}
}
