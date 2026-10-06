using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Evidence
    {
        public Guid Id { get; private set; }

        public Guid InvestigationId { get; private set; }

        public string FileName { get; private set; } = null!;
        public string ContentType { get; private set; } = null!;
        public long FileSize { get; private set; }

        public string StoragePath { get; private set; } = null!;

        public string Sha256Hash { get; private set; } = null!;

        public DateTime UploadedAt { get; private set; }
        public Guid UploadedByUserId { get; private set; }

        private Evidence() { }

        public Evidence(
            Guid investigationId,
            string fileName,
            string contentType,
            long fileSize,
            string storagePath,
            string sha256Hash,
            Guid uploadedByUserId)
        {
            Id = Guid.NewGuid();

            InvestigationId = investigationId;
            FileName = fileName;
            ContentType = contentType;
            FileSize = fileSize;
            StoragePath = storagePath;
            Sha256Hash = sha256Hash;

            UploadedAt = DateTime.UtcNow;
            UploadedByUserId = uploadedByUserId;
        }
    }
}
