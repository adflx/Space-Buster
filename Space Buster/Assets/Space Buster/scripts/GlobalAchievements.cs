using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAchievements : MonoBehaviour
{

    public GameObject achNote;
    public AudioSource achSound;
    public bool achActive = false;
    public GameObject achTitle;
    public GameObject achDsc;

    //01 specific


    public static int ach01Count;
    public int ach01Trigger = 100;
    public int ach01Code;

    public static int ach02Count;
    public int ach02Trigger = 500;
    public int ach02Code;


    public static int ach03Count;
    public int ach03Trigger = 1000;
    public int ach03Code;

    public static int ach04Count;
    public int ach04Trigger = 5;
    public int ach04Code;

    public static int ach05Count;
    public int ach05Trigger = 0;
    public int ach05Code;

    public static int ach06Count;
    public int ach06Trigger = 1;
    public int ach06Code;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        ach01Code = PlayerPrefs.GetInt("Ach01");
        ach02Code = PlayerPrefs.GetInt("Ach02");
        ach03Code = PlayerPrefs.GetInt("Ach03");
        ach04Code = PlayerPrefs.GetInt("Ach04");
        ach05Code = PlayerPrefs.GetInt("Ach05");
        ach06Code = PlayerPrefs.GetInt("Ach06");
        if (ach01Count >= ach01Trigger && ach01Code != 12345)
        {
            StartCoroutine(Trigger01Ach());
        }
        else if (ach02Count >= ach02Trigger && ach02Code != 12346)
        {
            StartCoroutine(Trigger02Ach());
        }
        else if (ach03Count >= ach03Trigger && ach03Code != 12347)
        {
            StartCoroutine(Trigger03Ach());
        }
        else if (ach04Count >= ach04Trigger && ach04Code != 12348)
        {
            StartCoroutine(Trigger04Ach());
        }

        else if (ach05Count == ach05Trigger && ach05Code != 12349)
        {
            StartCoroutine(Trigger05Ach());
        }
        else if (ach06Count == ach06Trigger && ach06Code != 12350)
        {
            StartCoroutine(Trigger06Ach());
        }
    }

    IEnumerator Trigger01Ach()
    {
        achActive = true;
        ach01Code = 12345;
        PlayerPrefs.SetInt("Ach01", ach01Code);
        achTitle.GetComponent<Text>().text = "Best Score!";
        achDsc.GetComponent<Text>().text = "You scored 100!";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //reset
        achNote.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDsc.GetComponent<Text>().text = "";
        achActive = false;
    }


    IEnumerator Trigger02Ach()
    {
        achActive = true;
        ach02Code = 12346;
        PlayerPrefs.SetInt("Ach02", ach02Code);
        achTitle.GetComponent<Text>().text = "Best Score!";
        achDsc.GetComponent<Text>().text = "You scored 500!";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //reset
        achNote.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDsc.GetComponent<Text>().text = "";
        achActive = false;
    }

    IEnumerator Trigger03Ach()
    {
        achActive = true;
        ach03Code = 12347;
        PlayerPrefs.SetInt("Ach03", ach03Code);
        achTitle.GetComponent<Text>().text = "Best Score!";
        achDsc.GetComponent<Text>().text = "You scored 1,000!";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //reset
        achNote.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDsc.GetComponent<Text>().text = "";
        achActive = false;
    }

    IEnumerator Trigger04Ach()
    {
        achActive = true;
        ach04Code = 12348;
        PlayerPrefs.SetInt("Ach04", ach04Code);
        achTitle.GetComponent<Text>().text = "Wow";
        achDsc.GetComponent<Text>().text = "You made 5 jumps";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //reset
        achNote.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDsc.GetComponent<Text>().text = "";
        achActive = false;
    }

    IEnumerator Trigger05Ach()
    {
        achActive = true;
        ach05Code = 12349;
        PlayerPrefs.SetInt("Ach05", ach05Code);
        achTitle.GetComponent<Text>().text = "WOW!";
        achDsc.GetComponent<Text>().text = "No Ammo to spare";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //reset
        achNote.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDsc.GetComponent<Text>().text = "";
        achActive = false;
    }

    IEnumerator Trigger06Ach()
    {
        achActive = true;
        ach06Code = 12350;
        PlayerPrefs.SetInt("Ach06", ach06Code);
        achTitle.GetComponent<Text>().text = "Detecting Input";
        achDsc.GetComponent<Text>().text = "First time to play";
        achNote.SetActive(true);
        yield return new WaitForSeconds(7);
        //reset
        achNote.SetActive(false);
        achTitle.GetComponent<Text>().text = "";
        achDsc.GetComponent<Text>().text = "";
        achActive = false;
    }

}
