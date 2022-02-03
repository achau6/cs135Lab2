using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_Switch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("2")){
			transform.position = new Vector3 (48,1,50);
		}
		if(Input.GetKeyDown("1")){
			transform.position = new Vector3 (3,1,0);
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			#if UNITY_EDITOR
				UnityEditor.EditorApplication.isPlaying = false;
			#else
				Application.Quit();
			#endif
		}
    }
}