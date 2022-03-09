using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class healthcontrol : MonoBehaviour
{
    public bool GameLose = false;
    public int healthheart = 3;
    [SerializeField] private Image[] Hearts;

    private void Start()
    {
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        for(int i = 0; i < Hearts.Length; i++)
        {
            if(i<healthheart)
            {
                Hearts[i].color = Color.red;
            }
            else
            {
                Hearts[i].color = Color.black;
            }
        }
        if(healthheart <= 0)
        {
            GameLose = true;
            SceneManager.LoadScene("GameLose");
        }
    }

    

}
