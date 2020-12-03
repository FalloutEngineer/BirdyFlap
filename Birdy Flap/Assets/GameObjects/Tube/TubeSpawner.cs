using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TubeSpawner : MonoBehaviour
{
    private float _secondsBetweenTubes = 3;
    private float _timeElapsed = 0f;

    [SerializeField] private GameObject _tube;

    private bool _isGameStarted = false;

    public void activateSpawner()
    {
        _isGameStarted = true;
    }

    public void deactivateSpawner()
    {
        _isGameStarted = false;
    }

    void Update()
    {
        if (_isGameStarted)
        {
            _timeElapsed += Time.deltaTime;

            if (_timeElapsed >= _secondsBetweenTubes)
            {
                _timeElapsed = 0f;

                Vector2 spawnPos = new Vector2(1.726208f, Random.Range(-4.2f, 2.2f));

                GameObject tube = (GameObject)Instantiate(_tube, spawnPos, new Quaternion(0, 0, 0, 0));

                _secondsBetweenTubes = Random.Range(2.3f, 4.5f);
            }
        }
    }
}
