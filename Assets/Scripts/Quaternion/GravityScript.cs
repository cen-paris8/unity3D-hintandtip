using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attached to Bird GO
public class GravityScript : MonoBehaviour
{
    public Transform target; // Lemur GO

    private void Update()
    {
        Vector3 relativePos = (target.position + new Vector3(0, 5f, 0)) - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);

        Quaternion current = transform.localRotation;

        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
        transform.Translate(0, 0, 3 * Time.deltaTime);
    }
}
