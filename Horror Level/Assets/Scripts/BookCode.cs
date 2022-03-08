using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCode : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnTriggerEnter()
    {
        KeyCollect.keys += 1;
        Destroy(gameObject);

        
    }
}
