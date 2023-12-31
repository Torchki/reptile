using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
   private void OnCollisionEnter2D(Collision2D collision){
    
    if(collision.gameObject.tag != "Player" && collision.gameObject.tag != "Bullet") Destroy(gameObject);
    else{
        Collider2D thisCollider = GetComponent<Collider2D>();
        Collider2D otherCollider = collision.gameObject.GetComponent<Collider2D>();
        Physics2D.IgnoreCollision(thisCollider, otherCollider);
    } 
   }
}
