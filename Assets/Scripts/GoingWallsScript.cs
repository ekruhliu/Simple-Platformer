using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoingWallsScript : MonoBehaviour
{
    private float step;

    private void Awake()
    {
        step = Random.Range(-0.05f, -0.15f);
    }

    void FixedUpdate()
    {
        transform.Translate(0, step, 0);
        if (transform.localPosition.y >= 2.420294f)
        {
            if (step > 0f)
                step = step * -1;
        }

        if (transform.localPosition.y <= -0.1987519f)
        {
            if (step < 0f)
                step = step * -1;
        }
    }
    
}
