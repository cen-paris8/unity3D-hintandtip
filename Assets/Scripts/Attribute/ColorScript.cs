using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]     // Attached to GO Bird > Bird due to the renderer component attached
public class ColorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sharedMaterial.color = Color.green;
    }

}
