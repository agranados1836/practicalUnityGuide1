using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformBehaviour : MonoBehaviour
{
    public GameObject zombie;
    // Start is called before the first frame update

    public void RotateLeft()
    {
        zombie.transform.Rotate(0.0f, 10.0f, 0.0f, Space.Self);
    }

    public void RotateRight()
    {
        zombie.transform.Rotate(0.0f, -10.0f, 0.0f, Space.Self);
    }

    public void TranslateUp()
    {
        zombie.transform.Translate(Vector3.up * Time.deltaTime * 10, Space.World);
    }

    public void TranslateDown()
    {
        zombie.transform.Translate(Vector3.down * Time.deltaTime * 10, Space.World);
    }

    public void TranslateLeft()
    {
        zombie.transform.Translate(Vector3.left * Time.deltaTime * 10, Space.World);
    }

    public void TranslateRight()
    {
        zombie.transform.Translate(Vector3.right * Time.deltaTime * 10, Space.World);
    }

    public void ScaleUp(float magnitud)
    {
        Vector3 changer_scale = new Vector3(magnitud, magnitud, magnitud);
        zombie.transform.localScale += changer_scale;
    }


    public void ScaleDown(float magnitud)
    {
        Vector3 changer_scale = new Vector3(magnitud, magnitud, magnitud);
        zombie.transform.localScale -= changer_scale;
    }

}

