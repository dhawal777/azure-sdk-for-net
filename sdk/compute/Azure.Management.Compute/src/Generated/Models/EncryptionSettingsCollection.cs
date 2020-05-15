// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Compute.Models
{
    /// <summary> Encryption settings for disk or snapshot. </summary>
    public partial class EncryptionSettingsCollection
    {
        /// <summary> Initializes a new instance of EncryptionSettingsCollection. </summary>
        /// <param name="enabled"> Set this flag to true and provide DiskEncryptionKey and optional KeyEncryptionKey to enable encryption. Set this flag to false and remove DiskEncryptionKey and KeyEncryptionKey to disable encryption. If EncryptionSettings is null in the request object, the existing settings remain unchanged. </param>
        public EncryptionSettingsCollection(bool enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Initializes a new instance of EncryptionSettingsCollection. </summary>
        /// <param name="enabled"> Set this flag to true and provide DiskEncryptionKey and optional KeyEncryptionKey to enable encryption. Set this flag to false and remove DiskEncryptionKey and KeyEncryptionKey to disable encryption. If EncryptionSettings is null in the request object, the existing settings remain unchanged. </param>
        /// <param name="encryptionSettings"> A collection of encryption settings, one for each disk volume. </param>
        /// <param name="encryptionSettingsVersion"> Describes what type of encryption is used for the disks. Once this field is set, it cannot be overwritten. &apos;1.0&apos; corresponds to Azure Disk Encryption with AAD app.&apos;1.1&apos; corresponds to Azure Disk Encryption. </param>
        internal EncryptionSettingsCollection(bool enabled, IList<EncryptionSettingsElement> encryptionSettings, string encryptionSettingsVersion)
        {
            Enabled = enabled;
            EncryptionSettings = encryptionSettings;
            EncryptionSettingsVersion = encryptionSettingsVersion;
        }

        /// <summary> Set this flag to true and provide DiskEncryptionKey and optional KeyEncryptionKey to enable encryption. Set this flag to false and remove DiskEncryptionKey and KeyEncryptionKey to disable encryption. If EncryptionSettings is null in the request object, the existing settings remain unchanged. </summary>
        public bool Enabled { get; set; }
        /// <summary> A collection of encryption settings, one for each disk volume. </summary>
        public IList<EncryptionSettingsElement> EncryptionSettings { get; set; }
        /// <summary> Describes what type of encryption is used for the disks. Once this field is set, it cannot be overwritten. &apos;1.0&apos; corresponds to Azure Disk Encryption with AAD app.&apos;1.1&apos; corresponds to Azure Disk Encryption. </summary>
        public string EncryptionSettingsVersion { get; set; }
    }
}