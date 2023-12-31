using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    private CharacterController cc;
    private float speed = 5f; // Karakterin hareket hızı
    private float jumpForce = 10f; // Karakterin zıplama kuvveti
    private float gravity = -9.81f; // Yerçekimi ivmesi
    private Vector3 velocity; // Karakterin hız vektörü

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Hareketi kontrol et
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = horizontal * Vector3.right + vertical * Vector3.forward; // Karakterin hareket yönü
        cc.SimpleMove(direction.normalized * speed); // Karakteri yatay olarak hareket ettir

        // Zıplamayı kontrol et
        if (cc.isGrounded && Input.GetButton("Jump")) // Karakter yerdeyse ve zıplama tuşuna basılıysa
        {
            velocity.y = jumpForce; // Karakterin y eksenindeki hızını zıplama kuvveti kadar arttır
        }
        velocity.y += gravity * Time.deltaTime; // Karakterin y eksenindeki hızını yerçekimi etkisiyle azalt
        cc.Move(velocity * Time.deltaTime); // Karakteri dikey olarak hareket ettir
    }
}
