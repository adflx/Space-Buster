using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewData : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (Application.isEditor) //Does application is running in editor?
        {
            PlayerPrefs.DeleteAll();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
