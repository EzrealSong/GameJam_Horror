using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public Text result;
    public void Setup(string msg)
    {
        gameObject.SetActive(true);
        result.text = msg;
    }
}
