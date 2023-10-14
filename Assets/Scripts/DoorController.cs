using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        door.transform.position -= new Vector3(0, 1, 0);
    }

}
