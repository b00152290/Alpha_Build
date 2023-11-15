using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lives : MonoBehaviour
{
    public GameObject Healthbar;
    public static int theHealth;
    public GameOverx over;
    // Start is called before the first frame update
    void Start()
    {
        theHealth = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Healthbar.GetComponent<Text>().text = "Lives: " + theHealth;

        if (theHealth <= 0)
        {
            GameOverx.turnOn();
        }
    }
}
