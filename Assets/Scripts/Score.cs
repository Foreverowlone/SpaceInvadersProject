using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    private int PlayerScore = 0;
    private int hScore = 0;
    public Text pScore;
    public Text hText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pScore.text = PlayerScore.ToString("D4");
        hText.text = hScore.ToString("D4");

        if (PlayerScore < 100)
        {
            pScore.text = PlayerScore.ToString();
        }
        else
        {
            pScore.text = PlayerScore.ToString();
            pScore.GetComponent<Text>().color = Color.red;
        }
        if (PlayerScore > hScore)
        {
            hScore = PlayerScore;
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

    public void setHScore(int h)
    {
        hScore = h;
    }

    public int getHScore()
    {
        return hScore;
    }
}
