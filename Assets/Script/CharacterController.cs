using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 5f;
    public Camera camera;
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical) * speed * Time.deltaTime;
        transform.Translate(movement);
        
    }
}
