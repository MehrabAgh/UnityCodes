using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class joystick : MonoBehaviour
{
  
    public float speed=10;
    public Animator m;
    public Vector3 direction = Vector3.left;
    public GameManager Gm;
    public float v;
    void Awake()
    {
        Gm = GameObject.Find("GameManager").GetComponent<GameManager>();
         
    }

   void Start()
    {
        m = Gm.ClonePlayer.GetComponent<Animator>();
    }
   void Move(float x,float y)
    {
        m.SetFloat("valx",x);
        m.SetFloat("valy", y);
        Vector3 forward = Gm.ClonePlayer.transform.TransformDirection(Vector3.forward);
        Vector3 right = Gm.ClonePlayer.transform.TransformDirection(Vector3.right);
        Gm.ClonePlayer.transform.position += (forward * speed) * y * Time.deltaTime;
        PlayerPrefs.SetFloat("valuey",y);
        Gm.ClonePlayer.transform.position += (right * speed) * x * Time.deltaTime;
    }
   
  
    
    void Update()
    {
       
        if (m == null) return;
        var h = VirtualJoyStick.Horizontal();
        v = VirtualJoyStick.Verticale();
        Move(h,v);
      //  m.SetLayerWeight(1,1);
    }

  
}