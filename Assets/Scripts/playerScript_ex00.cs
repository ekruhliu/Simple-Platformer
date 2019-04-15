using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class playerScript_ex00 : MonoBehaviour
{
    public float[] speed;
    [SerializeField] private int person;

    public float[] jumpForce;
    [SerializeField]private float[] maxSpeed;

    [SerializeField]private bool[] isGround;

    [SerializeField] private GameObject[] players;

    private void FixedUpdate()
    {
        Grounded();
    }
    private void Update()
    {
        Person();
        if (Input.GetButton("Horizontal")) Moves();
        if (isGround[person] && Input.GetButton("Jump")) Jump();
        if (Input.GetKey(KeyCode.R))
            Application.LoadLevel(Application.loadedLevel);
    }

    private void Moves()
    {
        float moveX = Input.GetAxis("Horizontal");

        players[person].GetComponent<Rigidbody2D>().AddForce(new Vector2(speed[person] * moveX, 0),ForceMode2D.Force);
        if (players[person].GetComponent<Rigidbody2D>().velocity.x > maxSpeed[person])
            players[person].GetComponent<Rigidbody2D>().velocity = new Vector2(maxSpeed[person], players[person].GetComponent<Rigidbody2D>().velocity.y);
        if (players[person].GetComponent<Rigidbody2D>().velocity.x < maxSpeed[person] * -1)
            players[person].GetComponent<Rigidbody2D>().velocity = new Vector2(maxSpeed[person] * -1, players[person].GetComponent<Rigidbody2D>().velocity.y);
    }

    private void Jump()
    {
        isGround[person] = false;
        players[person].GetComponent<Rigidbody2D>().AddForce(players[person].transform.up * jumpForce[person], ForceMode2D.Impulse);
    }

    private void Grounded()
    {
        if (players[person].GetComponent<Rigidbody2D>().velocity.y == 0.0f)
            isGround[person] = true;
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
