using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 inputVector;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputVector = new Vector2(0,0);
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = +1;
        }


        transform.position += new Vector3(inputVector.x, inputVector.y, 0) * Time.deltaTime * 5f;


        Debug.Log(inputVector);
    }
}
