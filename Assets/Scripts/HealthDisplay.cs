using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    Text healthText;
    Player1 player;
    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
        player = FindObjectOfType<Player1>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = player.GetHealth().ToString();
    }
}
