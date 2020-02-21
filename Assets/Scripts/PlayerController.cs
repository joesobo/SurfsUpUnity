using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Vector2 vel = Vector2.zero;
    [SerializeField]
    private Vector2 pos;
    public float speed = 0.5f;

    private void Start() {
        pos = this.transform.position;
    }

    private void Update() {
        processKeys();

        setLocation();
    }

    private void processKeys(){
        if(Input.GetKey(KeyCode.RightArrow)){
            vel.x += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            vel.x -= speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            vel.y += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            vel.y -= speed * Time.deltaTime;
        }
    }

    private void setLocation(){
        if(vel.x > 0){
            pos.x += vel.x / 10;
            vel.x -= Time.deltaTime;
        }
        if(vel.x < 0){
            pos.x += vel.x / 10;
            vel.x += Time.deltaTime;
        }
        if(Mathf.Abs(vel.x) < 0.01f){
            vel.x = 0;
        }

        if(vel.y > 0){
            pos.y -= vel.y / 10;
            vel.y -= Time.deltaTime;
        }
        if(vel.y < 0){
            pos.y -= vel.y / 10;
            vel.y += Time.deltaTime;
        }
        if(Mathf.Abs(vel.y) < 0.01f){
            vel.y = 0;
        }

        this.transform.position = pos;
    }
}
