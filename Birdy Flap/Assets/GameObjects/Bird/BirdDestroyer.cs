using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BirdDestroyer : MonoBehaviour
{
    [SerializeField]
    private GameObject _bird;

    public UnityEvent DeathEvent;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if((collision.gameObject.name == "LowerTube")|| (collision.gameObject.name == "UpperTube") || (collision.gameObject.name == "Ground"))
        {
            Destroy(_bird);
            DeathEvent.Invoke();
        }
    }
}
