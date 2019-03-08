using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public float damage;
    public float range = 100.0f;

    public Camera fpsCam;

    public Animator GunRecoil;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("LMB Red gun");
            ShootRed();
            PlayAnimation();
        }
        
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            print("RMB bluegun");
            ShootBlue();
        }
        

    }
    void PlayAnimation()
    {
        GunRecoil.SetTrigger("Fire");
    }

    void ShootRed()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            RedCubeTarget target = hit.transform.GetComponent<RedCubeTarget>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
    
    void ShootBlue()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            BlueCubeTarget target = hit.transform.GetComponent<BlueCubeTarget>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
    
}
