using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class SimpleSkeletonActions : MonoBehaviour
{
    public  GameObject _prize;
    public GameObject _punishment;
    [SerializeField] private Transform _stockPoint;
    [SerializeField] private float rotateSpeed;

    private void Update()
    {
        transform.Translate(Vector3.forward  * Time.deltaTime);
        
        rotateSpeed = rotateSpeed - Time.deltaTime;
        if (rotateSpeed <= 0)
        {
            if (Random.value < 0.3f)
            {
                transform.Rotate(Vector3.up, Random.Range(10,90));
                rotateSpeed = 2.0f;
            }
        }
    }


    private void OnDestroy()
    {
        if (_prize != null)
            {
                Instantiate(_prize, _stockPoint.localPosition, _stockPoint.localRotation).SetActive(true);

            }
        if (_punishment != null)
            {
                Instantiate(_punishment, transform.localPosition, transform.localRotation).SetActive(true);

            }
    }
}
