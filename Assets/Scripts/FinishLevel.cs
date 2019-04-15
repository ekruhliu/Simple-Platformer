using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    [SerializeField] private GameObject[] players;
    [SerializeField] private int[] finishPosition;
    [SerializeField] private string activeScene;
    
    void FixedUpdate()
    {
        activeScene = SceneManager.GetActiveScene().name;
        if (activeScene.Equals("ex00"))
        {
            if ((players[0].transform.localPosition.y <= -1.062528f &&
                 players[0].transform.localPosition.y >= -1.075528) &&
                (players[0].transform.localPosition.x >= 23.195f && players[0].transform.localPosition.x <= 23.26f))
                finishPosition[0] = 1;
            else
                finishPosition[0] = 0;
            if ((players[1].transform.localPosition.y <= -2.734857f &&
                 players[1].transform.localPosition.y >= -2.854857f) &&
                (players[1].transform.localPosition.x >= 23.23f && players[1].transform.localPosition.x <= 23.30f))
                finishPosition[1] = 1;
            else
                finishPosition[1] = 0;
            if ((players[2].transform.localPosition.y >= 1.182066f &&
                 players[2].transform.localPosition.y <= 1.195066f) &&
                (players[2].transform.localPosition.x >= 23.19f && players[2].transform.localPosition.x <= 23.23f))
                finishPosition[2] = 1;
            else
                finishPosition[2] = 0;

            if (finishPosition[0] == 1 && finishPosition[1] == 1 && finishPosition[2] == 1)
            {
                finishPosition[0] = 0;
                finishPosition[1] = 0;
                finishPosition[2] = 0;
                Application.LoadLevel("ex01");
            }
        }
        if (activeScene.Equals("ex01"))
        {
            if ((players[0].transform.localPosition.y <= -16.34071f &&
                 players[0].transform.localPosition.y >= -16.36071f) &&
                (players[0].transform.localPosition.x <= -26.76f && players[0].transform.localPosition.x >= -26.83f))
                finishPosition[0] = 1;
            else
                finishPosition[0] = 0;
            if ((players[1].transform.localPosition.y <= -18.10267f &&
                 players[1].transform.localPosition.y >= -18.12267f) &&
                (players[1].transform.localPosition.x <= -26.73f && players[1].transform.localPosition.x >= -26.79f))
                finishPosition[1] = 1;
            else
                finishPosition[1] = 0;
            if ((players[2].transform.localPosition.y <= -14.06f &&
                 players[2].transform.localPosition.y >= -14.09f) &&
                (players[2].transform.localPosition.x <= -26.78f && players[2].transform.localPosition.x >= -26.82f))
                finishPosition[2] = 1;
            else
                finishPosition[2] = 0;
            if (finishPosition[0] == 1 && finishPosition[1] == 1 && finishPosition[2] == 1)
            {
                finishPosition[0] = 0;
                finishPosition[1] = 0;
                finishPosition[2] = 0;
                Application.LoadLevel("ex02");
            }
        }

        if (activeScene.Equals("ex02"))
        {
            if ((players[0].transform.localPosition.y <= -30.8f &&
                 players[0].transform.localPosition.y >= -31f) &&
                (players[0].transform.localPosition.x <= -6.255f && players[0].transform.localPosition.x >= -6.32f))
                finishPosition[0] = 1;
            else
                finishPosition[0] = 0;
            if ((players[1].transform.localPosition.y <= -32.5f &&
                 players[1].transform.localPosition.y >= -32.7f) &&
                (players[1].transform.localPosition.x <= -6.22f && players[1].transform.localPosition.x >= -6.29f))
                finishPosition[1] = 1;
            else
                finishPosition[1] = 0;
            if ((players[2].transform.localPosition.y <= -28.6f &&
                 players[2].transform.localPosition.y >= -28.7f) &&
                (players[2].transform.localPosition.x <= -6.27f && players[2].transform.localPosition.x >= -6.308f))
                finishPosition[2] = 1;
            else
                finishPosition[2] = 0;
            if (finishPosition[0] == 1 && finishPosition[1] == 1 && finishPosition[2] == 1)
            {
                finishPosition[0] = 0;
                finishPosition[1] = 0;
                finishPosition[2] = 0;
                Application.LoadLevel("ex03");
            }
        }
        
        if (activeScene.Equals("ex03"))
        {
            if ((players[0].transform.localPosition.y <= -19.5f &&
                 players[0].transform.localPosition.y >= -19.6f) &&
                (players[0].transform.localPosition.x <= -14.7f && players[0].transform.localPosition.x >= -14.75f))
                finishPosition[0] = 1;
            else
                finishPosition[0] = 0;
            if ((players[1].transform.localPosition.y <= -21.31f &&
                 players[1].transform.localPosition.y >= -21.32f) &&
                (players[1].transform.localPosition.x <= -14.66f && players[1].transform.localPosition.x >= -14.72f))
                finishPosition[1] = 1;
            else
                finishPosition[1] = 0;
            if ((players[2].transform.localPosition.y <= -17.28f &&
                 players[2].transform.localPosition.y >= -17.29f) &&
                (players[2].transform.localPosition.x <= -14.72f && players[2].transform.localPosition.x >= -14.74f))
                finishPosition[2] = 1;
            else
                finishPosition[2] = 0;
            if (finishPosition[0] == 1 && finishPosition[1] == 1 && finishPosition[2] == 1)
            {
                finishPosition[0] = 0;
                finishPosition[1] = 0;
                finishPosition[2] = 0;
                Application.LoadLevel("ex00");
            }
        }
    }
}
