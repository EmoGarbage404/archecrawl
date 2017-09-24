using SS14.Shared.Interfaces.GameObjects;
using System.Collections.Generic;

namespace Content.Server.Interfaces.GameObjects
{
    public interface IHandsComponent : IComponent
    {
        /// <summary>
        ///     The hand index of the currently active hand.
        /// </summary>
        string ActiveIndex { get; }

        /// <summary>
        ///     Enumerates over every held item.
        /// </summary>
        IEnumerable<IItemComponent> GetAllHands();

        /// <summary>
        ///     Gets the item held by a hand.
        /// </summary>
        /// <param name="index">The index of the hand to get.</param>
        /// <returns>The item in the held, null if no item is held</returns>
        IItemComponent GetHand(string index);

        /// <summary>
        ///     Puts an item into any empty hand, preferring the active hand.
        /// </summary>
        /// <param name="item">The item to put in a hand.</param>
        /// <returns>True if the item was inserted, false otherwise.</returns>
        bool PutInHand(IItemComponent item);

        /// <summary>
        ///     Puts an item into a specific hand.
        /// </summary>
        /// <param name="item">The item to put in the hand.</param>
        /// <param name="index">The index of the hand to put the item into.</param>
        /// <param name="fallback">
        ///     If true and the provided hand is full, the method will fall back to <see cref="PutInHand(IItemComponent)" />
        /// </param>
        /// <returns>True if the item was inserted into a hand, false otherwise.</returns>
        bool PutInHand(IItemComponent item, string index, bool fallback=true);

        /// <summary>
        ///     Checks to see if an item can be put in any hand.
        /// </summary>
        /// <param name="item">The item to check for.</param>
        /// <returns>True if the item can be inserted, false otherwise.</returns>
        bool CanPutInHand(IItemComponent item);

        /// <summary>
        ///     Checks to see if an item can be put in the specified hand.
        /// </summary>
        /// <param name="item">The item to check for.</param>
        /// <param name="index">The index for the hand to check for.</param>
        /// <returns>True if the item can be inserted, false otherwise.</returns>
        bool CanPutInHand(IItemComponent item, string index);

        /// <summary>
        ///     Drops an item on the ground, removing it from the hand.
        /// </summary>
        /// <param name="index">The hand to drop from.</param>
        /// <returns>True if an item was successfully dropped, false otherwise.</returns>
        bool Drop(string index);

        /// <summary>
        ///     Checks whether the item in the specified hand can be dropped.
        /// </summary>
        /// <param name="index">The hand to check for.</param>
        /// <returns>
        ///     True if the item can be dropped, false if the hand is empty or the item in the hand cannot be dropped.
        /// </returns>
        bool CanDrop(string index);
    }
}
