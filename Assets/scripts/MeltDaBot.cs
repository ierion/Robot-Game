using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class MeltDaBot : MonoBehaviour
{

    [SerializeField] private Animator botMeltAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Playerman")
        {
            botMeltAnim.SetBool("melt", true);
        }
    }

}
