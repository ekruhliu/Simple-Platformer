using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTrigger : MonoBehaviour
{
    [SerializeField] private Vector3 pos1, pos2, nextPos;
    [SerializeField] private float speed;

    void FixedUpdate()
    {
        if (transform.position == pos1)
            nextPos = pos2;
        if (transform.position == pos2)
            nextPos = pos1;
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.fixedDeltaTime);
    }
}
