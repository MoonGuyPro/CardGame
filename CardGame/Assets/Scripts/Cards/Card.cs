using TMPro;
using UnityEngine;

namespace Cards
{
    public class Card : MonoBehaviour
    {
        [SerializeField] private TMP_Text cardName;
        [SerializeField] private TMP_Text power;
        [SerializeField] private TMP_Text powerType;
        [SerializeField] private TMP_Text cardTraits;
    
        public CardDefinition Data { get; private set; }

        public void Setup(CardDefinition data)
        {
            Data = data;
            cardName.text = data.name;
            power.text = data.power.ToString();
            powerType.text = data.powerType.ToString();
            cardTraits.text = data.cardTraits.ToString();
        
        }



    }
}
