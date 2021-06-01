using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DoorScript : MonoBehaviour
{

    public int LeveltoLoad;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Destroy(GameMaster.instance);
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {

        if (col.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Destroy(GameMaster.instance);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {

        if (col.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Destroy(GameMaster.instance);
        }
    }
    public static GameMaster instance;
}
