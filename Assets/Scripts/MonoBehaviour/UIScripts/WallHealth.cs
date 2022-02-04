using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class WallHealth : MonoBehaviour
{
    public IntData healthData;
    public int health;
    public UnityEvent GameOver, UpdateSliderEvent;
    public bool underAttack = false;

    private void Awake()
    {
        healthData.value = 200;
    }

    private IEnumerator Damage()
    {
        while(underAttack == true)
        {
            yield return new WaitForSeconds(1f);

            health -= 10;
            healthData.value = health;
            UpdateSliderEvent.Invoke();

            if (health <= 0)
            {
                GameOver.Invoke();
                gameObject.SetActive(false);
                StopAllCoroutines();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.CompareTag("Enemy"))
        {
            underAttack = true;
            StartCoroutine(Damage());
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        underAttack = false;
        StopAllCoroutines();
    }
}
