using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PenControllerTraining : MonoBehaviour
{
    public TextMeshProUGUI current_segment_label;
    public TextMeshProUGUI current_matter_label;
    private Color orange;
    // Start is called before the first frame update
    void Start()
    {
        orange = new Color(1.0f, 0.64f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("contact");
        string tag = collision.gameObject.name;
        string[] parts = tag.Split("_");
        Debug.Log(parts);

        if (parts.Length >= 3)
        {
            current_segment_label.text = string.Join(" ", parts, 1, parts.Length - 2);

            current_matter_label.text = parts[parts.Length - 1] == "gm" ? "\nGray Matter" : "\nWhite Matter";

            Color objectColor = collision.gameObject.GetComponent<Renderer>().material.color;
            current_segment_label.color = objectColor;
            current_matter_label.color = objectColor;
        }


    }

    private void OnCollisionExit()
    {
        current_segment_label.color = Color.white;
        current_segment_label.text = "Segment_label";
        current_matter_label.color = Color.white;
        current_matter_label.text = "\nMatter_label";
    }

}
