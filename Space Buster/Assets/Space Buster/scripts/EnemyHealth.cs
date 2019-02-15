using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    //private int heath, maxhealth;
    //public int Health { get { return heath; } }
    //private Image healthbar;

   public float starthitpoint;

    private float hitpoint;
   
    public AudioClip GunSound;
	public GameObject DestroyPrefab;
 //   public Image currenthealthbar1;
   

    void Start()
    {
        // healthbar = transform.FindChild("EnemyCanvas").FindChild("Image").FindChild("Currentenemy").GetComponent<Image>(); 
        hitpoint = starthitpoint;
        

    }

    // Use this for initialization
    void ApplyDamage (int Damage) 

	{

		hitpoint -= Damage;
      // currenthealthbar1.fillAmount = hitpoint / starthitpoint;
		if (hitpoint <= 0)
      
		{
            hitpoint = 0;

			Dead();
		}

    

    }



  
    // Update is called once per frame
    void Dead () 

	{
     //   Destroy(transform.gameObject.GetComponentInParent<Canvas>().gameObject);
        
		Destroy(this.gameObject);
       
		Instantiate (DestroyPrefab, transform.position, transform.rotation);
		AudioSource.PlayClipAtPoint(GunSound, transform.position);
	}
}
