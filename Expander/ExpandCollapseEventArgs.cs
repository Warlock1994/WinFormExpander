using System;

namespace Expander
{
    public class StateChangedEventArgs : EventArgs
    {
        /// <summary>
        /// true - контрол развёрнут. false - контрол свёрнут
        /// </summary>
        public bool IsExpanded { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="isExpanded">true - контрол развёрнут. false - контрол свёрнут</param>
        public StateChangedEventArgs(bool isExpanded)
        {
            IsExpanded = isExpanded;
        }
    }
}