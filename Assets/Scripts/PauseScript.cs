using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused = false;
    GameObject[] items;

    public GameObject backGround;



    // Update is called once per frame
    private void Awake()
    {
        items = GameObject.FindGameObjectsWithTag("Item");
    }

    public void PauseGame()
    {
        backGround.GetComponent<AudioSource>().enabled = false;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        for (int i=0;  i < items.Length; i++)
        {
            items[i].SetActive(false);
        }
    }

    public void ResumeGame()
    {
        backGround.GetComponent<AudioSource>().enabled = true;
        pauseMenu.SetActive(false); 
        Time.timeScale = 1f;
        isPaused = false;
        for (int i = 0; i < items.Length; i++)
        {
            items[i].SetActive(true);
        }
    }
}
