using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCheck : MonoBehaviour {

    public Text ammo;

    // Use this for initialization
    void Start () {
        check();
    }
	
	// Update is called once per frame
	void Update () {
        check();
	}

    private void check()
    {
        int ammoleft;
        if (GameObject.FindGameObjectWithTag("Player").name.Equals("Blue 1"))
        {
            ammoleft = Gun.ammonumber;
            ammo.text = "Ammo: " + ammoleft.ToString("") + "/120";
        }

        else if (GameObject.FindGameObjectWithTag("Player").name.Equals("Red 1"))
        {
            ammoleft = ShotGun.ammonumber;
            ammo.text = "Ammo: " + ammoleft.ToString("") + "/100";
        }
        else if (GameObject.FindGameObjectWithTag("Player").name.Equals("Gray 1"))
        {
            
            ammo.text = "Ammo: " + "0/0";
        }
        
    }
}
