using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    static public bool IsGameOver {  get; set; }
    float xBound = -12.5f;

    // Update is called once per frame
    void Update()
    {
        if (!IsGameOver)
        {
            transform.position += Vector3.left * _moveSpeed * Time.deltaTime;
            if (transform.position.x < xBound) Destroy(gameObject);
        }
    }

    
}
