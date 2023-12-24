using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using TMPro;
public class Timer : MonoBehaviour
{
    public int minutesNum;
    public float secondsNum;
    public bool gamefinished = false;
    public TextMeshProUGUI TextTimer;

    void Update()
    {
        if(gamefinished==false) {
            if (secondsNum<0) {
                minutesNum = minutesNum-1;
                if(minutesNum<0) {
                    EditorSceneManager.LoadScene("Level_1");
                }
                secondsNum = 59f;

            }
            else{
                //secondsNum = secondsNum-0.01f;
                secondsNum = secondsNum - Time.deltaTime; //секунды зависят НЕ от FPS
            }
            TextTimer.text = "0"+minutesNum+":"+Mathf.Round(secondsNum * 10.0f) * 0.1f;
            }
    }
}
