using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSetter : MonoBehaviour
{
    private List<Text> textList = new List<Text>();

    public void addScoreText(Text t)
    {
        textList.Add(t);
    }

    public void setNewScore(int score)
    {
        foreach(Text t in textList){
            t.text = score.ToString();
        }
    }
}
