using MicroRabbit.MVC.Models.DTO;

namespace MicroRabbit.MVC.Models.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDTO transferDTO);
    }
}
