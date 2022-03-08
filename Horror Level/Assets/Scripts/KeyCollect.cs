using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCollect : MonoBehaviour
{
    public int keys;
    public GameObject scoreText;
    public GameObject winText;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Respawn" && gameOver == false)
        {
            keys = 0;
            scoreText.GetComponent<Text>().text = "Keys: " + keys;
        }
        if (Col.gameObject.tag == "Keys" && gameOver == false)
        {
            keys++;
            scoreText.GetComponent<Text>().text = "Keys: " + keys;
            //Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Win")
        {
            gameOver = true;
            scoreText.GetComponent<Text>().text = "";
            winText.GetComponent<Text>().text = "Congratulations You Got " + keys + " Keys(s)";
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}