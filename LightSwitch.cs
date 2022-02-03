using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LightSwitch : MonoBehaviour
{	
	public Light light;
	Color color0 = Color.red;    
	// Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown ("tab")) {
			light.color = color0;
		}
    }
}
