using UnityEngine;
using UnityEngine.SceneManagement; // Scene işlemleri yapabilmemiz için bu isim uzayını ekledik.

public class nextLevel : MonoBehaviour {

    public void NextLevel()
    {
        // bir sonraki bölüme geçmesi için açık olan bölümün index'i + 1 yaptık
        // bu sayede her bölüm bir sonraki bölüme geçmesini sağlamış oluyoruz.

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }
	
}
