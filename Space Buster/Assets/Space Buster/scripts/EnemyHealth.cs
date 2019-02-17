using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    //private int heath, maxhealth;
    //public int Health { get { return heath; } }
    //private Image healthbar;

   private float starthitpoint;

    private float hitpoint;
   
    public AudioClip DeathSound;
	public GameObject DestroyPrefab;
 //   public Image currenthealthbar1;
   

    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Enemy").name.Equals("PA_Drone"))
        {
            hitpoint = 200;

        }

        else if (GameObject.FindGameObjectWithTag("Enemy").name.Equals("PA_Warrior"))
        {
            hitpoint = 150;

        }
        else if (GameObject.FindGameObjectWithTag("Enemy").name.Equals("Robot1"))
        {
            hitpoint = 350;

        }
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
        
        Instantiate(DestroyPrefab, transform.position, transform.rotation);
        AudioSource.PlayClipAtPoint(DeathSound, transform.position);
        Destroy(this.gameObject);
       
		
       
    }
}
