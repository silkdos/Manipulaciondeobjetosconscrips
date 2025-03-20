using UnityEngine;

public class Espacio2D : MonoBehaviour
{
    //Atributes
    //Public Atributes
    public Transform playerTransform;
    public Transform sphereTransform;
    public float speedX;
    public float speedY;
    public float speedRotation;
    public float speedRotationSphere;

    //Private Atributes
    public float rotationAngle = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento en 2 ejes
        //playerTransform.Translate(Time.deltaTime * speedX, Time.deltaTime * speedY, 0);

        //Movimiento en 2 ejes
        playerTransform.Translate(Vector3.right * Time.deltaTime * speedX);//Time.deltaTime = 1 / FPS
        playerTransform.Translate(Vector3.up * Time.deltaTime * speedY);

        //Rotación en 1 eje
        //playerTransform.Rotate(speedRotation * Time.deltaTime, 0, 0);
        playerTransform.Rotate(Vector3.right * speedRotation * Time.deltaTime);

        //Rotate Around
        sphereTransform.RotateAround(playerTransform.position, Vector3.right, rotationAngle * Time.deltaTime * speedRotationSphere);

        rotationAngle++;
    }
}
