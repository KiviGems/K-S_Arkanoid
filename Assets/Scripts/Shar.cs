using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Shar : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rb;
    void Start()
    {
        Vector2 d = new Vector2(5f, -5f);
        _rb.AddForce(d, ForceMode2D.Impulse);
    }

    void Update()
    {
        
    }
}
