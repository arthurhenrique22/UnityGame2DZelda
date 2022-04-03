using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 10;
    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update() 
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.velocity = Vector2.up * speed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            rb.velocity = Vector2.down * speed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector2.left * speed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector2.right * speed * Time.deltaTime;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
        
    }
}
