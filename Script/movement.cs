using UnityEngine;

public class MovimentoSimples : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.Translate(movement * speed * Time.deltaTime, 0, 0);
    }
}
