using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private GameObject gold;
    [SerializeField]
    private GameObject HP;
    private Rigidbody rigidBody;
    private float jump;
    [SerializeField]
    private float Gold1 = 100f;
    [SerializeField]
    private float Hp1 = 50f;
    // Start is called before the first frame update
    void Start()
    {
        this.rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            this.rigidBody.AddForce(transform.up * this.jump);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Gold"))
        {
            gold.SetActive(true);
            Debug.Log("°ñµå È¹µæ :" + Gold1);
        }
        else if(col.CompareTag("HP"))
        {
            HP.SetActive(true);
            Debug.Log("HP :" + Hp1);
        }
    }
}
