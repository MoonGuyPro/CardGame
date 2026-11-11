using UnityEngine;

namespace Cards
{
    public class CardManager : MonoBehaviour
    {
        [SerializeField] private CardDatabase cardDatabase;
        [SerializeField] private Card cardPrefab;
        void Start()
        {
            for (int i = 0; i < cardDatabase.cards.Count; i++)
            {
                Card card = Instantiate(cardPrefab, new Vector3(i * 4f, 0, 0), Quaternion.identity);
                card.Setup(cardDatabase.cards[i]);
            }
        }
    
    }
}
