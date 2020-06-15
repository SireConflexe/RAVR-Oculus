using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{

    private Vector3 correctionPosition = new Vector3(0,2,0);
    private Vector3 correctionRotation = new Vector3(-15,0,0);

    private int speed = 3;

    public AudioClip walkSound;
    public AudioClip colisionhSound;

    private AudioSource audioData;
    private bool play_walk_sound;


    void UpdatePositionViaVR(){
        Vector3 playeVRPosition  =  Camera.main.transform.position;
        transform.position = playeVRPosition - correctionPosition;
    }

    void UpdateRotationViaVR(){
        transform.rotation = Camera.main.transform.rotation;
        transform.Rotate(correctionRotation);
    }

    void DisableRenderer(){
         foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.enabled = false;
    }

    // Use this for initialization
    void Start()
    {

        UpdatePositionViaVR();
        audioData = GetComponent<AudioSource>();

        play_walk_sound = false;

        audioData.volume = 100;
        audioData.loop = true;
        audioData.clip = walkSound;

        if(isLocalPlayer){DisableRenderer();}

    }

    // Update is called once per frame
    void Update()
    {

        if(!isLocalPlayer){
            return ;
        }

         updateWalkSoundsStatus();

        // get input data from keyboard or controller
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        UpdatePositionViaVR();
        UpdateRotationViaVR();
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
