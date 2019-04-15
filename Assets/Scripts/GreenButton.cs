using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GreenButton : MonoBehaviour
{
    [SerializeField] private GameObject greenDoor;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            greenDoor.transform.rotation = Quaternion.Euler(0, 0, 90);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        greenDoor.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
