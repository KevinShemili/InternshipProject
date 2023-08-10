using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Interfaces.Excel {
    public interface IExcelService {
        FileStreamResult GenerateMatrixTemplate(Lender lender, Product product);
        Task<List<LenderMatrix>> ReadMatrix(IFormFile file, Guid lenderId, Guid productId);
    }
}
