using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberSlot : MonoBehaviour
{
    public SpriteRenderer Renderer;

    [SerializeField] private AudioSource _source;
    

    public void Placed()
    {
        _source.Play();
    }
}
