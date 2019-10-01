using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerControllerLAN : NetworkBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (isLocalPlayer)
        {
            var h = Input.GetAxis("Horizontal");

            transform.Translate(Vector3.right * (h * Time.deltaTime));
        }
    }
}