using UnityEngine;
using UnityEngine.SceneManagement; // Scene işlemleri yapabilmemiz için bu isim uzayını ekledik.

public class manage : MonoBehaviour {

    // oyunun sonlandığını tutacağımız boolean bir değişken tanımlıyoruz.
    bool endingGame = false;

    // Invoke fonksiyonunda restart fonksiyonunun ne kadar gecikme ile çalıştırılacağını bu değişken ile belirliyoruz.
    public float gameDelay = 1f;

    // Oyun tamamlandığında ekrana gelecek olan gameComplete panel nesnesine bu şekilde erişiyoruz.
    // daha sonra bu değişken üzerinde CompleteGame fonksiyonu ile işlem yapacağız.
    public GameObject completeLevelUI;

    // Oyun tamamlandığında çalışmasını istediğimiz fonksiyonu hazırlıyoruz.
    public void CompleteGame()
    {
        // varsayılan olarak gizli olan gameComplete panel nesnesi oyun tamamlandığında bu kod ile aktif ediliyor.
        completeLevelUI.SetActive(true);
        Debug.Log("Oyunu Kazandın..!");
    }

    // Oyun kaybedildiğinde çalışmasını istediğimiz fonksiyon
    public void GameOver()
    {
        // bu kontrol ile oyun kaybedildiği zaman bu kod bloğunun bir kere çalışmasını sağlıyoruz.
        if (endingGame == false)
        { 
            endingGame = true;

            Debug.Log("Oyun Bitti..!");

            // Invoke fonksiyonu çalıştırmak istediğimiz bir fonksiyonu istediğimi bir süre kadar geciktirmemizi sağlar.
            // iki parametre alır, ilki fonksiyonun ismi ikincisi gecikme süresi.
            // burada oyun hemen başlamasın diye gameDelay değişkeninin tuttuğu kadar süre saniyelik bir gecikme koyuyoruz.
            Invoke("restart", gameDelay);
        }
    }

    // restart fonksiyonu oyun başarısız olduğunda yeninden başlaması için yazdığımız bir fonksiyon
    void restart()
    {
        // bu kod ile başarısız olunan o anki bölümün tekrar başlamasını sağlıyoruz.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        // diğer bir yöntem
        //Application.LoadLevel(Application.loadedLevel);
    }
}
