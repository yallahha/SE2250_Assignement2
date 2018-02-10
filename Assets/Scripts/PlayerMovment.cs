using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovment : MonoBehaviour {
  public new Rigidbody rigidbody;
    public float speed;
    private int count;
    public Text counttext;
    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
        count = 0;
        counttext.text = "Count: " + count.ToString();

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
            if (other.GetComponent<Renderer>().material.color == Color.green)
            {
                count = count + 1;
            }
            if (other.GetComponent<Renderer>().material.color == Color.gray)
            {
                count = count + 2;
            }
            if (other.GetComponent<Renderer>().material.color == Color.magenta)
            {
                count = count + 3;
            }
            else
            {
                count = count + 1;
            }
            counttext.text = "Count: " + count.ToString();
        }
    }
}
