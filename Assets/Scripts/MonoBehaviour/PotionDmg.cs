using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class PotionDmg : MonoBehaviour
{
    public ColorData colorData;
    public FloatData poisonDmg, coldDmg, fireDmg;
    private SpriteRenderer spriteColor;
    private Rigidbody2D rb2D;
    public float damageTime = 5f;
    private WaitForSeconds wfsObj;
    public Transform startPoint;


    private void Awake()
    {
        wfsObj = new WaitForSeconds(damageTime);
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        spriteColor = gameObject.GetComponent<SpriteRenderer>();
        spriteColor.color = Color.white;
        gameObject.tag = "potion juice";
        rb2D.Sleep();
        gameObject.SetActive(false);
    }

    private IEnumerator Start()
    {
        float randomDirection = Random.Range(-1000, 1000);
        float randomForce = Random.Range(.001f, .01f);
        rb2D.WakeUp();
        rb2D.velocity = new Vector2(randomDirection,randomDirection) *  randomForce;
        yield return wfsObj;
        gameObject.SetActive(false);
        StopAllCoroutines();
        rb2D.Sleep();
    }
    private IEnumerator CollisonStart()
    {
        yield return wfsObj;

        gameObject.transform.SetParent(null);
        gameObject.SetActive(false);
        rb2D.Sleep();
        StopAllCoroutines();
    }

    private void OnEnable()
    {
        spriteColor.color = colorData.finalColor;
        transform.position = startPoint.transform.position;
        StartCoroutine(Start());
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if(!collidedObject.CompareTag("potion juice"))
        {
            gameObject.transform.SetParent(collidedObject.transform);
            StartCoroutine(CollisonStart());
        }
    }

    private void OnDisable()
    {
        rb2D.Sleep();
    }
}
