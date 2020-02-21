using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Vector2 vel = Vector2.zero;
    public float speed = 0.5f;
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        processKeys();

        slowVelocity();
    }

    private void processKeys(){
        if(Input.GetKey(KeyCode.RightArrow)){
            vel.x += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            vel.x -= speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            vel.y += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            vel.y -= speed * Time.deltaTime;
        }
    }

    private void FixedUpdate() {
        rb.MovePosition(rb.position + (vel / 10));
    }

    private void slowVelocity(){
        if(vel.x > 0){
            vel.x -= Time.deltaTime;
        }
        if(vel.x < 0){
            vel.x += Time.deltaTime;
        }
        if(Mathf.Abs(vel.x) < 0.01f){
            vel.x = 0;
        }

        if(vel.y > 0){
            vel.y -= Time.deltaTime;
        }
        if(vel.y < 0){
            vel.y += Time.deltaTime;
        }
        if(Mathf.Abs(vel.y) < 0.01f){
            vel.y = 0;
        }
    }
}
