using UnityEngine;
using System.Collections;

public class DayCycle : MonoBehaviour {

    public int DayNo { get; set; }

    public float Timer = 0;
    public float TimeScale = 5;

    public MeshRenderer Overlay;

    float Fade = 0;
    float LDes = 1;
    void Update() {

        Timer += Time.deltaTime/(60.0f*TimeScale);
        if(Timer > 1) Timer -= 2.0f;

        float des = 0;
        if(Timer > 0) des = 1;

        if( LDes != des  ) {
            LDes = des;
            Fade = 1;
        }

        if(Fade > 0) {
            des  -= (des*2 - 1 )*Fade;
            Fade -= Time.deltaTime;
        }

        var c = Color.black;
        c.a = 0.3f * des;
        Overlay.material.SetColor("_TintColor", c );
        

    }
}
