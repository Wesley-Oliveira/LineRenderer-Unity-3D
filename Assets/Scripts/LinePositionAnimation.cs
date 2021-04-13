using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinePositionAnimation : MonoBehaviour
{
    public LineRenderer line;

    [Header("Variáveis de Onda")]
    [Tooltip("Comprimento da linha no eixo Z")]
    public float length;
    [Tooltip("Altura da onda senoidal")]
    public float height;
    [Tooltip("Frequência de ondas")]
    public float frequency;
    [Tooltip("Velocidade das ondas")]
    public float speed;

    // Update is called once per frame
    void Update()
    {
        for(var i = 0; i < line.positionCount; i++)
        {
            float z = ((float)(i + 1) / line.positionCount) * length;
            float y = Mathf.Sin((z * frequency) + (Time.time * speed)) * height;
            line.SetPosition(i, new Vector3(0, y, z));
        }
    }
}
