using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public int Speed = 5;
	public int Damage = 50;
	public GameObject DestroyPrefab;

    

    

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		transform.Translate(Vector3.forward * Time.deltaTime * Speed);

		if (gameObject.name == "Bullet(Clone)")
		{
			Destroy(this.gameObject, 2);
		}

	}

	void OnTriggerEnter(Collider Enemy) {

		if (Enemy.tag == "Enemy" || Enemy.tag == "Asteriod" || Enemy.tag == "Boss")

		{
            //if (Enemy.tag == "Enemy")
            //{
            //    CheckScore.score += 50;
            //}
            //if (Enemy.tag == "Asteriod")
            //{
            //    CheckScore.score += 20;
            //}
            //if (Enemy.tag == "Boss")
            //{
            //    CheckScore.score += 1000;
            //}

            Enemy.SendMessage ("ApplyDamage", Damage,SendMessageOptions.DontRequireReceiver);
			Instantiate (DestroyPrefab, transform.position, transform.rotation);
			Destroy (this.gameObject); 
		}

        else if (Enemy.tag == "AIBullet")
        {
            Instantiate(DestroyPrefab, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
        


    }
}
