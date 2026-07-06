using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState { Iniciando, MenuPrincipal, Gameplay }

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState estadoAtual;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        MudarEstado(GameState.Iniciando);
        MudarCena("Splash");
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += AoCarregarCena;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= AoCarregarCena;
    }

    private void AoCarregarCena(Scene cena, LoadSceneMode modo)
    {
        if (cena.name == "GetStarted_Scene")
        {
            SceneManager.LoadScene("GUI", LoadSceneMode.Additive);
        }
    }

    public void MudarCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);

        if (nomeCena == "MenuPrincipal") MudarEstado(GameState.MenuPrincipal);
        if (nomeCena == "GetStarted_Scene") MudarEstado(GameState.Gameplay);
    }

    public void MudarEstado(GameState novoEstado)
    {
        estadoAtual = novoEstado;
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}