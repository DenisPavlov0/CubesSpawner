using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    
    public float _speed;
    public float _distance;
    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        transform.Translate(0, 0, _speed * Time.deltaTime);
        
        if (Vector3.Distance(transform.position, _startPosition) >= _distance)
        {
            Destroy(gameObject);
        }
    }
}
