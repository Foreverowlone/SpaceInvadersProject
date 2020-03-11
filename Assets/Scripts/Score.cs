using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    private int PlayerScore = 0;
    public Text pScore;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerScore < 100)
        {
            pScore.text = PlayerScore.ToString();
        }
        else
        {
            pScore.text = PlayerScore.ToString();
            pScore.GetComponent<Text>().color = Color.red;
        }
    }

    public void setPlayerScore(int pScore)
    {
        PlayerScore = pScore;
    }

    public int getPlayerScore()
    {
        return PlayerScore;
    }
}
