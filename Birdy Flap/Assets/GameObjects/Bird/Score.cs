using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    

    [SerializeField] private ScoreSetter _scoreSetter;

    private int _score = 0;
    public int PublicScore => _score;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "ScoreTrigger")
        {
            _score++;
            _scoreSetter.setNewScore(_score);
        }
    }
}
