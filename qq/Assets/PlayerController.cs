using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float lookSpeed;
    [SerializeField] private float cameraRotationLimit;
    private float currentCameraRotationX = 0;   // Start is called before the first frame update

    [SerializeField]
    private Camera cam;


    private Animator anim;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState  = CursorLockMode.Locked;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CameraRotate();
        CharacterRotate();
        CharacterAnimation();
    }
    private void CharacterRotate()
    {
        float yR = Input.GetAxisRaw("Mouse X");
        Vector3 characterRY = new Vector3(0f, yR, 0f) * lookSpeed;
        transform.Rotate(characterRY);
        //rb.MoveRotation(rb.rotation * Quaternion.Euler(characterRY));
    }
    private void CharacterAnimation()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        anim.SetFloat("Hor", hor);
        anim.SetFloat("Ver", ver);
    }
    private void CameraRotate()
    {
        float xR = Input.GetAxisRaw("Mouse Y");
        float camRX = xR * lookSpeed;

        currentCameraRotationX -= camRX;
        currentCameraRotationX = Mathf.Clamp(currentCameraRotationX, -cameraRotationLimit, cameraRotationLimit);
        cam.transform.localEulerAngles = new Vector3(currentCameraRotationX, 0f, 0f);
    }
}
