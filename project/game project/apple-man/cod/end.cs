using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    private Animator ani;
    [SerializeField] private AudioSource wine;
    private bool level = false;

    private void Start()
    {
        wine = GetComponent<AudioSource>();
        ani = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player" && !level) {
        
        level = true;
        wine.Play();    
        ani.SetBool("end", true);
        Invoke("complit", 2f);
            
        }


    }
    
    private void complit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }

}
