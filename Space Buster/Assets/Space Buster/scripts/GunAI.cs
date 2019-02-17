using UnityEngine;
using System.Collections;

public class GunAI : MonoBehaviour {

    public GameObject Bullet;
     Transform BulletSpawn;
    public AudioClip GunSound;
    public float NextFire;
    public float FireRate;
    public GameObject[] targets;
    int tarpos;
    Transform target;

    private float mothercountdown = 5f;

    // Use this for initialization
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Target");
        tarpos = Random.Range(0, (targets.Length - 0));
        target = targets[tarpos].transform;
        move.bulletsp.transform.LookAt(target);
        BulletSpawn = move.bulletsp;
    }

    // Update is called once per frame
    void Update()
    {

        if (shipmovement() == true)
        {
            tarpos = Random.Range(0, (targets.Length - 0));
            target = targets[tarpos].transform;

        }



    }

    bool shipmovement()
    {
        mothercountdown -= Time.deltaTime;
        if (mothercountdown <= 0f)
        {
            mothercountdown = 5f;
            return true;
        }
        return false;

    }

    void OnTriggerStay(Collider ship)
    {
        if (Time.time > NextFire & ship.tag == "Track")
        {
            move.bulletsp.transform.LookAt(target);
            Instantiate(Bullet, move.bulletsp.transform.position, move.bulletsp.transform.rotation);
            AudioSource.PlayClipAtPoint(GunSound, transform.position);
            NextFire = Time.time + FireRate;
        }



    }


}
