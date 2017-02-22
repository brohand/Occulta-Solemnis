using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb2d;
    public Sprite cultist_front;
    public Sprite cultist_front2;
    public Sprite cultist_front3;
    public Sprite cultist_back;
    public Sprite cultist_back2;
    public Sprite cultist_back3;
    public Sprite cultist_left;
    public Sprite cultist_left2;
    public Sprite cultist_left3;
    public Sprite cultist_right;
    public Sprite cultist_right2;
    public Sprite cultist_right3;
    private SpriteRenderer spriteRenderer;
    private int front;
    private int back;
    private int left;
    private int right;
    AudioSource step;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        cultist_front = Resources.Load<Sprite>("character_sprites/dude");
        cultist_front2 = Resources.Load<Sprite>("character_sprites/dude_step1");
        cultist_front3 = Resources.Load<Sprite>("character_sprites/dude_step2");
        cultist_back = Resources.Load<Sprite>("character_sprites/dude_back");
        cultist_back2 = Resources.Load<Sprite>("character_sprites/dude_back_step1");
        cultist_back3 = Resources.Load<Sprite>("character_sprites/dude_back_step2");
        cultist_left = Resources.Load<Sprite>("character_sprites/dude_leftside");
        cultist_left2 = Resources.Load<Sprite>("character_sprites/dude_leftside_step1");
        cultist_left3 = Resources.Load<Sprite>("character_sprites/dude_leftSide2");
        cultist_right = Resources.Load<Sprite>("character_sprites/dude_rightSide");
        cultist_right2 = Resources.Load<Sprite>("character_sprites/dude_rightSide1");
        cultist_right3 = Resources.Load<Sprite>("character_sprites/dude_rightSide2");
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = cultist_front;

        front = 1;
        back = 1;
        left = 1;
        right = 1;

        step = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        rb2d.velocity = new Vector2(x * speed, y * speed) * Time.deltaTime;
        var dir = rb2d.velocity;
        //var dir = new Vector2(x, y) * speed * Time.deltaTime;

        //transform.Translate(0, dir.y, 0);
        if (step.isPlaying)
            step.GetComponent<AudioSource>().Pause();

        //transform.Translate(dir.x, 0, 0);
        StartCoroutine(Slow());
        if (dir.x < 0)
        {
            //transform.rotation = Quaternion.Euler(0,0,90);
            if (!step.isPlaying)
                step.GetComponent<AudioSource>().Play();
            if (left == 1)
            {
                spriteRenderer.sprite = cultist_left;
                left = 2;
            }
            else
            if (left == 2)
            {
                spriteRenderer.sprite = cultist_left2;
                left = 3;
            }
            else
            if (left == 3)
            {
                spriteRenderer.sprite = cultist_left3;
                left = 1;
            }
        }
        else if (dir.x > 0)
        {
            //transform.rotation = Quaternion.Euler(0, 0, -90);
            if (!step.isPlaying)
                step.GetComponent<AudioSource>().Play();
            if (right == 1)
            {
                spriteRenderer.sprite = cultist_right;
                right = 2;
            }
            else
            if (right == 2)
            {
                spriteRenderer.sprite = cultist_right2;
                right = 3;
            }
            else
            if (right == 3)
            {
                spriteRenderer.sprite = cultist_right3;
                right = 1;
            }
        }
        else if (dir.y > 0)
        {
            //transform.rotation = Quaternion.Euler(0, 0, 0);
            if (!step.isPlaying)
                step.GetComponent<AudioSource>().Play();
            if (back == 1)
            {
                spriteRenderer.sprite = cultist_back;
                back = 2;
            }
            else
            if (back == 2)
            {
                spriteRenderer.sprite = cultist_back2;
                back = 3;
            }
            else
            if (back == 3)
            {
                spriteRenderer.sprite = cultist_back3;
                back = 1;
            }
        }
        else if (dir.y < 0)
        {
            //transform.rotation = Quaternion.Euler(0, 0, 180);
            if (!step.isPlaying)
                step.GetComponent<AudioSource>().Play();
            if (front == 1)
            {
                spriteRenderer.sprite = cultist_front;
                front = 2;
            }
            else
            if (front == 2)
            {
                spriteRenderer.sprite = cultist_front2;
                front = 3;
            }
            else
            if (front == 3)
            {
                spriteRenderer.sprite = cultist_front3;
                front = 1;
            }
        }

    }

    IEnumerator Slow()
    {
        yield return new WaitForSeconds(50);
    }
}
