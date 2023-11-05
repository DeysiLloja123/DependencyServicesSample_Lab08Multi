using System;
using System.Threading.Tasks;

namespace DependencyServicesSample
{
    public interface IQrCodeScanner
    {
        Task<string> ScanQrCodeAsync();
    }
}