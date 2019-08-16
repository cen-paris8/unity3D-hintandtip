using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attached to Lemur GO
public class LookAtScript : MonoBehaviour
{
    public Transform target; // From Robot/Monster GO
    
    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos, new Vector3 (0, 1, 0));        
    }
}
