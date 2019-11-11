using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "Bullet_45mm_Bullet(Clone)")
        { // shot by bullet
            FindObjectOfType<AudioManager>().Play("Explosion");
            GameObject.Find("Explosion Particle").transform.position = transform.position;
            GameObject.Find("Explosion Particle").gameObject.GetComponent< ParticleSystem>().Play();
            FindObjectOfType<ScoreCanvas>().Score += 1;
            FindObjectOfType<ScoreCanvas>().UpdateScore();
            GameObject.Find("Score Canvas").GetComponent<Animator>().SetTrigger("AddScore");
            Destroy(transform.parent.gameObject);
        } else if (col.collider.name == "Plane")
        { // hit ground
            FindObjectOfType<AudioManager>().Play("Metal");
            FindObjectOfType<ScoreCanvas>().Score -= 1;
            FindObjectOfType<ScoreCanvas>().UpdateScore();
            Destroy(transform.parent.gameObject);
        } else
        { // cubes collide each other
            FindObjectOfType<AudioManager>().Play("Metal");
        }
    }
}
