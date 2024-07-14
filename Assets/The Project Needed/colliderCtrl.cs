using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

namespace my{

public class colliderCtrl : MonoBehaviour
{
    bool a1=true;
    bool a2=true;
    
    public static GameObject colli1;
    public static GameObject colli2;
    public List <GameObject> gameObjects1;
    public List <GameObject> gameObjects2;
    public List <GameObject> temp1;
    public List <GameObject> temp2;
    public static List <bool> data1;
    public static List <bool> data2;
    private void Start() {
        colli1=new GameObject();
        colli2=new GameObject();
        gameObjects1=new List<GameObject>();
        gameObjects2=new List<GameObject>();
        temp1=new List<GameObject>();
        temp2=new List<GameObject>();
        data1=new List<bool>();
        data2=new List<bool>();
    }
    private void Update() {
        if(a1&&colli1!=null){
            Debug.Log("111");
            colli1.GetChildGameObjects(gameObjects1);
            for(int i=0;i<gameObjects1.Count;i++){
                gameObjects1[i].GetChildGameObjects(temp1);
            }
            for(int i=0;i<temp1.Count;i++){
                if (temp1[i].GetComponent<colliderData>()==null){
                    temp1[i].AddComponent<colliderData>();
                }
            }
            a1=false;
        }
        if(colli2!=null&&a2){
            colli2.GetChildGameObjects(gameObjects2);
            for(int i=0;i<gameObjects2.Count;i++){
                gameObjects1[i].GetChildGameObjects(temp2);
            }
            for(int i=0;i<temp2.Count;i++){
                if (temp2[i].GetComponent<colliderData>()==null){
                    temp2[i].AddComponent<colliderData>();
                }
            }
            a2=false;
        }
        UpdateData();
    }
    public void UpdateData(){
        data1.Clear();
        foreach(GameObject go2 in temp1) {
            data1.Add(go2.GetComponent<colliderData>().isCollided);
        }
        data2.Clear();
        foreach(GameObject go2 in temp2) {
            data2.Add(go2.GetComponent<colliderData>().isCollided);
        }
        
    }
}
}
