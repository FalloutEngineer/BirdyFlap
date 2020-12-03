using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeGapDefiner : MonoBehaviour
{
    private float _tubeGap;

    [SerializeField]
    GameObject _upperTube;

    void Start()
    {
        _tubeGap = Random.Range(3.5f, 4.5f);
        _upperTube.transform.localPosition = _upperTube.transform.localPosition + new Vector3(0, _tubeGap, 0);
    }
}
