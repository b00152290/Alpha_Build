using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPower : MonoBehaviour
{

    public GameObject User;
    public ParticleSystem fireworksParticle;

    public void Update()
    {
        User = GameObject.Find("player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (User)
        {
            fireworks();
            lives.theHealth += 1;
            
        }
    }
    public void fireworks()
    {
        fireworksParticle.Play();
    }
}
