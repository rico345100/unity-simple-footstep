using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FloorType { Bush, Dirt, Grass, Snow };

public class Floor : MonoBehaviour {
	[SerializeField] FloorType floorType;

	public AudioClip GetFootstepSound() {
		int idx = Random.Range(1, 3);
		AudioClip sound = (AudioClip) Resources.Load("Footstep_" + floorType.ToString() + idx.ToString());

		return sound;
	}
}
