using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DroneController : MonoBehaviour
{

    public Camera camera;
    public NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 - left mouse click
        {
            //creating ray
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Debug.Log("leftclick");

            if (Physics.Raycast(ray, out hit)) //if hit detected, true
            {
                Debug.Log("true");
                //move
                agent.SetDestination(hit.point);
            }


        }
    }
}
