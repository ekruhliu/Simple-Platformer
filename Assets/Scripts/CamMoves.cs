using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMoves : MonoBehaviour
{
    private int person;
    public GameObject[] players;
    // Update is called once per frame
    void Start()
    {
        person = 0;
    }
    void Update()
    {
        Person();
        transform.position = new Vector3(players[person].transform.position.x, players[person].transform.position.y + 2f, -10f);
    }
    void Person()
    {
        if (Input.GetKeyDown("1"))
            person = 0;
        if (Input.GetKeyDown("2"))
            person = 1;
        if (Input.GetKeyDown("3"))
            person = 2;
    }
}
