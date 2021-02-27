using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public TextController textController;
    public OVRInput.Controller Controller;

    public string actionButtonName;
    public string resetGameButtonName;
    public float grabRadius = 1;
    public LayerMask grabMask;

    public float bulletLaunchForce = 10f; 
    public AudioClip grabFruitAudio;

    private GameObject projectile;
    private bool isArmed;
    private AudioSource audioSource;
    

    // temp variables
    public GameObject tempProjectile;
    private Vector3 offset = new Vector3(0, 0.033f, 0.101f);

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // restart level
        if (Input.GetAxis(resetGameButtonName) == 1)
        {
            Application.LoadLevel(0);
        }

        // either grab or shoot object
        if (Input.GetKeyDown(KeyCode.S) || Input.GetButtonDown(actionButtonName))
        {
            //ShootTempObject();
            if (isArmed)
            {
                ShootObject();
            }
            else
            {
                GrabObject();
            }
        }
  /*      textController.setText("" + transform.GetChild(0).transform.position
            + "\n" + transform.position
            + "\n" + OVRInput.GetLocalControllerPosition(Controller));*/
    }


    // for debug purposes
    void ShootTempObject()
    {
        Transform gunBarrel = transform.GetChild(0).transform; // get gun barrel transform
        GameObject cubeProj = Instantiate(tempProjectile, gunBarrel.position, gunBarrel.rotation);
        Rigidbody rb = cubeProj.GetComponent<Rigidbody>();

        // TODO: Vector3.forward doesnt really follow the current transform.forward direction.
        // but using transform.forward angle is too big for some reason (is it because its impulse force?)
        rb.AddRelativeForce(transform.forward * bulletLaunchForce, ForceMode.Impulse);
    }

    void ShootObject()
    {
        projectile.transform.parent = null;
        projectile.GetComponent<Rigidbody>().isKinematic = false;

        // projectile.GetComponent<ProjectileControl>().Shoot(transform.forward);

        // TODO: Vector3.forward doesnt really follow the current transform.forward direction.
        // but using transform.forward angle is too big for some reason (is it because its impulse force?)
        projectile.GetComponent<Rigidbody>().AddRelativeForce(transform.forward * bulletLaunchForce, ForceMode.Impulse);
        projectile.GetComponent<ProjectileController>().ToggleShotState();

        isArmed = false;
        projectile = null;
    }

    void GrabObject()
    {        
        
        RaycastHit[] hits;

        // only react for objects in the correct layer(s)
        hits = Physics.SphereCastAll(transform.position, grabRadius, transform.forward, 0f, grabMask);

        if (hits.Length > 0)
        {
            int closestHit = 0;

            for (int i = 0; i < hits.Length; i++)
            {
                if ((hits[i]).distance < hits[closestHit].distance)
                {
                    closestHit = i;
                }
            }

            projectile = hits[closestHit].transform.gameObject; 
            projectile.GetComponent<Rigidbody>().isKinematic = true;

            Transform gunBarrel = transform.GetChild(0).transform; // get gun barrel transform

            projectile.transform.position = gunBarrel.position;
            projectile.transform.rotation = gunBarrel.rotation;
            projectile.transform.parent = transform;
            isArmed = true;

            // play audio
            audioSource.clip = grabFruitAudio;
            audioSource.Play();
        }
    }
}
