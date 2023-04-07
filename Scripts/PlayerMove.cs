using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PlayerMove : MonoBehaviour

{
    public Camera camera;
    private Rigidbody player;
    int hitPoints = 3;
    public AudioSource takesHit;
    // Start is called before the first frame update
  
    void Start()
    {
        takesHit.volume = 0;
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h =Input.GetAxis("Horizontal")*10;
        float v = Input.GetAxis("Vertical")*10;

        Vector3 vel =player.velocity ;
        vel.x=h;
        vel.z=v;
        player.velocity=vel;
        //player.AddRelativeForce(vel);
        transform.rotation = camera.transform.rotation;
        //transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Support" || collision.gameObject.tag == "Enemy")
        {
            takesHit.volume = .5f;
            takesHit.Play();
            if (hitPoints > 1)
            {
                // make color red for a split second
                --hitPoints;
            }
            else
            {
                Die();
                SceneManager.LoadScene("GameOver");//load game over scene

            }

        }

    }
    public int getLife()
    {
        return hitPoints;
    }
    private void Die()
    {
        Destroy(this.gameObject);
    }
}
