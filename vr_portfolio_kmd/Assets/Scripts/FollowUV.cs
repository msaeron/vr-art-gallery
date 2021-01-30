using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUV : MonoBehaviour
{
    public float parallax = 4f;
    public float speed = 1f;
    private float angleXOld;
    private float angleYOld;
    //private float time_unit = 0.0;

    void Start()
    {
        angleXOld = transform.parent.rotation.eulerAngles.x;
        angleYOld = transform.parent.rotation.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.material;
        Vector2 offset = mat.mainTextureOffset;
        //float posx = transform.position.x;
        //float posy = transform.position.y;
        float angleX = transform.parent.rotation.eulerAngles.x;
        float angleY = transform.parent.rotation.eulerAngles.y;

        // Change in angles
        float changeX = angleX - angleXOld;
        float changeY = angleY - angleYOld;

        // Only rotation
        offset.x += changeY / 360f + Time.deltaTime * speed / transform.localScale.x;
        offset.y -= changeX / 360f + Time.deltaTime * speed / transform.localScale.y;
        //offset.x = angleY / 360f; 
        //offset.y = -angleX / 360f;

        // Update old rotations
        angleXOld = transform.parent.rotation.eulerAngles.x;
        angleYOld = transform.parent.rotation.eulerAngles.y;

        // No rotation
        //offset.x = posx;
        //offset.y = posy;
        //offset.x += Time.deltaTime / 50f;
        //offset.x += (posx-offset.x + Time.deltaTime / 50f);
        //offset.x += Time.deltaTime / 50f + (posx-offset.x); // Change in position += Time.deltaTime/50f;
        //offset.x = transform.position.x  + Time.deltaTime;
        mat.mainTextureOffset = offset;
    }
}
