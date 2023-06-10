using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    [Tooltip("xŽ²‚Ì‰ñ“]Šp“x")]
    private float rotateX = 90;

    [SerializeField]
    [Tooltip("yŽ²‚Ì‰ñ“]Šp“x")]
    private float rotateY = 0;

    [SerializeField]
    [Tooltip("zŽ²‚Ì‰ñ“]Šp“x")]
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