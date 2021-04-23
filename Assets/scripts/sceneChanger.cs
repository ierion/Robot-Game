using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneChanger : MonoBehaviour
{

    public string nextLevel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Playerman")
        {
            print("something");
            Application.LoadLevel(nextLevel);
        }
    }
}
