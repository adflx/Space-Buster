using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.ThirdPerson;

public class CheckScene : MonoBehaviour {

    
    
    void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        GameObject varGameObject = GameObject.FindWithTag("Player");
        string sceneName = currentScene.name;

        if (sceneName == "Character Selection" || sceneName == "Stage Selector")
        {
            
            varGameObject.GetComponent<Gun>().enabled = false;

        }
        else
        {
            
        }
    }

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
    
    }
}
