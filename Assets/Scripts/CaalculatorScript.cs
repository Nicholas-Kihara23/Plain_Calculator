using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaalculatorScript : MonoBehaviour
{
    public Text txtDisplay;
    public float digit1 = 0f;
    public float digit2 = 0f;
    public string opera;


    // Start is called before the first frame update
    public void BtnAddition()
    {
        digit1 = float.Parse(txtDisplay.text);
        opera = "+";

        txtDisplay.text = "";
        
    }
    public void BtnSutraction()
    {
        digit1 = float.Parse(txtDisplay.text);
        opera = "-";

        txtDisplay.text = "";

    }
    public void BtnMult()
    {
        digit1 = float.Parse(txtDisplay.text);
        opera = "*";

        txtDisplay.text = "";

    }
    public void BtnDiv()
    {
        digit1 = float.Parse(txtDisplay.text);
        opera = "/";

        txtDisplay.text = "";

    }

    public void BtnNum7()
    {
        if (txtDisplay.text == Convert.ToString("0"))
        { 
            txtDisplay.text = "7";

        
        }
        else
        {
            txtDisplay.text = txtDisplay.text + "7";
        }

    }
    public void BtnNum8()
    {
        if (txtDisplay.text == Convert.ToString("0"))
        {
            txtDisplay.text = "8";


        }
        else
        {
            txtDisplay.text = txtDisplay.text + "8";
        }

    }
    public void BtnNum9()
    {
        if (txtDisplay.text == Convert.ToString("0"))
        {
            txtDisplay.text = "9";


        }
        else
        {
            txtDisplay.text = txtDisplay.text + "9";
        }

    }
    public void BtnNum4()
    {
        if (txtDisplay.text == Convert.ToString("0"))
        {
            txtDisplay.text = "4";


        }
        else
        {
            txtDisplay.text = txtDisplay.text + "4";
        }

    }
    public void BtnNum5()
    {
        if (txtDisplay.text == Convert.ToString("0"))
        {
            txtDisplay.text = "5";


        }
        else
        {
            txtDisplay.text = txtDisplay.text + "5";
        }

    }
    public void BtnNum6()
    {
        if (txtDisplay.text == Convert.ToString("0"))
        {
            txtDisplay.text = "6";


        }
        else
        {
            txtDisplay.text = txtDisplay.text + "6";
        }

    }
    public void BtnNum1()
    {
        if (txtDisplay.text == Convert.ToString("0"))
        {
            txtDisplay.text = "1";


        }
        else
        {
            txtDisplay.text = txtDisplay.text + "1";
        }

    }
    public void BtnNum2()
    {
        if (txtDisplay.text == Convert.ToString("0"))
        {
            txtDisplay.text = "2";


        }
        else
        {
            txtDisplay.text = txtDisplay.text + "2";
        }

    }
    public void BtnNum3()
    {
        if (txtDisplay.text == Convert.ToString("0"))
        {
            txtDisplay.text = "3";


        }
        else
        {
            txtDisplay.text = txtDisplay.text + "3";
        }

    }
    public void BtnNum0()
    {
        if (txtDisplay.text == Convert.ToString("0"))
        {
            txtDisplay.text = "0";


        }
        else
        {
            txtDisplay.text = txtDisplay.text + "0";
        }

    }

    public void BtnBackspace()
    {
        if (txtDisplay.text.Length > 0)
        {
            txtDisplay.text = txtDisplay.text.Remove(txtDisplay.text.Length - 1, 1);
        
        }
        if (txtDisplay.text == "")
        {
            txtDisplay.text = "0";

        }

    }
    public void BtnClear()
    {
       
        
          txtDisplay.text = "0";

        

    }
    public void BtnClearEntry()
    {


        txtDisplay.text = "0";
        string f, s;
        f = Convert.ToString(digit1);
        s = Convert.ToString(digit2);

        f = "";
        s = "";
   




    }
    public void BtnPM()
    { 
        float p = float.Parse(txtDisplay.text);
        txtDisplay.text = Convert.ToString( -1*p);

    
    }

    public void BtnDec()
    {
        if (!txtDisplay.text.Contains(".")) 
        {
            txtDisplay.text = txtDisplay.text + ".";
        
        }
    
    
    }
    public void BtnEquals()
    {
        float answer = 0f;
        digit2 = float.Parse(txtDisplay.text);

        if (opera == "+") 
        {
            answer= digit1 + digit2;
            txtDisplay.text = answer.ToString();
        }
        if (opera == "-")
        {
            answer = digit1 - digit2;
            txtDisplay.text = answer.ToString();
        }
        if (opera == "*")
        {
            answer = digit1 * digit2;
            txtDisplay.text = answer.ToString();
        }
        if (opera == "/")
        {
            answer = digit1 / digit2;
            txtDisplay.text = answer.ToString();
        }

    }

}
