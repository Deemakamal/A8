using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
           int number=0;
        while(number<=21){
        int num= Random.Range(1,21);
        Debug.Log(num);
        number++;
        if(num ==5){
            continue;}

        if(num ==15){
            break;}
        
        }
    }
    }

   
