using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationScript : MonoBehaviour
{
    [SerializeField] private GameObject target;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            other.transform.position = new Vector3(target.transform.position.x, target.transform.position.y, other.transform.position.z);
    }
}
