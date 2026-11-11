using System;
using UnityEngine;

namespace Cards
{
    public enum DayTime { Day, Night, FullNight }
    public enum CardTraits { Human, Vampire, Demon, Dragon, Ghost }
    public enum PowerType { Melee, Range, Magic }

    [Serializable]
    public class CardDefinition
    {
        // Visuals
        public string name;
        public string description;
        public Sprite sprite;
        // Mechanics
        public int power;
        public PowerType powerType;
        public CardTraits cardTraits;
    }
}