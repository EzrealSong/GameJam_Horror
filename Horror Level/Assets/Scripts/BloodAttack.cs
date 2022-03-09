using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodAttack : MonoBehaviour
{
    [SerializeField] private healthcontrol hcontrol;
    [SerializeField] private int damage=1;
    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
           
            hcontrol.healthheart = hcontrol.healthheart - damage;
            hcontrol.UpdateHealth();
            Debug.Log("Attacked");
       }
        
    }

    
}
