/*
 * SceneLoader 클래스는 씬을 로드합니다.
 * 씬을 로드하는 버튼에 스크립트를 넣고, 로드할 SceneName을 적습니다.
 * 이후 버튼의 On Click() 이벤트에 해당하는 버튼을 넣어주고, SceneLoad() 함수를 호출합니다.
 */

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;
    public void SceneLoad()
    {
        SceneManager.LoadScene(sceneName); //오브젝트에서 적어둔 씬을 로드
    }
}
