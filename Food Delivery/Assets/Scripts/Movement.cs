using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private FloatingJoystick _js;
    [SerializeField] private float _ms;
    bool driving = false;

    private void FixedUpdate()
    {
        _rb.velocity = new Vector3(_js.Horizontal * _ms, _rb.velocity.y, _js.Vertical * _ms);

        if (Math.Abs(_js.Horizontal) > 0.001f || Math.Abs(_js.Vertical) > 0.001f)
        {
            float heading = Mathf.Atan2(-_js.Horizontal, -_js.Vertical);
            transform.rotation = Quaternion.Euler(0f, heading * Mathf.Rad2Deg + 180, 0f);
        }
    }
}
