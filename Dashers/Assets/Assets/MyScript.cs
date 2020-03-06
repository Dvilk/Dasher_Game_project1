using UnityEngine;
using UnityEngine.EventSystems;

public class MyScript : MonoBehaviour
{
    protected Joystick joystick;
    protected Joybutton joybutton;


    // Use this for initialization
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();
    }

    // Update is called once per frame
    void Update(){ 

        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joystick.Horizontal * 100f + Input.GetAxis("Horizontal") * 100f,
                                         rigidbody.velocity.y,
                                         joystick.Vertical * 100f + Input.GetAxis("Vertical") * 100f);
    }

}
