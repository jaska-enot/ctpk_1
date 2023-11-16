using System;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;

public class HeroActions : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private int banana = 0;
    private int watermelon = 0;
    


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<SimpleSkeletonActions>() != null)
        {
            Destroy(other.gameObject);
            if (other.gameObject.GetComponent<SimpleSkeletonActions>()._prize != null)
            {
                watermelon++;
                Debug.Log(message: $"У ТЕБЯ АРБУЗИКОВ ВОТ СТОЛЬКО - {watermelon} !");
            }
            if (other.gameObject.GetComponent<SimpleSkeletonActions>()._punishment != null)
            {
                banana++;
                Debug.Log(message: $"У ТЕБЯ БАНАНЧИКОВ ВОТ СТОЛЬКО - {banana} !");
            }
        }
    }

    
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * (_speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back *  (_speed * Time.deltaTime));

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, 90.0f*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, -90.0f*Time.deltaTime);
        }

        
        
    }
    
}
