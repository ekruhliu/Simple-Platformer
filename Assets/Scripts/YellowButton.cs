using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowButton : MonoBehaviour
{
    [SerializeField] private GameObject yellowDoor;
    [SerializeField] private Vector3 open;
    [SerializeField] private Vector3 close;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            yellowDoor.transform.position = open;
            yellowDoor.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {    
        yellowDoor.transform.position = close;
        yellowDoor.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
