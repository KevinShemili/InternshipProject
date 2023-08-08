using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Interfaces.Excel {
    public interface IExcelService {
        FileStreamResult GenerateMatrixTemplate();
        Task<List<MatrixInfo>> ReadMatrix(IFormFile file);
    }

    public class MatrixInfo {
        public Guid LenderId { get; set; }
        public Guid ProductId { get; set; }
        public int Tenor { get; set; }
        public int Spread { get; set; }
    }
}
