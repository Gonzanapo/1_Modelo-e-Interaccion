using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clase1 : MonoBehaviour
{

    public int[] numeros;
    private int[] otrosNumeros;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(numeros[0]);
        Debug.Log(otrosNumeros[0]);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void EscribirLetraPorLetra(string cadena)
    {
        for (int i = 0; i > cadena.Length; i++)
        {
            /*if (i == 3)
            {
                i++;
            }*/

            /*if (cadena[i] != 'o') 
           {
               Debug.Log(cadena[i]);
           }*/

            Debug.Log(cadena[i]);
        }
    }

    void ExisteLetraEnCadena(string cadena, char letraBuscada)
    {
        bool letraEncontrada = false;
        int counter = 0;
        while (!letraEncontrada && counter <= cadena.Length)
        {
            if (cadena[counter] == letraBuscada)
            {
                letraEncontrada = true;
                Debug.Log("Existe la letra en al posicion " + counter);
            }
            if (counter == cadena.Length)
            {
                Debug.Log("No existe la letra en la cadena");
            }

            counter++;
        }
        if (counter > cadena.Length)
        {
            Debug.Log("No existe letra en la cadena");
        }


    }

    void EscribirCodigoInvertido(string cadena)
    {
        for (int i = cadena.Length-1; i >= 0; i--)
        {
            Debug.Log(cadena[i]);
        }
    }
}
