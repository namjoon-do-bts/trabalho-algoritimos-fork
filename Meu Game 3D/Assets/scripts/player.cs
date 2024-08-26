using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;
public class player : MonoBehaviour
{
    public int velocidade = 10;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
      TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
float h = Input.GetAxis("Horizontal");
float v = Input.GetAxis("Vertical");
Vector3 direcao = new Vector3(x:h, y:0, z:v);
rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
if (transform.position.y < -5)
{
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
    }
}


