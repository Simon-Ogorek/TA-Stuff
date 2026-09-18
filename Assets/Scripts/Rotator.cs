using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    transform.Rotate(new Vector3 (15, 30, 45) * Time.deltaTime);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
