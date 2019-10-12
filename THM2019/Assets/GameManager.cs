using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public float score=0;
    public static GameManager instance=null;
    public GameObject player;


    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    public void AddScore()
    {
        score++;
        scoreText.text = "Score :" + score;
        if (score >= 5)
        {
            scoreText.text = "You WIN!";

            Debug.Log("YOU WIN!!");
        }
    }
    public void Lose()
    {
        scoreText.text = "You Lose!";

        Debug.Log("You LOSE!");
        player.SetActive(false);
    }
}
