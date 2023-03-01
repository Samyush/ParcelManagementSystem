using Microsoft.EntityFrameworkCore;

namespace ParcelManagementSystemMVC.Models;
[Keyless]
public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}