using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
   public int damage;
   public string _tag;
   private void OnTriggerEnter(Collider other)
   {
      bool hit = other.CompareTag(_tag);
      if (hit)
      {
         
      }
   }
}
