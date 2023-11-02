using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkelPortal : MonoBehaviour
{
    public GameObject _iniSkeleton;
    public float _period;
    public Transform _portalPoint;


    // Update is called once per frame
    void Update()
    {
        _period = _period - Time.deltaTime;
        if (_period <= 0.0f)
        {
            _period = 1.0f;
            Instantiate(_iniSkeleton, _portalPoint.localPosition, _portalPoint.localRotation).SetActive(true);
            //_iniSkeleton.SetActive(true);
        }
    }
}
