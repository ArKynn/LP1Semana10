using System;

namespace LootSort
{
    /// <summary>
    /// The Loot class should implement IComparable<Loot>
    /// and override GetHashCode() and Equals()
    /// </summary>
    public class Loot : IComparable<Loot>
    {
        /// <summary>Type of loot.</summary>
        public LootType Kind { get; }

        /// <summary>Loot description.</summary>
        public string Description { get; }

        /// <summary>Loot value.</summary>
        public float Value { get; }

        /// <summary>
        /// Create a new instance of loot.
        /// </summary>
        /// <param name="kind">Type of loot.</param>
        /// <param name="description">Loot description.</param>
        /// <param name="value">Loot value.</param>
        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }

        public int CompareTo(Loot other)
        {
            int order = 0;
            if (other == null) return 1;
            
            order = Kind.ToString().CompareTo(other.Kind.ToString());
            
            if (order == 0)
            {
                order = -Value.CompareTo(other.Value);
            }

            if (order == 0)
            {
                order = String.Compare(Description, other.Description, StringComparison.Ordinal);
            }

            return order;


        }
            
        public override int GetHashCode()
        {
            return HashCode.Combine(Kind, Description, Value);
        }

        public override bool Equals(object obj)
        {
            Loot otherLoot = obj as Loot;
            if (obj == null) return false;
            if (Kind.Equals(otherLoot.Kind) && Value.Equals(otherLoot.Value) && Description.Equals(otherLoot.Description))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Return a nicely formatted string representing the loot instance.
        /// </summary>
        /// <returns>
        /// A nicely formatted string representing the loot instance.
        /// </returns>
        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";
    }
}