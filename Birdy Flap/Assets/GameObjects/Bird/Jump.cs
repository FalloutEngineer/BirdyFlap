using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Jump : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _bird;
    [SerializeField]
    private float _force;

    public UnityEvent JumpEvent;

    private void Start()
    {
        _force = 10;
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            _bird.velocity = Vector2.up * _force;
            JumpEvent.Invoke();
        }
    }
}
