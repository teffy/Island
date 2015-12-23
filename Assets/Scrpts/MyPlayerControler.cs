using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(CharacterController))]

public class MyPlayerControler : MonoBehaviour {
    bool isongroud = false;
    float movespeed = 6.0f;
    float jumpspeed = 8.0f;
    float gravity = 20.0f;
    Vector3 moveV = Vector3.zero;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    float lastmousex;
    float lastmousey;
    float lastmousez;
    void FixedUpdate(){
        if (isongroud)
        {
            // 需要在场景中旋转胶囊体，让z轴方向向着屏幕里面，这样操作就会符合，ws向前后，ad向左右
            // horizontal 对应键盘的ad，Vertical对于ws
            moveV = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveV = transform.TransformDirection(moveV);
            moveV *= movespeed;
            //如果按了空格，模拟一下跳跃
            if (Input.GetButton("Jump"))
            {
                moveV.y = jumpspeed;
            }
        }
        // 模拟重力
        moveV.y -= gravity * Time.deltaTime;
        //获取角色控制器
        CharacterController con = GetComponent<CharacterController>();

        //通过碰撞检测来判断是否已经着地
        //其实Unity已经提供了一个直接的值来判断，可以换成简单的 con.isGrounded
        CollisionFlags flags = con.Move(moveV * Time.deltaTime);
        isongroud = (flags & CollisionFlags.CollidedBelow) != 0;
        /*
        float mousex = Input.mousePosition.x;
        float mousey = Input.mousePosition.y;
        float mousez = Input.mousePosition.z;
        if(mousex != lastmousex)
        {
           transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X")*Time.deltaTime *50, 0));
        }
        if (mousey != lastmousey)
        {
            transform.Rotate(new Vector3(Input.GetAxis("Mouse X") * Time.deltaTime * 50, 0, 0));
        }
        lastmousex = mousex;
        lastmousey = mousey;
        lastmousez = mousez;

        wheeldistance = Input.GetAxis("Mouse ScrollWheel") * wheelspeed;
        transform.position = transform.position + transform.rotation * new Vector3(0, 0, wheeldistance);
        */
    }
    float wheeldistance = 0;
    float wheelspeed = 20.0f;
}
