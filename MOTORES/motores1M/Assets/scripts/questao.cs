using UnityEngine;

public class Questao : MonoBehaviour
{
    public int respsota;
    
   void Start()
    {
        respsota = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            respsota = 1;
        }
        else if(Input.GetKeyDown(KeyCode.B))
        {
            respsota = 2;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("A resposta é "+respsota+" !");
        }
    }
}