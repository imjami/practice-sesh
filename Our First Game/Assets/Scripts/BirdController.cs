using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] float _flapStrength;

    UIManager manager;
    Rigidbody2D rb;
    bool _isJumping;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        manager = FindAnyObjectByType<UIManager>().GetComponent<UIManager>();
    }

    
    void Update()
    {
        JumpInput();
    }

    private void FixedUpdate()
    {
        if (_isJumping) Jump();
    }

    void JumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space)) _isJumping = true;
    }

    void Jump()
    {
        rb.velocity = Vector3.up * _flapStrength;
        _isJumping = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            manager.AddScore(1);
        }
    }

}
