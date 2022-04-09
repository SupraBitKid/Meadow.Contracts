using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for a pin on the Meadow board.
    /// </summary>
    public interface IPin : IEquatable<IPin>
    {
        IList<IChannelInfo>? SupportedChannels { get; }
        string Name { get; }
        object Key { get; }

        //IChannelInfo ActiveChannel { get; }

        //void ReserveChannel<C>(); // TODO: should this return Task<bool>? (true if reserved)
        //void ReleaseChannel();

        public string ToString() => Name;
    }
}
