using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed);
        transform.Rotate(Vector3.forward);//back is righ, - back is left
    }
}