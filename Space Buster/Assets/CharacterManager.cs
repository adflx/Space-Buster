using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour {

    public CharacterInfo[] Characters;

    public GameObject SpawnPoint;

    private int _currentIndex = 0;

    private CharacterInfo _currentCharacterType = null;

    private CharacterInfo _currentCharacter = null;

 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
