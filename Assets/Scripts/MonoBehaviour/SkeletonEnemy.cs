using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class SkeletonEnemy : EnemyBase
{
    public GameObject spawnPos;
    public UnityEvent OnDisableEvent;

    IEnumerator Damage()
    {
        yield return new WaitForSeconds(1f);
        health = health - (coldDmg.value * .25f) - (fireDmg.value * 2) - (poisonDmg.value * 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject obj = collision.gameObject;

        if(obj.CompareTag("potion juice"))
        {
            StartCoroutine(Damage());
        }
    }

    private void OnEnable()
    {
        transform.position = spawnPos.transform.position;
        health = 120;
    }

    public void OnDisable()
    {
        OnDisableEvent.Invoke();
        StopAllCoroutines();
    }
}
