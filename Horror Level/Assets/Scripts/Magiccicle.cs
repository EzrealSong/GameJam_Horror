using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Magiccicle : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(KeyCollect.keys >= 3)
            {
                SceneManager.LoadScene("GameWin");
            }
        }
    }
   
   
}
