using Application.Exceptions;
using Application.Interfaces.Excel;
using ClosedXML.Excel;
using InternshipProject.Localizations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Infrastructure.Services.Excel {
    public class ExcelService : IExcelService {

        private readonly IStringLocalizer<LocalizationResources> _localization;

        public ExcelService(IStringLocalizer<LocalizationResources> localization) {
            _localization = localization;
        }

        public FileStreamResult GenerateMatrixTemplate() {

            using (var workBook = new XLWorkbook()) {

                // declare headers
                var workSheet = workBook.AddWorksheet("Matrix");
                workSheet.Cell(1, 1).Value = "LenderId";
                workSheet.Cell(1, 2).Value = "LenderName";
                workSheet.Cell(1, 3).Value = "ProductId";
                workSheet.Cell(1, 4).Value = "ProductName";
                workSheet.Cell(1, 5).Value = "Tenor";
                workSheet.Cell(1, 6).Value = "Spread";

                for (int i = 1; i <= 6; i++) {
                    workSheet.Column(i).AdjustToContents();
                }

                // download file
                var stream = new MemoryStream();
                workBook.SaveAs(stream);
                stream.Position = 0;

                return new FileStreamResult(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet") {
                    FileDownloadName = "Lender Matrix.xlsx"
                };
            }
        }

        public async Task<List<MatrixInfo>> ReadMatrix(IFormFile file) {

            var list = new List<MatrixInfo>();
            using var stream = new MemoryStream();

            await file.CopyToAsync(stream);
            stream.Position = 0;

            using var workBook = new XLWorkbook(stream);
            var workSheet = workBook.Worksheet(1);

            var rows = workSheet.RangeUsed().RowsUsed().Skip(1);

            foreach (var row in rows) {
                var lenderIdCell = row.Cell(1);
                var productIdCell = row.Cell(3);
                var tenorCell = row.Cell(5);
                var spreadCell = row.Cell(6);

                if (IsCellNullOrEmpty(lenderIdCell) || IsCellNullOrEmpty(productIdCell) || IsCellNullOrEmpty(tenorCell) || IsCellNullOrEmpty(spreadCell)) {
                    throw new WrongExcelFormatException(_localization.GetString("EmptyExcelCells").Value);
                }

                list.Add(new MatrixInfo {
                    LenderId = Guid.Parse(lenderIdCell.Value.ToString()),
                    ProductId = Guid.Parse(productIdCell.Value.ToString()),
                    Tenor = int.Parse(tenorCell.Value.ToString()),
                    Spread = int.Parse(spreadCell.Value.ToString())
                });
            }

            return list;
        }

        private static bool IsCellNullOrEmpty(IXLCell cell) {
            return cell.IsEmpty() || cell.Value.ToString() == null || string.IsNullOrWhiteSpace(cell.Value.ToString());
        }
    }
}
