using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingPlatformScript : MonoBehaviour
{
    private float step = 5f;

    private bool playerHere;
    // Start is called before the first frame update DN - -2.96 UP 4.35
/*    void Start()
    {
        step = 5f;
    }*/

    // Update is called once per frame
    /*void FixedUpdate()
    {
        if (playerHere)
        {
            transform.Translate(0, step * Time.fixedDeltaTime, 0);
            if (transform.localPosition.y >= 4.35f)
            {
                if (step > 0f)
                    step = step * -1;
            }

            if (transform.localPosition.y <= -2.96f)
            {
                if (step < 0f)
                    step = step * -1;
            }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            playerHere = true;
    }*/

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            transform.Translate(0, step * Time.fixedDeltaTime, 0);
            if (transform.localPosition.y >= 4.35f)
            {
                if (step > 0f)
                    step = step * -1;
            }
            if (transform.localPosition.y <= -2.96f)
            {
                if (step < 0f)
                    step = step * -1;
            }
        }
    }
}
