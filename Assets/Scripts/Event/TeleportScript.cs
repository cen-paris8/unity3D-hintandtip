using UnityEngine;

// Attached To GO Bird
public class TeleportScript : MonoBehaviour
{

    public void OnEnable()
    {
        EventManager.OnClicked += Teleport;
    }

    public void OnDisable()
    {
        EventManager.OnClicked -= Teleport;
    }

    public void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(1.0f, 3.0f);
        transform.position = pos;
    }
}
