using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;

public class followPlayer : MonoBehaviour
{

    public GameObject player;
    Vector3 offset = new Vector3(0, 8, -11);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position  = player.transform.position + offset;
    }
}
