using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealthbar : MonoBehaviour {

    public Image currenthealthbar1;
    public Text ratiotext1;
  

    private float hitpoint;
    private float maxhitpoint;


    public Image gameoverback1;
    public Text gameovertext1;
    


    float restartTimer;
    public float restartDelay = 3f;


    // Use this for initialization
    void Start () {
        if (GameObject.FindGameObjectWithTag("Player").name.Equals("Blue 1"))
        {
            hitpoint = 2000;
            maxhitpoint = 2000;
        }
        else if (GameObject.FindGameObjectWithTag("Player").name.Equals("Red 1"))
        {
            hitpoint = 100;
            maxhitpoint = 3000;
        }
        else if (GameObject.FindGameObjectWithTag("Player").name.Equals("Gray 1"))
        {
            hitpoint = 1500;
            maxhitpoint = 1500;
        }
        UpdateHealthBar();
       
    }

    // Update is called once per frame
    void Update () {
	 if (hitpoint == 0)
        {
            Time.timeScale = 0;
            gameoverback1.color = Color.black;
            
            gameovertext1.color = Color.white;

            
            if (Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.JoystickButton0))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene("Character Selection");
            }
        }
	}

    private void UpdateHealthBar()
    {

        
        float ratio = hitpoint / maxhitpoint;
        currenthealthbar1.rectTransform.localScale = new Vector3(ratio, 1, 1);
       
        ratiotext1.text = (ratio * 100).ToString("0") + '%';
        

        if ((ratio * 100) <= 20 & (ratio * 100) > 10)
        {
            currenthealthbar1.color = Color.yellow;
            

        }
        else if ((ratio * 100) <= 10)
        {
            currenthealthbar1.color = Color.red;
            
        }
    }

    void ApplyDamage(int Damage)

    {

        hitpoint -= Damage;

        

        if (hitpoint <= 0)

        {
            hitpoint = 0;
            
            Destroy(this.gameObject);
            Debug.Log("DEAD");
        }

        UpdateHealthBar();

    }

}
