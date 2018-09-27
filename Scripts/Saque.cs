using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saque : MonoBehaviour {

    //Asociar a un objeto vacío donde queramos que salga la bola

    public GameObject ball;
    bool startMatch = true;
    Rigidbody2D rb;
    Vector2 forward;
    public float speed; //Dejarla a 1 

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        forward = new Vector2(speed / Time.deltaTime, Random.Range(-2.5F, 2.5F));
   	}
	
	// Update is called once per frame
	void Update () {
		if (startMatch)
        {
            ball.transform.position = transform.position;
            ball.GetComponent<Rigidbody2D>().AddForce(forward, ForceMode2D.Impulse);
            startMatch = false;
        }
	}
}
