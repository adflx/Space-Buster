using UnityEngine;
using System.Collections;


public class Gun : MonoBehaviour {

	public GameObject Bullet;
	public Transform BulletSpawn;
	public AudioClip GunSound;
	private  float NextFire= 0;
    public float FireRate;
    public static int ammonumber = 120; 

	// Use this for initialization
	void Start () {
        
       
	}

	// Update is called once per frame
	void Update () {
      
        
		if (Input.GetMouseButton(0) & Time.time > NextFire & ammonumber > 0)
			
		{
            FireGun();
		}


	}

    private void FireGun()
    {
        ammonumber--;
        Ray ray = new Ray(BulletSpawn.position, BulletSpawn.forward);
        Instantiate(Bullet, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
        AudioSource.PlayClipAtPoint(GunSound, transform.position);
        NextFire = Time.time + FireRate;
    }
}
