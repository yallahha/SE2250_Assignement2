using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour {
  public new Rigidbody rigidbody;
    public float speed; 
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        
	}
	
	// Update is called once per frame
	void Update () {
        float movex = Input.GetAxis("Horizontal");
        float movey = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(movex, 0.0f, movey);
        rigidbody.AddForce (movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);
        }
        Destroy(other.gameObject);
    }
}
