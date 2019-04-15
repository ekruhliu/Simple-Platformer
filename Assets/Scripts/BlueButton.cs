using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueButton : MonoBehaviour
{
    [SerializeField] private GameObject blueDoor;
    [SerializeField] private Vector3 open;
    [SerializeField] private Vector3 close;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            blueDoor.transform.position = open;
            blueDoor.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        blueDoor.transform.position = close;
        blueDoor.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
