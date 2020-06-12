using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class countdownManager : MonoBehaviour {
    public int timer = 30;
    public Text countDownTxt;
    // Use this for initialization
    void Start()
    {
        Invoke("Decreasetime", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        countDownTxt.text = timer.ToString();
    }
    public void Decreasetime()
    {
        if (timer > 0)
        {    
            timer--;
            Invoke("Decreasetime", 1f);
        }
        else
        {
            Debug.Log("GameOver");
            //Game over scene a ja
            SceneManager.LoadScene(2);
        }
    }
}
