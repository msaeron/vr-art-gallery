using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRotation : MonoBehaviour
{
    public Transform child_background1;
    public Transform child_background2;
    public Transform child_background3;

    void LateUpdate()
    {
        child_background1.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x,
                                                    transform.rotation.eulerAngles.y, 
                                                    gameObject.transform.rotation.z * -1.0f);
        child_background2.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x,
                                            transform.rotation.eulerAngles.y,
                                            gameObject.transform.rotation.z * -1.0f);
        child_background3.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x,
                                    transform.rotation.eulerAngles.y,
                                    gameObject.transform.rotation.z * -1.0f);
    }
}