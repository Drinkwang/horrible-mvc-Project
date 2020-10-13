using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class item : MonoBehaviour
{
    private Image image;
    private Text text;
    void Awake()
    {
        image = transform.GetComponentInChildren<Image>();
        text = transform.GetComponentInChildren<Text>();
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private Packagemodel model;
    public Packagemodel Model
    {
        get { return this.model; }
        set
        {
            model = value;
            if (model.goodid != 0)
            {
                this.image.sprite = Resources.Load<Sprite>(model.good.src);
                this.text.text = model.count + "";

            }
            else
            {
                //	this.image.sprite = null;
                this.text.text = 0 + "";

            }
        }

    }
}
