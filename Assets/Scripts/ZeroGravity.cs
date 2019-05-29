using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroGravity : MonoBehaviour
{
    private bool status = false;
    public float power = 1f;

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            status = true;
            foreach (Rigidbody r in GameObject.FindObjectsOfType<Rigidbody>())
            {
                r.useGravity = false;
                r.velocity = new Vector3(0f, 0f, 0f);
            }
            GameObject.FindObjectOfType<Floater>().power = 0f;
        }

        if (status)
        {
            foreach (Rigidbody r in GameObject.FindObjectsOfType<Rigidbody>())
            {
                r.AddForce(Vector3.up * power, ForceMode.Acceleration);
            }
        }
    }
}
