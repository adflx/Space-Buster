using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.EventSystems;
 using System.Collections;
using UnityEngine.SceneManagement;

public class WaveSpawner : MonoBehaviour {

    public enum SpawnState { Spawing, Waiting, Counting };

    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform enemy1;
        public Transform boss;
        public Transform[] enemy3;
        public int count;
        public float rate;
    }

    public Wave[] waves;
    private int nextWave = 0;
    public Text wavetext;
    public Text wavetext1;
    private int waving = 1;

    public Text gm1;
    public Text gm2;
    public Image textback1;
    public Image textback2;



    public Image back1;
    public Image back2;
    public Image back3;
    public Image back4;


    public Transform[] spawnPoints;
    public Transform aspawnpoint;
    public Transform bspawnpoint;
        
    public float timeBetweenWaves = 5f;
    private float waveCountdown;

    private float searchCountdown = 1f;
    private float restartTimer;
    private float restartDelay = 3f;


    private SpawnState state = SpawnState.Counting;

    // Use this for initialization
    void Start()
    {
      
        waveCountdown = timeBetweenWaves;
        back1.color = Color.white;
        back2.color = Color.white;
        back3.color = Color.white;
        back4.color = Color.white;
    


    }


    // Update is called once per frame
    void Update()
    {
        if (waving == 6)
        {
            Time.timeScale = 0;

            Debug.Log("All waves complete");
            gm1.text = "CONGRATULATION!";
            gm2.text = "CONGRATULATION!";
            textback1.color = Color.black;
            textback2.color = Color.black;
            gm1.color = Color.white;
            gm2.color = Color.white;

            if (Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.JoystickButton0))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene("GameOver");
            }
        }
        
        if(state == SpawnState.Counting)
        {
            if (waving <= 4)
            {

                wavetext.color = Color.yellow;

                wavetext.text = "Wave" + " " + waving;
                wavetext1.color = Color.yellow;

                wavetext1.text = "Wave" + " " + waving;
            }
          
        }
        if (state == SpawnState.Waiting)
        {

           
            //check
            if (!EnemyIsAlive())
            {
                //begin next wave
                WaveCompleted();
                Debug.Log("Wave complete");

                Debug.Log(waving);

            }
            else
            {
                return;
            }

            


        }

        if (waveCountdown <= 0)
        {
            if (state != SpawnState.Spawing)
            {
                //Start spawing wave
                StartCoroutine(SpawnWave( waves[nextWave]));
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

    void WaveCompleted()
    {
        state = SpawnState.Counting;
        if (waving <= 4)
        {
            waveCountdown = timeBetweenWaves;
        }
        else
        {
            waveCountdown = 0;
        }


        if (nextWave + 1 > waves.Length - 1)
        {
            Time.timeScale = 0;
            
            //Debug.Log("All waves complete");
            //gm1.text = "CONGRATULATION!";
            //gm2.text = "CONGRATULATION!";
            //textback1.color = Color.black;
            //textback2.color = Color.black;
            //gm1.color = Color.white;
            //gm2.color = Color.white;
            
            //if (Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.JoystickButton0))
            //{
            //    Time.timeScale = 1;
            //    SceneManager.LoadScene("GameOver");
            //}
            
        }
        else
        {
            nextWave++;
        }
    }

   

    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 1f;
           
            
            
             if (GameObject.FindGameObjectWithTag("Boss") == null & (waving == 5))
            {
                waving++;
                return false;
            }
            else if (GameObject.FindGameObjectWithTag("Enemy") == null & (waving <= 4))
            {
                waving++;
                return false;
            }
        }

        return true;
    }

    IEnumerator SpawnWave(Wave _wave)
    {
       
        state = SpawnState.Spawing;
        //spawn
        for (int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy1,_wave.enemy3, _wave.boss);
            yield return new WaitForSeconds( _wave.rate);
        }
       
   
        state = SpawnState.Waiting;
        yield break;
    }

    void SpawnEnemy(Transform _enemy1,Transform[] _enemy3,Transform _boss)
    {
        //spawn enemy

        wavetext.color = Color.clear;
        wavetext1.color = Color.clear;

        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];

        if (nextWave <3)
        {
            Instantiate(_enemy3[Random.Range(0, _enemy3.Length)], aspawnpoint.transform.position, transform.rotation);
        }
        if (nextWave <= 3)
        {
            Instantiate(_enemy1, _sp.transform.position, transform.rotation);
        }
        if(nextWave == 4)
        {
            Instantiate(_boss, bspawnpoint.transform.position, transform.rotation);
        }

    }

    
}
