using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLobbyController : MonoBehaviour
{
    RectTransform Canvas;
    List<string> CharactersInGame;
    List<RectTransform> CharacterBoxPositions;

	void Start ()
    {
        Canvas = this.transform.Find("Canvas").GetComponent<RectTransform>();
        CharactersInGame = new List<string>();
        CharacterBoxPositions = new List<RectTransform>();
        CharacterBoxPositions.Add(this.transform.Find("Canvas/CharacterBoxPositions/0").GetComponent<RectTransform>());
        CharacterBoxPositions.Add(this.transform.Find("Canvas/CharacterBoxPositions/1").GetComponent<RectTransform>());
        CharacterBoxPositions.Add(this.transform.Find("Canvas/CharacterBoxPositions/2").GetComponent<RectTransform>());
        CharacterBoxPositions.Add(this.transform.Find("Canvas/CharacterBoxPositions/3").GetComponent<RectTransform>());
        CharacterBoxPositions.Add(this.transform.Find("Canvas/CharacterBoxPositions/4").GetComponent<RectTransform>());
        CharacterBoxPositions.Add(this.transform.Find("Canvas/CharacterBoxPositions/5").GetComponent<RectTransform>());
        CharacterBoxPositions.Add(this.transform.Find("Canvas/CharacterBoxPositions/6").GetComponent<RectTransform>());
        CharacterBoxPositions.Add(this.transform.Find("Canvas/CharacterBoxPositions/7").GetComponent<RectTransform>());

        UpdateCharacterBoxPositions(new List<string> { "Tonton", "Angela", "Jason"});
    }

    private void UpdateCharacterBoxPositions(List<string> names)
    {
        for (int i = 0; i < names.Count; i++)
        {
            GameObject CharacterMenuBox = Instantiate(Resources.Load<GameObject>("Assets/GameObjects/PlayerLobby/CharacterMenuBox")) as GameObject;

            CharacterMenuBox.GetComponent<RectTransform>().SetParent(CharacterBoxPositions[i]);
            CharacterMenuBox.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
            CharacterMenuBox.transform.Find("Name").GetComponent<Text>().text = names[i];
        }
    }
}
