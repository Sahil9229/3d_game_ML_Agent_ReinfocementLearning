﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_scpt : MonoBehaviour
{
   
  // [SerializeFeild]
   private int maxHealth = 100;
   
   
   private int currentHealth;

  // public event Action<float> OnHealthPctChanged = delegate { };
   
   private void OnEnable()
   {
     currentHealth = maxHealth;


   }

   public void ModifyHealth(int amount )
   {
     currentHealth += amount;
     float currentHealthPct = (float)currentHealth / (float)maxHealth;
     //OnHealthPctChanged(currentHealth);

   }
   
   
   
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
         ModifyHealth(-10);
    }
}
