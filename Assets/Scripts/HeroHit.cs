using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroHit : MonoBehaviour
{
    private const string tag = "Enemy";
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(tag))
        {

        }
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            var tmp = transform.position;
            tmp.z += 0.1f;
            transform.position = tmp;
        }
        if (Input.GetKey(KeyCode.S))
        {
            var tmp = transform.position;
            tmp.z -= 0.1f;
            transform.position = tmp;
        }
        if (Input.GetKey(KeyCode.A))
        {
            var tmp = transform.position;
            tmp.x -= 0.1f;
            transform.position = tmp;
        }
        if (Input.GetKey(KeyCode.D))
        {
            var tmp = transform.position;
            tmp.x += 0.1f;
            transform.position = tmp;
        }
        
    }
    
}
