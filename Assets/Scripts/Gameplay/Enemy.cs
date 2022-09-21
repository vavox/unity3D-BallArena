using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region Fields
    float speed = 5.0f;
    GameObject player;
    Rigidbody enemyRb;
    #endregion

    #region Unity methods
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10) { Destroy(gameObject); }
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }
    #endregion
}
