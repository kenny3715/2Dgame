using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class health1Controller : MonoBehaviour
{
    public playerController Player1;
    public Image health1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float healthPercentage = Player1.health / 100f;
        health1.fillAmount = healthPercentage;
    }
}
