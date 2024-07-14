using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor.Scripting.Python;
using System.IO.Ports;
public class EventTest : MonoBehaviour
{
    
    public enum Wendu{
        cold_M,
        cold_L,
        normal,
        hot_L,
        hot_M
    }
    public GameObject game;
    public Wendu wendu;
    private void Start() {
        game=GameObject.FindGameObjectWithTag("111");
    }
    public void OnSelected(){
        foreach (var collider in my.colliderCtrl.data1){
            Debug.Log(collider);
        }
        foreach (var collider in my.colliderCtrl.data2){
            Debug.Log(collider);
        }
        // Debug.Log("111");
        // SerialPort aa=new SerialPort("COM28",115200);
        // aa.Parity=Parity.None;
        // aa.DataBits=8;
        // aa.StopBits=StopBits.One;
        // aa.Open();
        // aa.Write(wendu.ToString());
    }
    public void OnUnSelected(){
        Debug.Log("222");
        //DataUpdate("",Wendu.normal);
    }
    void DataUpdate(string address,Wendu w){
        FileInfo ff=new FileInfo(address);
        if(ff.Exists){
            ff.Delete();
        }
        StreamWriter streamWriter=ff.CreateText();
        streamWriter.WriteLine(w.ToString());
        streamWriter.Close();
        streamWriter.Dispose();
    }
}