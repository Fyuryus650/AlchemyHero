using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    public float speed = 3;
    public float health;
    public FloatData fireDmg, coldDmg, poisonDmg;
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if(health <= 0)
        {
            gameObject.transform.DetachChildren();
            gameObject.SetActive(false);
        }
    }
}
