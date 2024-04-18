using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class apple : MonoBehaviour
{
    private int apple_point = 0;
    [SerializeField] private TextMeshProUGUI appletext;
    [SerializeField] private AudioSource colltionsound;


    private void OnTriggerEnter2D(Collider2D collision){

        if (collision.gameObject.CompareTag("apple"))
        {
            colltionsound.Play();
            Destroy(collision.gameObject);
            apple_point++;
            appletext.text = "Apple :- " + apple_point;
        }

    }

}
