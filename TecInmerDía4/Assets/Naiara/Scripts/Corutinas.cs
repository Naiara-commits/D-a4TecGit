using System.Collections;
using UnityEngine;

public class Corutinas : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Paso1");
        StartCoroutine(FuncionEjemplo());       //Empezar la corutina
        Debug.Log("Paso2");
        Invoke(nameof(FuncionInvocable), 2.0f);
        InvokeRepeating(nameof(FuncionInvocable),4.0f, 1.0f); //Primer tiempo y luego cada cuanto se repite por eso se hace el repeating
        Debug.Log("Paso3");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator FuncionEjemplo()
    {
        //yield return new WaitForSeconds(3f);          //Aqui esperas unos segundos
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));  //Aqui esperas a que le des al espacio
        CancelInvoke(nameof(FuncionInvocable));         //Para la invocación del "Hola"
        Debug.Log("He entrado en la función");

    }

    private void FuncionInvocable()
    {
        Debug.Log("Hola");
    }
}
