using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaPlanetario : MonoBehaviour
{
    public Transform tierra;
    public Transform Luna;

    public float rotacionT = 30;
    public float distanciaT = 5;
    public float escalaT = 0.5f;

    public float rotacionL = 60;
    public float distanciaL = 2;
    public float escalaL = 0.3f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Matrix4x4 MSol = transform.localToWorldMatrix;

        Matrix4x4 MTierra = MSol * Matrix4x4.Rotate(Quaternion.Euler(0, 0, rotacionT)) * Matrix4x4.Translate(new Vector3(distanciaT, 0, 0)) * Matrix4x4.Scale(new Vector3(escalaT, escalaT, 1));

        tierra.position = MTierra.MultiplyPoint(Vector3.zero);
        tierra.localScale = MTierra.lossyScale;

        Matrix4x4 MLuna = MTierra * Matrix4x4.Rotate(Quaternion.Euler(0, 0, rotacionL)) * Matrix4x4.Translate(new Vector3(distanciaL, 0, 0)) * Matrix4x4.Scale(new Vector3(escalaL, escalaL, 1));

        Luna.position = MLuna.MultiplyPoint(Vector3.zero);
        Luna.localScale = MLuna.lossyScale;

    }
}
