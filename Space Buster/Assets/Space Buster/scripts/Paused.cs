using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Paused : MonoBehaviour
{
    public bool paused;
    public Image back1;
    public Text text1;

    public Text textOB11;
    public Image back11;



    // Use this for initialization
    void Start()
    {
        paused = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            paused = !paused;
        }
        if (paused)
        {
           
            Time.timeScale = 0;
            back1.color = Color.gray;
            text1.color = Color.white;
            textOB11.text = "Do you want to Exit the Game" + "\n" + "Press ESC Button to continue playing\n" + "Press Right Click to Exit";
            textOB11.color = Color.yellow;
            back11.color = Color.black;

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene("Character Selection");
            }
        }
        else if (!paused)
        {
       
            Time.timeScale = 1;
            back1.color = Color.clear;
            text1.color = Color.clear;


            textOB11.color = Color.clear;
            back11.color = Color.clear;
        }
    }
}
