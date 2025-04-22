using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TICapalooza : MonoBehaviour
{
    public int entradaPlatea;
    public int entradaCampo;
    int recaudadoDePlatea = 0;
    int recaudadoDeCampo = 0;
    int recaudadoTotal = 0;


    // Start is called before the first frame update
    void Start()
    {
        if (entradaPlatea < 0 || entradaPlatea > 16200)
        {
            Debug.Log(" Error, el pedido no es valido, se ingresaron mas personas a la platea de las que se pueden");
            return;
        }
        else if (entradaCampo < 0 || entradaCampo > 20400)
        {
            Debug.Log("Error, el pedido no es valido, se ingresaron mas personas a campo de las que se puede");
            return;
        }

        recaudadoDeCampo = entradaCampo * 1200;
        recaudadoDePlatea = entradaPlatea * 2000;
        recaudadoTotal = recaudadoDeCampo + recaudadoDePlatea;

        Debug.Log(" La recaudacion de las entradas de campo fueron de " + recaudadoDeCampo);
        Debug.Log("La recaudacion de las entradas de platea fueron de " + recaudadoDePlatea);
        Debug.Log("La recaudacion de las entradas de platea fueron de " + recaudadoTotal);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
