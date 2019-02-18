using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckJump : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        check();
    }

    // Update is called once per frame
    void Update()
    {
        check();
        checkinputs();
    }


    private void check()
    {

        if (GameObject.FindGameObjectWithTag("Player").name.Equals("Red 1") & Input.GetKeyDown(KeyCode.Space))
        {
            GlobalAchievements.ach04Count += 1;
        }

        if (GameObject.FindGameObjectWithTag("Player").name.Equals("Gray 1") & Input.GetKey(KeyCode.Space))
        {

            GlobalAchievements.ach04Count += 1;
           
        }
    }
    private void checkinputs()
    {
        if (Input.anyKeyDown)
        {
            GlobalAchievements.ach06Count = 1;
        }
    }
}
