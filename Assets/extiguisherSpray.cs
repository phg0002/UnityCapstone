using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extiguisherSpray : MonoBehaviour {

    public ParticleSystem spray;
    public GameObject sprayOrigin;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log(sprayOrigin.transform.position.ToString());
            ParticleSystem spraying = Instantiate(spray, sprayOrigin.transform);
            spraying.transform.localPosition = Vector3.zero;
            spraying.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }    
    }
}
