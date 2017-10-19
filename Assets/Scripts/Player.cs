using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	[SerializeField] GameObject footstep;
	[SerializeField] Transform footstepPos;
	Vector3 prevPos;
	bool footstepDelay = false;

	void Start() {
		prevPos = transform.position;
	}

	void Update() {
		Vector3 newPos = transform.position;

		if(prevPos != newPos) {
			if(!footstepDelay) {
				footstepDelay = true;
				GameObject footstepObj = Instantiate(footstep, footstepPos);
				footstepObj.GetComponent<Footstep>().player = gameObject;
				StartCoroutine(CoResetFootstepDelay());
			}

			prevPos = newPos;
		}
	}

	IEnumerator CoResetFootstepDelay() {
		yield return new WaitForSeconds(1f);
		footstepDelay = false;
	}
}
