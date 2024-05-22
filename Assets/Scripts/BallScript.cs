using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] private AudioClip winSoundClip;

    public Rigidbody2D myRigidbody;
    public LogicScript logic;
    public bool isCollided;

    private AudioSource audioSource;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = winSoundClip;

    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Finish")
        {isCollided = true;
        audioSource.Play();
        logic.gameWon();}
    }
}
