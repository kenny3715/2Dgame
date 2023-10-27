using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class health2Controller : MonoBehaviour
{
    public player2Controller Player2;
    public Image health2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float healthPercentage = Player2.health / 100f;
        health2.fillAmount = healthPercentage;
    }
}
