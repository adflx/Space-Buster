using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class ShotGun : MonoBehaviour {

	public GameObject Bullet;
    public Transform BulletSpawn;
    public Transform BulletSpawn1;
    public Transform BulletSpawn2;
    public Transform BulletSpawn3;
    public AudioClip GunSound;
	private  float NextFire= 0;
    public float FireRate;
    public static int ammonumber = 100; 

	// Use this for initialization
	void Start () {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Character Selection" || sceneName == "Stage Selection")
        {

            GetComponent<ShotGun>().enabled = false;

        }
        else
        {
            GetComponent<ShotGun>().enabled = true;
        }

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
        ammonumber= ammonumber - 2;
        Ray ray = new Ray(BulletSpawn.position, BulletSpawn.forward);
        Instantiate(Bullet, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
        Instantiate(Bullet, BulletSpawn1.transform.position, BulletSpawn.transform.rotation);
        Instantiate(Bullet, BulletSpawn2.transform.position, BulletSpawn.transform.rotation);
        Instantiate(Bullet, BulletSpawn3.transform.position, BulletSpawn.transform.rotation);
        AudioSource.PlayClipAtPoint(GunSound, transform.position);
        NextFire = Time.time + FireRate;
    }
}
