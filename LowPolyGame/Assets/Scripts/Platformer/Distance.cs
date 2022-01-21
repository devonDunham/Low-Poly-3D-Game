using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public Text disanceText;
    PlatformerPlayerController player;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlatformerPlayerController>();
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        DistanceControl();
    }

    void DistanceControl()
    {
        if (!player)
            return;

        if (player.isMovingRight)
        {
            timer += Time.deltaTime / 1.5f; // making it go slower
            disanceText.text = "Distance: " + (Mathf.Round(timer * 100) * 0.01f).ToString("f2") + " Meters"; // two decimal places
        }
        else if (player.isMovingLeft)
        {
            timer -= Time.deltaTime / 1.5f; // making it go slower
            disanceText.text = "Distance: " + (Mathf.Round(timer * 100) * 0.01f).ToString("f2") + " Meters"; // two decimal places
        }
    }
}
