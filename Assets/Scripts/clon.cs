using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clon : MonoBehaviour
{
    public Transform Same;
    public CharacterController Controller;
    public float speed = 12f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(0,0, -Same.position.x-6f);
        Controller.transform.position = move;
    }
}
