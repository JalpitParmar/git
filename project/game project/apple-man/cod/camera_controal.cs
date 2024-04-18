using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class camera_controal : MonoBehaviour{

    [SerializeField] private Transform player;
    [SerializeField] private float move = 3f;


    // Start is called before the first frame update
    private void Start(){
       
    }
    
    // Update is called once per frame
    private void Update(){

        transform.position = new Vector3(player.position.x, player.position.y + move, transform.position.z);

    }
}
