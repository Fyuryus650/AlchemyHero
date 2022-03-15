using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundStopper : MonoBehaviour
{
    public AudioSource soundToStop;
    public List<GameObject> enemyList;
    private int i;

    private void Awake()
    {
        i = 0;
    }

    public void StartStopSound()
    {
        StartCoroutine(StopSound());
    }
    public IEnumerator StopSound()
    {
        enemyList[i] = GameObject.FindWithTag("Enemy");
        yield return new WaitForSeconds(1f);

        if (i <= 0)
        {
            soundToStop.enabled = false;
            StopAllCoroutines();
        }
    }
}
