using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector3 cubeStartPosition = new Vector3(3,4,1);
    private Vector3 cubeScale = Vector3.one;
    public float cubeScaleMultiplier = 1.3f;
    public float cubeRotateX = 10.0f;

    public Color cubeColor = new Color(0.5f, 1.0f, 0.3f, 0.4f);

    void Start()
    {
        transform.position = cubeStartPosition;
        transform.localScale = cubeScale * cubeScaleMultiplier;
        
        Material material = Renderer.material;
        
        material.color = cubeColor;
    }
    
    void Update()
    {
        transform.Rotate(cubeRotateX * Time.deltaTime, 0.0f, 0.0f);
    }
}
