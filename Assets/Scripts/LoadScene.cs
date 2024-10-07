using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void ChargementChambre(){
        SceneManager.LoadScene("chambre");
    }

    public void ChargementSalleDeBain(){
        SceneManager.LoadScene("salle de bain");
    }

    public void ChargementSalon(){
        SceneManager.LoadScene("salon");
    }

}
