﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ipfs.CoreApi
{
    /// <summary>
    ///   Some miscellaneous methods.
    /// </summary>
    /// <seealso href="https://github.com/ipfs/interface-ipfs-core/blob/master/SPEC/MISCELLANEOUS.md">Generic API spec</seealso>
    public interface IGenericApi
    {
        /// <summary>
        ///   Information about an IPFS peer.
        /// </summary>
        /// <param name="peer">
        ///   The id of the IPFS peer.  If not specified (e.g. null), then the local
        ///   peer is used.
        /// </param>
        /// <param name="cancel">
        ///   Is used to stop the task.  When cancelled, the <see cref="TaskCanceledException"/> is raised.
        /// </param>
        /// <returns>
        ///    A task that represents the asynchronous operation. The task's value is
        ///    the <see cref="Peer"/> information.
        /// </returns>
        Task<Peer> IdAsync(MultiHash peer = null, CancellationToken cancel = default(CancellationToken));

        /// <summary>
        ///   Get the version information.
        /// </summary>
        /// <returns>
        ///    A task that represents the asynchronous operation. The task's value is
        ///    a <see cref="Dictionary{TKey, TValue}"/> of values.
        /// </returns>
        Task<Dictionary<string, string>> VersionAsync(CancellationToken cancel = default(CancellationToken));

        /// <summary>
        ///   Stop the IPFS peer.
        /// </summary>
        /// <returns>
        ///    A task that represents the asynchronous operation.
        /// </returns>
        Task ShutdownAsync();
    }
}
