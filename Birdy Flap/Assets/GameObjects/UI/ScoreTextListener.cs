using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextListener : MonoBehaviour
{
    [SerializeField] private ScoreSetter _scoreSetter;
    void Start()
    {
        Text text = this.gameObject.GetComponent<Text>();
        _scoreSetter.addScoreText(text);
        Destroy(this);
    }
}
