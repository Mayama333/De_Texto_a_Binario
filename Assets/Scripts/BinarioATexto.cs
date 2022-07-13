using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BinarioATexto : MonoBehaviour
{
   public TMP_InputField InputText;
   public TMP_InputField FinishText;

   public string myText;
   public string[] textArray;
   public int[] numberArray;
   public string[] finishArray;

    public byte[] byteValue;

   void Update()
   {
     if (Input.GetKeyDown(KeyCode.Return))
     {
        ConvertirTexto();
     }
   }
   
    public void ConvertirTexto()
    {
       myText = InputText.text;

       textArray = new string[myText.Length]; //para poner la misma longitud que la palabra
       numberArray = new int[myText.Length];    //para poner la misma longitud que la palabra
       finishArray = new string[myText.Length]; //para poner la misma longitud que la palabra
       byteValue   = new byte[myText.Length];
       FinishText.text = "";

        for(int i = 0; i < myText.Length; i++)
        {
            
            Debug.Log("Creating enemy number: " + i);
            textArray[i] = myText[i] + "";

            textArray[i] = "" + Convert.ToByte(myText[i]); //hace bit el texto con forma de ascii
            finishArray[i] = Convert.ToString(textArray[i]); //pasa el texto a numero
           // byte[] byteValue = BitConverter.GetBytes(numberArray[i]);
           // finishArray[i] = Convert.ToString(numberArray[i], 2); //pasa el numero a binario

            FinishText.text = FinishText.text + finishArray[i] + " ";
        }

    }
   }
