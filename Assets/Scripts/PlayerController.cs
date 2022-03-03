using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontalInput;
    private float verticalInput;
    public float speed = 10.0f;
    public GameObject projectilePrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getInbound();
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

    void getInbound(){
        if(transform.position.x < -23){
            transform.position = new Vector3(-23, transform.position.y, transform.position.z);
        }
        if(transform.position.x > 23){
            transform.position = new Vector3(23, transform.position.y, transform.position.z);
        }
        if(transform.position.z > 20){
            transform.position = new Vector3(transform.position.x, transform.position.y, 20);
        }
        if(transform.position.z < -6){
            transform.position = new Vector3(transform.position.x, transform.position.y, -6);
        }
    }
}
