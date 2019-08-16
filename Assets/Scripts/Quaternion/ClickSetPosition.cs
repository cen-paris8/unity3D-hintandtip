using System.Collections;
using UnityEngine;

//Attached to GO Background 
public class ClickSetPosition : MonoBehaviour
{
    public PropertiesAndCoroutines coroutineScript; // From Robot GO.
    
    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //Get Vector3 Mouse position on GameView != on Device Screen

        RaycastHit hit;
        Physics.Raycast(ray, out hit);  // Has to be true/false if ray intercept a gameObject, do not work on 2D => unuseful

        if (hit.collider.gameObject == gameObject)
        {
            coroutineScript.Target = hit.point;
        }
        // Instead of hit.collider in 2D
        //coroutineScript.Target = ray.origin;

    }

}
