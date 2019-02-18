using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckScore : MonoBehaviour {

    public static int score=0;

    public Text score1;
   

	// Use this for initialization
	void Start () {
        UpdateScore();
	}
	
	// Update is called once per frame
	void Update () {
        
        UpdateScore();
    }

    private void UpdateScore()
    {
        score1.text = "Score: "+score.ToString("");        
    }
}
