using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripts : MonoBehaviour
{
    void Start()
    {
        ImprimirResultado();
    }

    void ImprimirResultado()
    {
        for (int i = 1; i <= 1000; i++)
        {
            Resultado($"{i} {EsParOImpar(i)}");
        }
    }

    void Resultado(string mensaje)
    {
        print(mensaje);
    }

    string EsParOImpar(int numero)
    {
        return (numero % 2 == 0) ? "par" : "impar";
    }
}
