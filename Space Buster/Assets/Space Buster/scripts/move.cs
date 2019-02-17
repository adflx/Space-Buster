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

    public Animator anim;


    private float searchCountdown = 5f;
    

    void Start()
    {
        
        playerpoints = GameObject.Find(PlayerPrefs.GetString("CharacterName", "charname"));
        bulletsp = bulletspwan.transform;
        anim = GetComponent<Animator>();
        player = playerpoints.transform;
        transform.LookAt(player.position);
        bulletsp.LookAt(player.position);
    }


    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeInHierarchy)
        {
            transform.LookAt(player.position);
            float move = movespeed * Time.deltaTime;
            if (Vector3.Distance(transform.position, player.position) >= 3)
            {

                anim.SetBool("idle", false);
                anim.SetBool("moving", true);
                transform.position += transform.forward * move * Time.deltaTime;
                
                if (gameObject.name == "PA_Drone" || gameObject.name == "PA_Drone 1")
                {
                    transform.position = new Vector3(transform.position.x, 3f, transform.position.z);
                }




                if (Vector3.Distance(transform.position, player.position) >= 0)
                {
                    if (Time.time > NextFire)
                    {

                        anim.SetBool("idle", true);
                        anim.SetBool("moving", false);
                        Instantiate(Bullet, this.transform.position + transform.up, this.transform.rotation);
                        AudioSource.PlayClipAtPoint(GunSound, transform.position);
                        NextFire = Time.time + FireRate;
                    }

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
