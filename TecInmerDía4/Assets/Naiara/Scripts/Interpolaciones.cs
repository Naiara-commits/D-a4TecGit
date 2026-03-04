using UnityEngine;

public class Interpolaciones : MonoBehaviour
{
    [SerializeField] public GameObject cube;

    [SerializeField] public Vector3 intPos = Vector3.zero;
    [SerializeField] public Vector3 endPos = new Vector3(10, 0, 0);
    [SerializeField] public float moveDuration = 5.0f;
    [SerializeField] private float moveTimer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveTimer += Time.deltaTime;
        float t = moveTimer / moveDuration;
        cube.transform.position = Vector3.Lerp(intPos, endPos, t);
        
    }
}
