namespace Jedi.HierarchyBuilder.Utils.Binder
{
    public interface IBinderTracker
    {
        /// <summary>
        /// Gets if the tracker have changes
        /// </summary>
        bool HaveChanges { get; }

        /// <summary>
        /// Gets if can performe undo
        /// </summary>
        bool CanUndo { get; }

        /// <summary>
        /// Gets if can performe redo
        /// </summary>
        bool CanRedo { get; }

        /// <summary>
        /// Undo last action
        /// </summary>
        void Undo();

        /// <summary>
        /// Redo the last action
        /// </summary>
        void Redo();

        /// <summary>
        /// Clear all the changes
        /// </summary>
        void Clear();
    }
}
