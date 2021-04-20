using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents; //Declarando as variáveis

    // Start is called before the first frame update
    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("ai"); //Encontrar o agente a qual ira se locomover pela respectiva tag
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit; //O raio aonde vai ser atingido
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) //Desenho do raio a qual agente ira percorrer conforme voce apontar
            {
                foreach (GameObject a in agents)
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point); //definir a trajetória a qual o agente irá percorrer 
            }
        }
    }
}
