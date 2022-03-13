using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Rigidbody playerRigidbody;


    public List<Vector3> Velosities = new List<Vector3>();
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            Velosities.Add(Vector3.zero);
        }
    }

    private void FixedUpdate()
    {
        Velosities.Add(playerRigidbody.velocity);
        Velosities.RemoveAt(0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 summm = new Vector3(0,0,0);
            for(int i = 0; i < Velosities.Count; i++)
        {
            summm += Velosities[i];
        }


        transform.position = playerTransform.position;
        transform.rotation =Quaternion.Lerp(transform.rotation,Quaternion.LookRotation(summm),Time.deltaTime );
    }
}
