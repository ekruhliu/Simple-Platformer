using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(50f, other.GetComponent<Rigidbody2D>().velocity.y);
    }
}
