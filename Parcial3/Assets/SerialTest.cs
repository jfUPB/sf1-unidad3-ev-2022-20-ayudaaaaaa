using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;
public class SerialTest : MonoBehaviour
{
    SerialPort serialPort = new SerialPort("/dev/ttyUSB0", 115200);

   byte[] buffer = new byte[12];
   public float qx, qy, qz, qw;
   public float timer;
   public float intervalo = 0.01f;
   void Start()
    {
        serialPort.NewLine = "\n";
        serialPort.Open(); //Open the Serial Stream.
    }
    
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > intervalo)
        {
            timer = timer - intervalo;
            serialPort.Write("s\n");
            
        }
        if(serialPort.BytesToRead >= 12)
        {

            serialPort.Read(buffer,0,12);
            qx = BitConverter.ToSingle(buffer, 0);
            qy = BitConverter.ToSingle(buffer, 4);
            qz = BitConverter.ToSingle(buffer, 8);
            transform.rotation = new Quaternion(-qy, qz, qx, qw);
        }
        Debug.Log(qx);
        //Quaternion rotation = Quaternion.Euler(-qy, -qz, qx);
        //transform.rotation = rotation
    }
}