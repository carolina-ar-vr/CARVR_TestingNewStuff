using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode] // This allows the script to run while in Edit mode. REALLY USEFUL!!!!!
public class healthBarScript : MonoBehaviour
{

    public Image healthBar; // Grabs the health bar.

    [Range(0, 1)]
    public float healthPercentage = 1f; // Preferred this way, so we can contorl a slider with health percentage :)

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = healthPercentage; // Updates the health bar.
    }
}
