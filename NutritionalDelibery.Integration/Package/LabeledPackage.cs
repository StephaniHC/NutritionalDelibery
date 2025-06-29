using Joseco.Communication.External.Contracts.Message;

namespace NutritionalDelibery.Integration.Package
{
    public record LabeledPackage : IntegrationMessage
    {
        public Guid PackageId { get; set; }
        public string Status { get; set; } = string.Empty;

        public LabeledPackage(Guid packageId, string status, string? correlationId = null, string? source = null)
            : base(correlationId, source)
        {
            PackageId = packageId;
            Status = status;
        }
    }
}
