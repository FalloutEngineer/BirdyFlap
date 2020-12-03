using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeMovement : MonoBehaviour
{
    [SerializeField] private GameObject _tube;

    private float _speed = 40f;

    void Update()
    {
        _tube.transform.position = _tube.transform.position + new Vector3(-0.1f, 0, 0) * Time.deltaTime * _speed;
        
    }
}
