using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    #region Fields
    float rotationSpeed = 75.0f;
    #endregion

    #region Unity methods
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, rotationSpeed * horizontalInput * Time.deltaTime);
    }
    #endregion
}
