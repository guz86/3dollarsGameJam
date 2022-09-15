using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class LoadSceneComponent : MonoBehaviour
    {
        [SerializeField] private string _nameScene;
        
        private void Awake()
        {
            //Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(_nameScene);
        }
    }
}