using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveKeyboard : MonoBehaviour
{
    private CharacterController controller;
    public float speed;
    public float runSpeedFactor = 1.8f;
    private float gravity = Physics.gravity.y;
    Vector3 velocity;
    bool worldOriented = true;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        float _speed = speed;

        if (Input.GetKey(KeyCode.LeftShift)) {
            _speed *= runSpeedFactor;
        }

        ///*Vector3 move*/;
        //if (worldOriented) {

        //}
        //else {
        //    move = transform. * x + transform.forward * y;
        //}
        Vector3 move = transform.right * x + transform.forward * y;

        controller.Move(move * _speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
