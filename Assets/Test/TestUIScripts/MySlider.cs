using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MySlider : MonoBehaviour {
    private Slider slider;
    private Text text;

    // Use this for initialization
    float initVal;

    void Start() {
        slider = GetComponent<Slider>();
        text = transform.Find("Numeric").GetComponent<Text>();
        initVal = slider.value;
    }

    public bool isBinaryPower;
    // Update is called once per frame
    public int RealValue;

    public void Reset() {
        slider.value = initVal;
    }

    void Update() {
        if (isBinaryPower) {
            int x = (int) slider.value;
            int y = 1;
            while (true) {
                x--;

                y *= 2;
                if (x == 0) break;
            }

            text.text = y.ToString();
            RealValue = y;
        } else
            text.text = slider.value.ToString();
    }
}