using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb ;
    public GameObject splashPrefab;
    public float jumpForce ;
    private GameManager gm;

    

    void Start()
    {
         gm = GameObject.FindObjectOfType<GameManager>();
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(Vector3.up *jumpForce);

        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f,-0.2f,0f), transform.rotation);

        splash.transform.SetParent(other.gameObject.transform);

        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log("Materyal Adı:" + materialName);


        if (materialName == "Unsafe Color(Instance)")
        {
           gm.restartGame();
        }

        else if(materialName == "Last Ring (Instance)")
        {
            Debug.Log("Next Level");
        }
    }

}
