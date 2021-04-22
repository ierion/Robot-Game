using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metdetector : MonoBehaviour
{

    private int meltcounter = 0;

    public int frozenrobotcount;

    [SerializeField] private Animator doorAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            meltcounter++;
            print("good, bery good, counter is equal to");
            print(meltcounter);
        }

        if (meltcounter == frozenrobotcount)
        {
            print("door open");
            doorAnim.SetBool("doorOpen", true);
        }

    }
}
