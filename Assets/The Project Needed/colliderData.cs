using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderData : MonoBehaviour
{
    public bool isCollided=false;
    private void Start() {
        gameObject.AddComponent<Rigidbody>();
        gameObject.GetComponent<Rigidbody>().useGravity=false;
    }
    private void OnCollisionEnter(Collision other) {
        isCollided=true;
        Debug.Log("165156646530");
    }
    private void OnCollisionStay(Collision other) {
        isCollided=true ;
        Debug.Log("siohcoisnvdoisnvpnfoibdifbndilukb");
    }
    private void OnCollisionExit(Collision other) {
        isCollided= false;
        Debug.Log("Exit");
    }
}
