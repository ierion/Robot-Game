using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terminalController : MonoBehaviour
{
    private bool cooldown = false;

    [SerializeField] private Animator platAnim;

    private bool tracker = false;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("e") && cooldown == false)
        {
            print("good job my dude you can touch the screen");
            cooldown = true;
            if (tracker)
            {
                platAnim.speed = 1;
                print(tracker.ToString());
                tracker = false;
            }
            else
            {
                platAnim.speed = 0;
                print(tracker.ToString());
                tracker = true;
            }
            StartCoroutine(waiter());
            
        }
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.3f);
        cooldown = false;
    }
}
