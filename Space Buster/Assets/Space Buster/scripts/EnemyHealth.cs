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
            this.gameObject.GetComponent<move>().enabled = false;
            Dead();
		}

    

    }



  
    // Update is called once per frame
    void Dead () 

	{

        
        //   Destroy(transform.gameObject.GetComponentInParent<Canvas>().gameObject);
        if (gameObject.name.Equals("PA_Drone(Clone)"))
        {
            CheckScore.score += 50;
            GlobalAchievements.ach01Count += 50;
            GlobalAchievements.ach02Count += 50;
            GlobalAchievements.ach03Count += 50;

        }

        else if (gameObject.name.Equals("PA_Warrior(Clone)"))
        {
            
            CheckScore.score += 30;
            GlobalAchievements.ach01Count += 30;
            GlobalAchievements.ach02Count += 30;
            GlobalAchievements.ach03Count += 30;

        }
        else if (gameObject.name.Equals("Robot1(Clone)"))
        {
            CheckScore.score += 20;
            GlobalAchievements.ach01Count += 20;
            GlobalAchievements.ach02Count += 20;
            GlobalAchievements.ach03Count += 20;

        }
        
        Instantiate(DestroyPrefab, transform.position, transform.rotation);
        AudioSource.PlayClipAtPoint(DeathSound, transform.position);
        this.gameObject.GetComponent<move>().enabled = false;
        Destroy(this.gameObject);
       
		
       
    }
}
