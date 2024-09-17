using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;
public class player : MonoBehaviour
{
    public int velocidade = 10;
    public int forcePulo = 10;
    public bool chao = false;

    private Rigidbody rb;

    private AudioSource _source;
    // Start is called before the first frame update
    void Start()
    {
      TryGetComponent(out rb);
      TryGetComponent(out _source);
      Debug.Log(message: "START");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "chao")
        {
            chao = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
float h = Input.GetAxis("Horizontal");
float v = Input.GetAxis("Vertical");
Vector3 direcao = new Vector3(x:h, y:0, z:v);
rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);

if(Input.GetKeyDown(KeyCode.Space) && chao)
{
    rb.AddForce(Vector3.up * + forcePulo,ForceMode.Impulse);
    chao = false;
    _source.Play();
}


if (transform.position.y< -5)
{
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
Debug.Log(message:"UPDATE");
    }
}














