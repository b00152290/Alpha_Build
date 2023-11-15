using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public GameObject User;
    public GameOverx tisOver;
    public int damage = 1;
    public ParticleSystem explosionParticle;

    public void Update()
    {
        User = GameObject.Find("player");
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == User)
        {
            bomb();
            lives.theHealth -= damage;
            
        }
    }
    public void bomb()
    {
        explosionParticle.Play();
    }

}
