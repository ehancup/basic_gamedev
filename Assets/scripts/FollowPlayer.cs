using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [Header("Tranform")]
    public Transform playerTransform;
    [Space]

    [Header("camera gap vector")]
    public Vector3 cameraOffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + cameraOffset;
    }
}
