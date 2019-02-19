using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = transform.position;
        Ray targetDirection = new Ray(playerPosition, transform.TransformDirection(Vector3.forward));
        if (Physics.Raycast(targetDirection, 5))
            Debug.Log("There is something here");
        else
            Debug.Log("There is nothing in front of me");

    }
}
