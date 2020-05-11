using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 0;

    public AudioClip walkSound;
    public AudioClip colisionhSound;

    private AudioSource audioData;
    private bool play_walk_sound;

    // Use this for initialization
    void Start()
    {

        audioData = GetComponent<AudioSource>();

        play_walk_sound = false;

        audioData.volume = 100;
        audioData.loop = true;
        audioData.clip = walkSound;

    }

    // Update is called once per frame
    void Update()
    {

        updateWalkSoundsStatus();

        // get input data from keyboard or controller
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // update player position based on input
        Vector3 position = transform.position;
        position.x += moveHorizontal * speed * Time.deltaTime;
        position.z += moveVertical * speed * Time.deltaTime;
        transform.position = position;

    }

    void updateWalkSoundsStatus() { 
        if (Input.anyKey && !play_walk_sound)  {
            play_walk_sound = true;
            audioData.loop = true;
            audioData.Play();
        } else if (!Input.anyKey && play_walk_sound) {
            play_walk_sound = false;
            audioData.loop = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 0.0) { 
            audioData.PlayOneShot(colisionhSound, 0.3f);
        }
    }
}
