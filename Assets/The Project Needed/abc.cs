using System.Collections;
using System.Collections.Generic;
using my;
using UnityEngine;

public class abc : MonoBehaviour
{
    public int aaa;
    private bool aa=true;
    void Update()
    {
        if (aa){
            if(transform.GetChild(1)!=null&&aaa==1){
                colliderCtrl.colli1=transform.GetChild(1).gameObject;
            }
            else if(transform.GetChild(1)!=null&&aaa==2){
                colliderCtrl.colli2=transform.GetChild(1).gameObject;
            }
            aa=false;
        }
    }
}
