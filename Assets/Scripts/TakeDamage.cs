using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
   private int _health;
   public int damage = 10;
   public int maxHealth = 100;
   public string _tag;

   private void Start()
   {
      _health = maxHealth;
   }
   private void OnCollisionEnter(Collision other)
   {
     bool hit = other.collider.CompareTag(_tag);
     if (hit)
     {
        _health -= damage;
        Debug.Log(_health);
        ONDeath();
     }
   }
   private void ONDeath()
   {
      if (_health <= 0)
      {
         Destroy(gameObject);
         Debug.Log("You are dead!");
      }
   }
}
