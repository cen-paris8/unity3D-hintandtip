﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attached to GO Main Camera
public class EventManager : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction OnClicked;

    public void OnGUI()
    {
        if (GUI.Button(new Rect((Screen.width / 2 - 50), 5, 100, 30), "Click"))
        {
            if( OnClicked != null)
            {
                OnClicked();
            }
        }
    }

}
