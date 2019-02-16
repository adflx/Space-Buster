using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class StageSelection : MonoBehaviour
{

    public void FallenEarth()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void BusterBase()
    {
        SceneManager.LoadScene("Stage2");
    }

    public void StigmaBase()
    {
        SceneManager.LoadScene("Stage3");
    }

}
