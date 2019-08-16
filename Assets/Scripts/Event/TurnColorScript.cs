using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attached To GO Bird1
public class TurnColorScript : MonoBehaviour
{
    public void OnEnable()
    {
        EventManager.OnClicked += TurnColor;
    }

    public void OnDisable()
    {
        EventManager.OnClicked -= TurnColor;
    }

    public void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = col;
    }

}
