using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _birdRigidBody;
    bool IsStarted { set => _birdRigidBody.IsAwake(); get => IsStarted; }
}
