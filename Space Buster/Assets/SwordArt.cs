using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordArt : MonoBehaviour {
    public int Damage = 50;
    void OnTriggerEnter(Collider Enemy)
    {


        if (Enemy.tag == "Enemy")

        {


            Enemy.SendMessage("ApplyDamage", Damage, SendMessageOptions.DontRequireReceiver);
           
           
            
        }

     



    }
}
