using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep : MonoBehaviour {
	public GameObject player;

	void Start() {
		Destroy(gameObject, 0.25f);
	}

	void OnTriggerEnter(Collider other) {
		Floor floor = other.GetComponent<Floor>();

		if(floor) {
			AudioClip sound = floor.GetFootstepSound();
			player.GetComponent<AudioSource>().PlayOneShot(sound);
			Destroy(gameObject);
		}
	}
}
