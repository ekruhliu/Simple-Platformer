using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteButton : MonoBehaviour
{
    [SerializeField] private GameObject blueDoor;
    [SerializeField] private GameObject redDoor;
    [SerializeField] private GameObject yellowDoor;

    [SerializeField] private Vector3 openBlue;
    [SerializeField] private Vector3 closeBlue;
    [SerializeField] private Vector3 openRed;
    [SerializeField] private Vector3 closeRed;
    [SerializeField] private Vector3 openYellow;
    [SerializeField] private Vector3 closeYellow;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Equals("blue"))
        {
            blueDoor.transform.position = openBlue;
            blueDoor.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (other.name.Equals("red"))
        {
            redDoor.transform.position = openRed;
            redDoor.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (other.name.Equals("yellow"))
        {
            yellowDoor.transform.position = openYellow;
            yellowDoor.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        blueDoor.transform.position = closeBlue;
        blueDoor.transform.rotation = Quaternion.Euler(0, 0, 0);
        
        redDoor.transform.position = closeRed;
        redDoor.transform.rotation = Quaternion.Euler(0, 0, 0);
        
        yellowDoor.transform.position = closeYellow;
        yellowDoor.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
