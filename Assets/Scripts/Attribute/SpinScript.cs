using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attached to GO Bird
public class SpinScript : MonoBehaviour
{
    [Range(-100, 100)]
    public int speed = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, Time.deltaTime * speed));
    }
}