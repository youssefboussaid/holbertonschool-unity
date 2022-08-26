using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public Camera cam;
    Vector3 cantina = new Vector3(0, 0, -200);
    Vector3 LivingRoom = new Vector3(0, 0, 0);
    Vector3 Cube = new Vector3(0, 0, -400);
    Vector3 Mezzanine = new Vector3(0, 0, -600);


    public void Cantina()
    {
        cam.transform.position = cantina; 
    }
    public void LivingRomom()
    {
        cam.transform.position = LivingRoom;
    }
    public void cube()
    {
        cam.transform.position = Cube;
    }
    public void mezzanine()
    {
        cam.transform.position = Mezzanine;
    }
}
