
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
 class cameraflow : MonoBehaviour
{
    Transform alvo;
    public Vector3 offset;
    public int suavidade = 5;

    // Start is called before the first frame update
    void Start()
    {
        alvo = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - alvo.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posfinal = alvo.position + offset;
        transform.position = Vector3.Lerp(a: transform.position, b: posfinal, t: suavidade * Time.deltaTime);
    }
}
