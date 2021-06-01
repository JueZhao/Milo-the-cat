using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectScript : MonoBehaviour
{
    public void levelOne()
    {

        SceneManager.LoadScene("MTC");

    }
    public void levelTwo()
    {

        SceneManager.LoadScene("Boss1");

    }
    public void levelThree()
    {

        SceneManager.LoadScene("MTC2");

    }
    public void levelFour()
    {

        SceneManager.LoadScene("MTC3");

    }
    public void levelFive()
    {

        SceneManager.LoadScene("MTC4");

    }
    public void levelSix()
    {

        SceneManager.LoadScene("MTC5");

    }
    public void levelRandoms()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - Random.Range(1,5));

    }
}
