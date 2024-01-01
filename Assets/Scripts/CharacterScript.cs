using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public float speed = 5f;
    public Camera camera;
    [SerializeField] private RuntimeAnimatorController animatorController; // AnimatorController nesnesini SerializeField olarak tanımladık

    private Animator animator; // Animator nesnesi ekledik

    void Start()
    {
        animator = GetComponent<Animator>(); // Animator nesnesini başlatıyoruz
        animator.runtimeAnimatorController = animatorController; // AnimatorController'ı atıyoruz
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical) * speed * Time.deltaTime;
        transform.Translate(movement);

        // Animasyonları kontrol ediyoruz
        if (horizontal != 0 || vertical != 0)
        {
            animator.SetBool("isMoving", true); // Eğer karakter hareket ediyorsa "isMoving" animasyonunu başlatıyoruz
        }
        else
        {
            animator.SetBool("isMoving", false); // Eğer karakter hareket etmiyorsa "isMoving" animasyonunu durduruyoruz
        }
    }
}
