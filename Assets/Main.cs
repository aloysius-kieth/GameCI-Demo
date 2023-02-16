using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Main : MonoBehaviour {
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            text.text = Random.Range(0, 100).ToString();
        }
    }
}
