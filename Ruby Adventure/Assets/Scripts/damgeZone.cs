using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damgeZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        rubyController controller = other.GetComponent<rubyController>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}
