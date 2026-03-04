using System.Collections;
using UnityEditor;
using UnityEngine;

public class Entero : MonoBehaviour
{
    [SerializeField] public GameObject cuboPrefab;
    [SerializeField] public Vector3 intPos = new Vector3(0, 0, 0);
    [SerializeField] public Vector3 endPos = new Vector3(10, 0, 0);

    [SerializeField] public float moveDuration = 5.0f;
    [SerializeField] public float moveTimer = 0f;

    [SerializeField] public Vector3 intRot = Vector3.zero;
    [SerializeField] public Vector3 endPosRot = new Vector3(0, 100, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(cuboPrefab, intPos,Quaternion.identity);
        //StartCoroutine(FuncionMovimiento());
        //StartCoroutine(FuncionRotacion());
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetKeyDown(KeyCode.E){
            //cuboPrefab = GameObject.CreatePrimitive(Primitive)
        }
        

    }

    /*private IEnumerator FuncionMovimiento()
    {
        moveTimer += Time.deltaTime;
        float t = moveTimer / moveDuration;

        cuboPrefab.transform.position = Vector3.Lerp(intPos, endPos, t);
        yield return new WaitForSeconds(1f);

    }
    private IEnumerator FuncionRotacion()
    {
        cuboPrefab.transform.rotation = Quaternion.Slerp(Quaternion.Euler(intRot), Quaternion.Euler(endPosRot), t);

        yield return new WaitForSeconds(1f);

    }*/
}
