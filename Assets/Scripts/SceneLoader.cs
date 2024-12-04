/*
 * SceneLoader 클래스는 씬을 로드합니다.
 * 나중에 로드할 씬이 많아지면 SceneLoad(int i)나 String sceneName으로 해서 로드할 씬을 정할 수 있도록 하면 좋습니다.
 */

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void SceneLoad()
    {
        SceneManager.LoadScene("GamePhone"); //street 씬을 로드
    }
}
