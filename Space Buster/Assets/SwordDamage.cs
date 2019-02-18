using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwordDamage : MonoBehaviour
{

    Animator anim;

    // Use this for initialization
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        anim = GetComponent<Animator>();
        if (sceneName == "Character Selection" || sceneName == "Stage Selection")
        {

            GetComponent<SwordDamage>().enabled = false;

        }
        else
        {
            GetComponent<SwordDamage>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))

        {
            anim.SetBool("attack", true);
        }
        else if (!Input.GetMouseButton(0))
        {
            anim.SetBool("attack", false);
        }
    }

    

  
}
