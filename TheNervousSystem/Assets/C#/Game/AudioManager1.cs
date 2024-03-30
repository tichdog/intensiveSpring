using UnityEngine;
using UnityEngine.UI;

public class Slider1Controller : MonoBehaviour
{
    public Slider slider1;
    public float oldVolume1;
    private void Start()
    {
        oldVolume1 = slider1.value;
        if (!PlayerPrefs.HasKey("value")) slider1.value = 1;
        else slider1.value = PlayerPrefs.GetFloat("value");
    }
    private void Update()
    {
        if (oldVolume1 != slider1.value)
        {
            PlayerPrefs.SetFloat("value", slider1.value);
            PlayerPrefs.Save();
            oldVolume1 = slider1.value;

        }
    }
}
