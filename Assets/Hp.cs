using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{

    private float maxHealth = 100;
    private float currentHealth = 100;
    
    
    
    public Texture2D healthTexture;

    private float barWidth;
    private float barHeight;

    // Use this for initialization
    void Awake()
    {


        barHeight = Screen.height * 0.02f;
        barWidth = barHeight * 10.0f;

    }



    // Update is called once per frame
    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Screen.width - barWidth - 10,
                                 Screen.height - barHeight - 10,
                                 currentHealth * barWidth / maxHealth,
                                 barHeight),
                        healthTexture);
    }
}
    
