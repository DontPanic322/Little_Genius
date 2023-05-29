using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tobecontinied : MonoBehaviour
{

    public Image image;

    public void EndGame()
    {
        image.gameObject.SetActive(true);
    }

    public void Update()
    {
        Invoke("EndGame", 2f);
    }
}
