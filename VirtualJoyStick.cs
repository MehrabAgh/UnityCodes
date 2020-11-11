using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class VirtualJoyStick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    Image bgImg,joystick;
    static Vector3 inputVector;
    public static float rotationCharacter;
    void Start(){
        bgImg = GetComponent<Image>();
        joystick = transform.GetChild(0).GetComponent<Image>();
    }
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public virtual void OnDrag(PointerEventData eventData)
    {
       Vector2 pos;
       if (RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImg.rectTransform,eventData.position,eventData.pressEventCamera,out pos)){
           pos.x = pos.x / bgImg.rectTransform.sizeDelta.x;
           pos.y = pos.y / bgImg.rectTransform.sizeDelta.y;
           inputVector = new Vector3(pos.x *2,pos.y*2,0);
           inputVector = inputVector.magnitude >1.0f ? inputVector.normalized : inputVector;
            rotationCharacter = inputVector.x;
           joystick.rectTransform.anchoredPosition = new Vector2(inputVector.x*(bgImg.rectTransform.sizeDelta.x/3),inputVector.y*(bgImg.rectTransform.sizeDelta.y/3));
           //print(inputVector);
       }
    }

    public virtual void OnPointerUp(PointerEventData eventData)
    {
        inputVector = Vector3.zero;
        joystick.rectTransform.anchoredPosition = inputVector;
        //print(inputVector);
    }
    public static float Horizontal(){
        var x = inputVector.x != 0 ? inputVector.x : 0;
        return x;
    }
    public static float Verticale(){
        var y = inputVector.y != 0 ? inputVector.y : 0;
        return y;   
    }
}
