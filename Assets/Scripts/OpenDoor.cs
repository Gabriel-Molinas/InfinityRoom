using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator Ani;
    public static bool offOn;

     void Update()
    {
        if (offOn == false)
        {
            Ani.SetBool("Open", false);
        }   
    }

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, fwd, out hit, 2))
            if(hit.collider.tag == "Door")
            {
                offOn = true;
                Ani.SetBool("Open", true);
            }
    }
}
