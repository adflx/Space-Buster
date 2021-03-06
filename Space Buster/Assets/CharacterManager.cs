﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour {

    public GameObject[] characterList;
    public static int index;

    void Awake()
    {
        
    }

    // Use this for initialization
    void Start()
    {

        index = PlayerPrefs.GetInt("CharacterSelected", index);

        characterList = new GameObject[transform.childCount];


        //fill the array with models
        for (int x = 0; x < transform.childCount; x++)
        {
            characterList[x] = transform.GetChild(x).gameObject;

        }

        //toggle off their renderer
        foreach (GameObject go in characterList)
        {
            go.SetActive(false);
        }

        //toggle index

        if (characterList[index])
        {
            characterList[index].SetActive(true);

        }
    }

    public void ToggleLeft()
    {

        //toggle off old

        characterList[index].SetActive(false);


        index--;
        if (index < 0)
        {
            index = characterList.Length - 1;
        }

        //toffle on new
        characterList[index].SetActive(true);


    }

    public void ToggleRight()
    {

        //toggle off old

        characterList[index].SetActive(false);


        index++;
        if (index > characterList.Length - 1)
        {
            index = 0;
        }

        //toffle on new
        characterList[index].SetActive(true);


    }

    public void ToggleConfirm()
    {
        PlayerPrefs.SetInt("CharacterSelected",index);
        SceneManager.LoadScene("Stage1");
    }

    // Update is called once per frame
    void Update () {
        

    }
}
