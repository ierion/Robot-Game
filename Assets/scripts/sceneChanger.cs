using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneChanger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Playerman")
        {
            print("something");
            Application.LoadLevel("level2");
        }
    }
}
