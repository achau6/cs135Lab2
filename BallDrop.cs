using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDrop : MonoBehaviour
{
	public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter(Collider other)
	{
		   if (other.attachedRigidbody)
		   {
				ball.GetComponent<Rigidbody>();
				ball.GetComponent<Rigidbody>().useGravity = true;
		   }
	}
}
