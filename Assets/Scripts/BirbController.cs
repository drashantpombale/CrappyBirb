using UnityEngine;
using UnityEngine.UI;

public class BirbController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rgbd;
    float speed = 4f;
    bool isdead = false;
    public Text score;
    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (!isdead)
        {
            if (Input.touchCount > 0)
            {
                rgbd.velocity = new Vector2(speed, 0);
                rgbd.AddForce(new Vector2(0, 50f), ForceMode2D.Impulse);

            }
            else
                rgbd.velocity = new Vector2(speed, rgbd.velocity.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.layer = 12;
        rgbd.velocity = new Vector2(0, 0);
        isdead = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 13) { 
            
        }
    }


}
