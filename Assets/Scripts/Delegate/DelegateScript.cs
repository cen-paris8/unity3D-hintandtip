using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateScript : MonoBehaviour
{
    delegate void MyDelegate(int num);
    MyDelegate myDelegate;

    GUIStyle guiStyle = new GUIStyle();

    public void OnGUI()
    {
        myDelegate = PrintNum;
        myDelegate(50);

        myDelegate = DoubleNum;
        myDelegate(50);
    }

    public void PrintNum(int num)
    {
        print("Num is : " + num);
        guiStyle.fontSize = 40; //change the font size
        GUI.Label(new Rect(100, 150, 200, 100), "Num is : " + num, guiStyle);
    }

    public void DoubleNum(int num)
    {
        print("Double is : " + num * 2);
        
        guiStyle.fontSize = 40; //change the font size
        GUI.Label(new Rect(100, 200, 200, 100), "Double is : " + num * 2, guiStyle);

    }
}
