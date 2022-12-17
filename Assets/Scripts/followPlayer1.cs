using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer1 : MonoBehaviour{
    public Transform player;
    private Rigidbody rb;
    private float moveSpeed = 5f;
    private Vector2 movement;
    
    void Start(){
        rb = this.GetComponent<Rigidbody>();
    }
    
    
    void Update(){
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
        
    }
    
    void MoveCharacter(Vector3 direction){
        rb.MovePosition((Vector3)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}