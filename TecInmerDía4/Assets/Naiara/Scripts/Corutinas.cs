using System.Collections;
using UnityEngine;

public class Corutinas : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Paso1");
        StartCoroutine(FuncionEjemplo());
        Debug.Log("Paso2");
        Invoke(nameof(FuncionInvocable), 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator FuncionEjemplo()
    {
        //yield return new WaitForSeconds(3f);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        Debug.Log("He entrado en la función");

    }

    private void FuncionInvocable()
    {
        Debug.Log("Hola");
    }
}
