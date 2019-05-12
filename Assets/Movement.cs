using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 18;
    private bool isMoving = false;
    private AudioSource ass;
    private Rigidbody rig;

    void Start()
    {
        rig = gameObject.GetComponent<Rigidbody>();
        ass = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
        
    }

   public void Moving()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;

        rig.MovePosition(transform.position + movement);
        isMoving = true;
        
    }
}
