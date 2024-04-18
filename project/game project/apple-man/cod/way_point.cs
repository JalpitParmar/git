using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class way_point : MonoBehaviour
{

    [SerializeField] private GameObject[] way_p;
    private int currentway_p = 0;

    [SerializeField] private float seepd = 2f;

    // Start is called before the first frame update
   private void Start()
    {
        


    }

    // Update is called once per frame
   private void Update()
    {

        if (Vector2.Distance(way_p[currentway_p].transform.position, transform.position)< .1f)
        {

            currentway_p++;

            if(currentway_p >= way_p.Length)
            {
                currentway_p = 0;
            }

        }

        transform.position = Vector2.MoveTowards(transform.position, way_p[currentway_p].transform.position, Time.deltaTime * seepd);

    }
}
