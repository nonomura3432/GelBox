using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    [Tooltip("x���̉�]�p�x")]
    private float rotateX = 90;

    [SerializeField]
    [Tooltip("y���̉�]�p�x")]
    private float rotateY = 0;

    [SerializeField]
    [Tooltip("z���̉�]�p�x")]
    private float rotateZ = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(new Vector3(rotateX, rotateY, rotateZ));
        }
          
    }
}