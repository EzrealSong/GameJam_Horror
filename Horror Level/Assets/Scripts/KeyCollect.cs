using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCollect : MonoBehaviour
{
    public static int keys = 0;
    void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 200, 40), "BOOKS: " + keys);
        if (keys >= 3)
        {
            GUI.Box(new Rect(20, 40, 200, 40), "Go to the second floor");
            GUI.Box(new Rect(20, 60, 200, 40), "Trigger the magic circle");
        }
    }

    
    
   
    
}