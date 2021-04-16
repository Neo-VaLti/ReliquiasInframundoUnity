using UnityEngine;
using UnityEngine.UI;

public class M00_Script : MonoBehaviour
{
    public Button Button;
    public Image ImageContainer;
    public Text TextContainer;

    private float _hiddenTime = 3000f;
    private int _index;

     void Update()
     {
         _hiddenTime -= Time.deltaTime;
         if (_hiddenTime <= 0)
         {
             Button.enabled = true;
         }
     }

    private void OnClick()
    {
        HandleClick();
    }

    public void HandleClick()
    {
        switch (_index)
        {
            case 0:
                TextContainer.text =
                    "La paz entre estos reinos ha perdurado por siglos, " +
                    "su poder, así como economía se han mantenido a la par," +
                    " creando un mundo próspero y tranquilo.";
                Button.enabled = false;
                _hiddenTime = 3000f;
                _index++;
                break;
            case 1:
                TextContainer.text =
                    "Aburrido de tanta paz Azaroth, " +
                    "actual gobernante del inframundo," +
                    " imbuyo tres cristales con su poder creando con ello artefactos" +
                    " de increíbles poderes, y los envió a los líderes de cada reino para crear discordia.";
                 Button.enabled = false;
                _hiddenTime = 3000f;
                _index++;
                break;
            case 2:
                _index++;
                break;
            case 3:
                _index++;
                break;
            case 4:
                _index++;
                break;
            case 5:
                _index++;
                break;
            case 6:
                _index++;
                break;
            case 7:
                _index++;
                break;
            case 8:
                _index++;
                break;
            case 9:
                _index++;
                break;
            case 10:
                _index++;
                break;
            case 11:
                _index++;
                break;
            default:
                break;
        }
    }
}