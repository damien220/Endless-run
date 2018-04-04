using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private Rigidbody rb;
	[SerializeField]
	public float speed;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody>();
		rb.velocity = new Vector3(0f,0f,speed);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
