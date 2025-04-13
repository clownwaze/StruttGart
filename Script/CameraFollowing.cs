using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    public Transform player; // Referência ao transform do player

    private void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
