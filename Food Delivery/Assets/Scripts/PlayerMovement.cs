using UnityEngine;
using System;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour {
    [SerializeField] private float speed;
    [SerializeField] private Joystick _joystick;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Canvas canvas;
    private bool driving = false;
    Image img1;
    Image img2;
    

    private void Awake(){
        img1 = _joystick.GetComponent<Image>();
        img2 = _joystick.transform.GetChild(0).GetComponent<Image>();
        img1.enabled = false;
        img2.enabled = false;
    }
    private void Update()
    {
        if (Input.touchCount == 0)
        {
            Debug.Log("no");
            driving = false;
            img1.enabled = false;
            img2.enabled = false;
        }
        if (Input.touchCount > 0 && !driving)
        {
            Debug.Log("yes");
            driving = true;
            img1.enabled = true;
            img2.enabled = true;
            Touch touch = Input.GetTouch(0);
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 15));
            _joystick.transform.position = touchPos;
        }
    }

    private void FixedUpdate(){
        Debug.Log("1");
        if (driving){
            Debug.Log("2");
            //float xMovement = _joystick.Horizontal();
            //float zMovement = _joystick.Vertical();

            //transform.position += new Vector3(xMovement, 0f, zMovement) * speed * Time.fixedDeltaTime;
        }
        
    }
}
