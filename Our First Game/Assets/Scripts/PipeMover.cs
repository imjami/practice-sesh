using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    float xBound = -12.5f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _moveSpeed * Time.deltaTime;
        if (transform.position.x < xBound) Destroy(gameObject);
    }

    
}
