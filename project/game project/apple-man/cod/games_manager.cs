using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class games_manager : MonoBehaviour
{

    private Animator anim;
    private Rigidbody2D rb;
    [SerializeField] private AudioSource dathesound;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();       
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            die();
            dathesound.Play();
        }

    }
    private void die()
    {
        anim.SetTrigger("dathe");
        rb.bodyType =  RigidbodyType2D.Static;
        

    }
    private void Resetlevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
