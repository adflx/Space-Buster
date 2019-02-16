using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    public static Transform bulletsp;
    public GameObject bulletspwan;
    Transform player;
    public float movespeed;
    private GameObject playerpoints;
    public GameObject Bullet;
    Transform BulletSpawn;
    public AudioClip GunSound;
    public float NextFire;
    public float FireRate;


    private float searchCountdown = 5f;
    

    void Start()
    {

        playerpoints = GameObject.FindGameObjectWithTag("Player");
        bulletsp = bulletspwan.transform;

    }


    // Update is called once per frame
    void Update () {
        
        float move = movespeed * Time.deltaTime;
        player = playerpoints.transform;
        transform.LookAt(player.position);
        Debug.Log(Vector3.Distance(transform.position, player.position));

        if (Vector3.Distance(transform.position, player.position) >= 3)
        {
            transform.position += transform.forward * move * Time.deltaTime;
            transform.LookAt(player.position);
            if (Vector3.Distance(transform.position, player.position) >= 0 )
            {
                if(Time.time > NextFire)
                {
                    transform.LookAt(player.position);
                    Instantiate(Bullet, bulletsp.transform.position, bulletsp.transform.rotation);
                    AudioSource.PlayClipAtPoint(GunSound, transform.position);
                    NextFire = Time.time + FireRate;
                }
                
            }
        }
        
        //if (shipMovement() == true)
        //{
            
        //    transform.position = Vector3.MoveTowards(transform.position, player.position, move);

        //}
    }


    bool shipMovement()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 5f;
            return true;
         

            
        }

        return false;
    }

    


}
