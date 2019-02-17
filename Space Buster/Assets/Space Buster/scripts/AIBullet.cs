﻿using UnityEngine;
using System.Collections;

public class AIBullet : MonoBehaviour {

    public int Speed = 5;
    public int Damage = 25;
    public GameObject DestroyPrefab;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);

        if (gameObject.name == "AIBullet(Clone)")
        {
            Destroy(this.gameObject, 2);
        }

    }

    void OnTriggerEnter(Collider Enemy)
    {


        if (Enemy.tag == "Player")

        {
            Enemy.SendMessage("ApplyDamage", Damage, SendMessageOptions.DontRequireReceiver);
            Instantiate(DestroyPrefab, transform.position, transform.rotation);
            Destroy(this.gameObject);

        }

        else if(Enemy.tag == "PBullet")
        {
            Instantiate(DestroyPrefab, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }


    }

}
