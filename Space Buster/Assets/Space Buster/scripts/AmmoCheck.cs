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
        int ammoleft = Gun.ammonumber;
        ammo.text = "Ammo: " + ammoleft.ToString("") + "/120";
    }
}
