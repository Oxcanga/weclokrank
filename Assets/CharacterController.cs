using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private CharacterController cc;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Hareketi kontrol et
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        cc.Move(new Vector3(horizontal, 0, vertical) * Time.deltaTime);

        // Zıplamayı kontrol et
        if (Input.GetButton("Jump"))
        {
            cc.Jump();
        }
    }
}
