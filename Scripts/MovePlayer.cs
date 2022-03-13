using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float speed = 2;
    Rigidbody playerRb;
    public Transform cameraCenter;
    public Joystick joystick;


    



    void Start()
    {
        playerRb = GetComponent<Rigidbody>();



    }

    // Update is called once per frame
    void Update()
    {
       

        if (transform.position.y < -3)
        {
            SceneManager.LoadScene(1);
        }
#if UNITY_EDITOR_WIN

      float movePosX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
      float movePosZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

       playerRb.AddForce(cameraCenter.forward * movePosZ, ForceMode.Impulse);
       playerRb.AddForce(cameraCenter.right * movePosX, ForceMode.Impulse);

#endif
#if UNITY_ANDROID
        float movePosXmob = joystick.Horizontal * speed * Time.deltaTime;
        float movePosZmob = joystick.Vertical * speed * Time.deltaTime;

        playerRb.AddForce(cameraCenter.forward * movePosZmob, ForceMode.Impulse);
        playerRb.AddForce(cameraCenter.right * movePosXmob, ForceMode.Impulse);
#endif     








    }
}
