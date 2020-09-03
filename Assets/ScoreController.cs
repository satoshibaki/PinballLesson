using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    //得点を表示するテキスト
    private GameObject ScoreText;

    private int Score;

    // Start is called before the first frame update
    void Start()
    {
        this.ScoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //ゲーム画面に得点を表示
        this.ScoreText.GetComponent<Text>().text = ("得点：") + Score.ToString();

        Debug.Log(Score);
        
    }

    void OnCollisionEnter(Collision other)
    {
        // 衝突時得点を加算
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.Score += 10;
        }

        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.Score += 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            this.Score += 30;
        }     
    }
}


