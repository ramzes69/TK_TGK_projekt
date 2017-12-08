using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{

    private float maxHealth = 100;
    private float currentHealth = 100;
    private float maxArmour = 100;
    private float currentArmour = 100;



    public Texture2D healthTexture;
    public Texture2D armourTexture;

    private float barWidth;
    private float barHeight;

    // Use this for initialization
    void Awake()
    {


        barHeight = Screen.height * 0.02f;
        barWidth = barHeight * 10.0f;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            takeHit(30);
        }
    }



    // Update is called once per frame
    private void OnGUI()
    {
        
    
    GUI.DrawTexture(new Rect(Screen.width - barWidth - 10,
     Screen.height - barHeight - 10,
     currentHealth* barWidth / maxHealth,
     barHeight),
	                healthTexture);
	GUI.DrawTexture(new Rect(Screen.width - barWidth - 10,
     Screen.height - barHeight* 2 - 20,
     currentArmour* barWidth / maxArmour,
     barHeight),
	                armourTexture);
    }

    void takeHit(float damage)
    {
        if (currentArmour > 0)
        {
            currentArmour -= damage;
            if (currentArmour < 0)
            {
                currentHealth += currentArmour;
                currentArmour = 0;
            }
        }
        else
        {
            currentHealth -= damage;
        }

        currentArmour = Mathf.Clamp(currentArmour, 0, maxArmour);
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }
}
    
