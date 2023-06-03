using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Threading;
using UnityEngine;

public class CharacterMovment : MonoBehaviour
{
    private CharacterController _charController;
    private ManagerJoystick _mngrJoyStick;
    //private Vector3 VelocityVector = Vector3.zero;
    private float inputX;
    //private float inputY;
    private float inputZ;
    private Vector3 v_movment;
    //public float speed = 2f;
    private float movespeed;
    //[SerializeField] private float rotationSpeed = 2.0f;
    private Vector3 direction;
    //private float horizontal;
    //private float vertical;
    //private Rigidbody rb;
    private GameObject tempPlayer;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        movespeed = 0.1f;
        tempPlayer = GameObject.FindGameObjectWithTag("Player");
        _charController = tempPlayer.GetComponent<CharacterController>();
        _mngrJoyStick = GameObject.Find("JoystickBG").GetComponent<ManagerJoystick>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //inputX = Input.GetAxis("Horizontal");
        //inputY = Input.GetAxis("Vertical");
        //inputZ = Input.GetAxis("Vertical");
        inputX = _mngrJoyStick.inputHorizontal();
        inputZ = _mngrJoyStick.inputVertical(); 
        //Vector3 direction = new Vector3(inputX, 0f, inputZ).normalized;
        /*for (int i = 0; i < 3; i++) {
            if (Vector3.Distance(tempPlayer.transform.position, FishSpawnScript.Fish[i].transform.position) == 2.0f)
            {
                Destroy(FishSpawnScript.Fish[i]);
            }*/
    
        
        //VelocityVector = v_movment * speed;

        //if (direction.magnitude>=0.1f)
        //{
        //float targetangle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0f,targetangle,0f);
        //}
       
    }

    private void FixedUpdate()
    {
        
         v_movment = new Vector3(inputX * movespeed,0, inputZ * movespeed);
        _charController.Move(v_movment);
        
        //_charController.transform.Rotate(Vector3.up * inputX * (100f * Time.deltaTime));

    }

    
    
}
