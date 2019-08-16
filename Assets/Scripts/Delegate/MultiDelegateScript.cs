using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiDelegateScript : MonoBehaviour
{
    delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;

    GUIStyle guiStyle = new GUIStyle();

    public void OnGUI()
    {
        myMultiDelegate += PowerUp;
        myMultiDelegate += TurnRed;

        if (myMultiDelegate != null)
        {
            myMultiDelegate();
        }
    }

    void PowerUp()
    {
        print(" Bird is powering up !");
        guiStyle.fontSize = 40; //change the font size
        GUI.Label(new Rect( 100, 100, 200, 100), "Bird is powering up !", guiStyle);
    }
    void TurnRed()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
