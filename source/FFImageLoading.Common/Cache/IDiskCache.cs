﻿using System;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace FFImageLoading.Cache
{
    public interface IDiskCache
    {
		/// <summary>
		/// Adds the file to cache and file saving queue if it does not exists.
		/// </summary>
		/// <param name="key">Key to store/retrieve the file.</param>
		/// <param name="bytes">File data in bytes.</param>
		/// <param name="duration">Specifies how long an item should remain in the cache.</param>
		void AddToSavingQueueIfNotExists(string key, byte[] bytes, TimeSpan duration);

		Task<byte[]> TryGetAsync(string key, CancellationToken token);

		Task<Stream> TryGetStreamAsync(string key);

		Task RemoveAsync(string key);

		Task ClearAsync();

		Task<bool> ExistsAsync(string key);

		Task<string> GetFilePathAsync(string key);
    }
}

