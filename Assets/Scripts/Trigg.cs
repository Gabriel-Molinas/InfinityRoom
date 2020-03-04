using UnityEngine;
using System.Collections;

public class Trigg : MonoBehaviour
{
    public CharacterController Player;
    public GameObject obj;

    Quaternion rotation = Quaternion.Euler(0, 90f, 0);


    void OnTriggerEnter(Collider other)
    {
        Debug.Log(obj.transform.rotation);
        Debug.Log(":");
        if (other.tag == "Player")
        {
            Player.GetComponent<CharacterController>().enabled = false;
            Player.transform.SetPositionAndRotation(new Vector3(obj.transform.position.x, 1.1551f, obj.transform.position.z), Player.transform.rotation * rotation);
            OpenDoor.offOn = false; 
            Player.GetComponent<CharacterController>().enabled = true;
        }
    }
}
