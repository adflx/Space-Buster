using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(GameObject.Find("ED(Clone)"), .9f);
        Destroy(GameObject.Find("BSP(Clone)"), .9f);
    }
}
