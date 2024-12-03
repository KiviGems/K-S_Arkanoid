using UnityEngine;


public class Control : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Vector2 maus = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        maus.y = -4.2f;
        transform.position = maus;

    }
}
