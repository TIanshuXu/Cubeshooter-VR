using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ShootIfGrabbed : MonoBehaviour
{
    private SimpleShoot simpleShoot;
    private OVRGrabbable ovrGrabbable;
    public OVRInput.Button shootingButton;
    public int maxNumberOfBullet = 100;
    public TextMeshProUGUI bulletText;
    public AudioClip GunShotClip;

    // show current time per second
    float interval = 1f;
    float nextTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        simpleShoot     = GetComponent<SimpleShoot>();
        ovrGrabbable    = GetComponent<OVRGrabbable>();
        bulletText      = GameObject.Find("Label Text").GetComponent<TextMeshProUGUI>();
        //bulletText.text = maxNumberOfBullet.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTime)
        {
            bulletText.text = DateTime.Now.ToString();
            nextTime += interval;
        }

        if (ovrGrabbable.isGrabbed && OVRInput.GetDown(shootingButton, ovrGrabbable.grabbedBy.GetController()))
        {
            // Shoot;
            simpleShoot.TriggerShoot();

            FindObjectOfType<AudioManager>().Play("Gun Shot");
            FindObjectOfType<AudioManager>().Play("Bolt Action");

            // vibration with and without audio clip (clip as a frequency sample)
            VibrationManager.singleton.TriggerVibration(GunShotClip, ovrGrabbable.grabbedBy.GetController());
            //VibrationManager.singleton.TriggerVibration(40, 2, 255, ovrGrabbable.grabbedBy.GetController());

            maxNumberOfBullet--;
            //bulletText.text = maxNumberOfBullet.ToString();
        }
    }
}
