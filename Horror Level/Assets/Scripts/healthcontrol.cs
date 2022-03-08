using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthcontrol : MonoBehaviour
{
    public bool GameLose = false;
    public int healthheart = 3;
    public void gamestateCheck()
    {
        if(healthheart <= 0)
        {
            GameLose = true;
        }
        else
            GameLose=false;
    }
}
