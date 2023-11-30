using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider other)
    
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if(controller.maxhealth < controller.maxhealth)
            {
                controller.Changhealth(1);
                Destroy(GameObject);


            }
        }
    }
}
