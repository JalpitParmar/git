using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class sticki_paltfrom : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
    
        if (collision.gameObject.name == "player")
        {

            collision.gameObject.transform.SetParent(transform);
           

        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player")
        {

            collision.gameObject.transform.SetParent(null);
            

        }
        
    }


    
   
}
