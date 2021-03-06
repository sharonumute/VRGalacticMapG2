using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	public float spinSpeed = 1f;
	private Vector3 rotationAmt;

	void Start () {
		rotationAmt = new Vector3 (0f, -spinSpeed/100, 0f);
	}

	void Update () {
		transform.Rotate (rotationAmt);
	}
}
