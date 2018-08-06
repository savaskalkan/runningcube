using UnityEngine;

public class playerscript : MonoBehaviour {

    // rigidbody componentini rb adıyla çağırıyoruz.
    public Rigidbody rb;

    public GameObject gameManager;
    // public yani erişilebilir ve değiştirebilir, ondalıklı sayısal değer tutabilen float değişkenleri kullandık.
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
     

    // fiziksel karışıklıkları önlemek için update yerine FixedUpdate kullandık.
    // ikisi arasındaki fark,
    // update her frameden sonra çalışır. Oyunun kasmasına ya da akıcılığına göre farklı sürelerde çalışabilir.
    // fixedUpdate ise oyunun akıcılığına ya da kasmasına aldırmadan belirli zaman aralığında çalışır.
    void FixedUpdate()
    {   
        // AddForce ile Player'a X Y ve Z eksenlerinde güç uygulayabiliriz.
        // time.deltatime ile Player'a Z ekseninde saniyenin onda biri sürede forwardForce kadar güç uygulanmasını sağladık
        rb.AddForce(0,0,forwardForce * Time.deltaTime);
        
        // klavya kontrolleri ile Player'ı yönlendirme
        // if kontroleri ile kullanıcının o sırada hangi tuşa bastığını öğrenip ona göre Player'ı sağa veya sola yönlendiriyoruz. 
        if (Input.GetKey("right")) // right yerine "d" harfiyle de yönlendirebiliriz.
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("left"))  // left yerine "a" harfiyle de yönlendirebiliriz.
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (transform.position.y < 0)
        {
            gameManager.GetComponent<manage>().GameOver();
            
            // Bu şekilde de çağırabiliriz.
            //FindObjectOfType<manage>().GameOver();
        }
    }
    
}
