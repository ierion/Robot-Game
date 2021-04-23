using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitch : MonoBehaviour
{

    public string nextLevel;
    public int secondsToWait;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(secondsToWait);
        Application.LoadLevel(nextLevel);
    }

}
