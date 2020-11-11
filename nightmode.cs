using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class nightmode : MonoBehaviour
{

    public Material Mat06,Mat09,Mat12,Mat15,Mat18,Mat21,Mat00;
    public Animator Light;
    public Text timeshow;
   

    void Update()
    {
        
            DateTime time = DateTime.Now;
            string hour = LeadingZero(time.Hour);
            string minute = LeadingZero(time.Minute);
            string second = LeadingZero(time.Second);
            timeshow.text = hour + ":" + minute + ":" + second;

        if (timeshow.text == "06:00:00" || time.Hour == 06 ||time.Hour>=06 && time.Hour < 09)
        {
            if (time.Minute <= 59 || time.Minute >= 00)
            {
                RenderSettings.skybox = Mat06;
                Light.Play("Ani06");
            }
       
        }
      if (timeshow.text == "09:00:00"|| time.Hour == 09|| time.Hour >= 09 && time.Hour < 12)
        {
            if ( time.Minute <= 59 || time.Minute >= 00)
            {
                RenderSettings.skybox = Mat09;
               Light.Play("Ani09");
            }
           
        }
        if (timeshow.text == "12:00:00"||time.Hour== 12 || time.Hour >= 12 && time.Hour < 15)
        {
            if ( time.Minute <= 59 || time.Minute >= 00)
            {
                RenderSettings.skybox = Mat12;
               Light.Play("Ani12");
            }
          
        }
       if (timeshow.text == "15:00:00"|| time.Hour == 15|| time.Hour >= 15 && time.Hour < 18)
        {
            if (  time.Minute <= 59 || time.Minute >= 00)
            {
                RenderSettings.skybox = Mat15;
               Light.Play("Ani15");
            }
           
        }
        if (timeshow.text == "18:00:00"|| time.Hour == 18||time.Hour >= 18 && time.Hour < 21)
        {
            if ( time.Minute <= 59 || time.Minute >= 00)
            {
                RenderSettings.skybox = Mat18;
               Light.Play("Ani18");
            }
        
        }
      if (timeshow.text == "21:00:00"||time.Hour == 21 || time.Hour >= 21 && time.Hour < 00)
        {
            if ( time.Minute <= 59 || time.Minute >= 00)
            {
                RenderSettings.skybox = Mat21;
               Light.Play("Ani21");
            }
     
        }
        if (timeshow.text == "00:00:00"||time.Hour == 00|| time.Hour >= 00 && time.Hour < 06)
        {
            if ( time.Minute <= 59 || time.Minute >= 00)
            {
                RenderSettings.skybox = Mat00;
               Light.Play("Ani00");
            }
          
        }
     
    }

        string LeadingZero(int n)
        {
            return n.ToString().PadLeft(2, '0');
        }
    }
