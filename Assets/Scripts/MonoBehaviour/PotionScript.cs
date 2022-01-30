using UnityEngine;
using System.Collections;

public class PotionScript : MonoBehaviour
{
    private SpriteRenderer image;
    public ColorData colorData;
    public float throwForce = 5;
    public float potionRot;
    private Rigidbody2D rgdBdy;
    public Transform startPoint;
    private Quaternion startRotation;
    public GameObject throwOrigin;
    private void Awake()
    {   
        image = gameObject.GetComponent<SpriteRenderer>();
        image.color = Color.white;
        gameObject.SetActive(false);
        rgdBdy = gameObject.GetComponent<Rigidbody2D>();
        rgdBdy.Sleep();
    }

    private IEnumerator Start()
    {
        rgdBdy.WakeUp();
        rgdBdy.AddForce(transform.right * throwForce, ForceMode2D.Impulse);

        yield return new WaitForSeconds(8f);

        gameObject.SetActive(false);
        StopAllCoroutines();
    }

    private void OnEnable()
    {
        image.color = colorData.finalColor;
        transform.position = startPoint.position;
        transform.rotation = throwOrigin.transform.rotation;
        StartCoroutine(Start());
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward, -1f);
    }

    public void Deactivate()
    {
        gameObject.SetActive(false);
        transform.position = startPoint.position;
        StopAllCoroutines();
    }
}
