using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSkeletonDeath : MonoBehaviour
{
    public GameObject _prize;
    public GameObject _punishment;
    public Transform _stockPoint;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<HeroHit>() != null)
        {
            if (_prize != null)
            {
                Instantiate(_prize, _stockPoint.localPosition, _stockPoint.localRotation).SetActive(true);

            }
            if (_prize == null)
            {
                Instantiate(_punishment, transform.localPosition, transform.localRotation).SetActive(true);

            }
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
