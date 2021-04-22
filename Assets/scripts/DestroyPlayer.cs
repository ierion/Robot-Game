using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;

public class DestroyPlayer : MonoBehaviour
{
    private const int timeout = 300;
    public ParticleSystem system1;
    public ParticleSystem system2;

    public Transform Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Playerman")
        {
            system1.Play();
            system2.Play();
            StartCoroutine(waiter());
        }
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(.1f);
        Vector3 vec = new Vector3(1.95f, 63.37f, 5.62f);
        for (int i = 0; i < 1000; i++)
        {
            Debug.Log(i);
            Player.position = vec;
            system1.Stop();
            system2.Stop();
        }
    }
}
