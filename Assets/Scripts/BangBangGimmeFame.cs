using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangBangGimmeFame : MonoBehaviour
{
    public GameObject _cubek;
    public Transform _startPoint;
    //public GameObject _point;
    
    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log(message: $"{gameObject.name} collided with {other.gameObject.name}");
        //gameObject.SetActive(false);
        Destroy(gameObject);


        //_point = Instantiate(_cubek, _startPoint);
        var point = Instantiate(_cubek, _startPoint.localPosition, _startPoint.localRotation);
        point.SetActive(true);

    }

}
