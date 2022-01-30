using UnityEngine;

public class PotionThrower : MonoBehaviour
{
    public float rotSpeed;
    public GameObject projectile;
    public Vector3 playerPos;

    private void Awake()
    {
        playerPos = gameObject.transform.position;
    }
    public void TiltUp()
    {
        transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime);
    }

    public void TiltDown()
    {
        transform.Rotate(Vector3.forward * -rotSpeed * Time.deltaTime);
    }
}
