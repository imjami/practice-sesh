using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCollision : MonoBehaviour
{
    static public bool IsGameOver { get; private set; }

    void Start()
    {
        IsGameOver = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            IsGameOver = true;
        }
    }
}
