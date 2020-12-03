using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnsleepBirdOnStart : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _birdRigidBody;

    public UnityEvent GameStartEvent;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {
                _birdRigidBody.WakeUp();
                Destroy(this);
                GameStartEvent.Invoke();
            }
        
    }
}
