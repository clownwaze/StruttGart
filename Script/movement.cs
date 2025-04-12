using UnityEngine;

public class MovimentoSimples : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        if(input != 0)
        {
            transform.Translate(Vector2.right * input * speed * Time.deltaTime);
        }
    }
}
