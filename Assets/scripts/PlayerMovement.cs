using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("player & ground")]
    public Rigidbody rb;
    public Transform ground;
    [Space]
    [Header("speed settings")]
    public float speed = 4000f;
    public float sideWaysSpeed = 1000f;
    public float jumpHigh = 200f;
    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = true;

    }

    // Update is called once per frame

    // ? FixedUpdate() => Dipanggil pada interval waktu tetap yang disebut sebagai waktu "fixed" dalam game, biasanya digunakan untuk pembaruan fisika.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y <= ground.position.y)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        // if (Input.GetKeyDown(KeyCode.Space)) {
        //     rb.AddForce(Vector3.up * jumpHigh, ForceMode.VelocityChange);
        // }
    }
}
