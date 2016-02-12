using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class Stopwatch : MonoBehaviour
{
    private float time;
    private Text text;
    private System.DateTime date = TimeStepModule.date;



    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        TimeStepModule.TimestepComplete += Timestep;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Scene.disableUpdate)
        {
            time += Time.deltaTime;

            var years = time / 60;
            var months = time / 5;

            var nextText = Mathf.Floor(years) + " Years" + System.Environment.NewLine;
            nextText += Mathf.Floor(months) + " Months" + System.Environment.NewLine;

            text.text = nextText;
        }
    }

    void UpdateText()
    {
        
    }

    void Timestep()
    {
        var nextText = TimeStepModule.date.ToString();
        //nextText += " " + date.ToLongTimeString();
        text.text = nextText;
    }

    public void OnDestroy()
    {
        TimeStepModule.TimestepComplete -= Timestep;
    }
}
