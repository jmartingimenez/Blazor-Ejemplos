using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEjemplos.Controllers
{
    public class EjemploController : Controller
    {
        public string GetRandomNumber()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int numero = rand.Next(11);
            return numero.ToString();
        }

        public FileContentResult GetSampleExcelByHref()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                XLWorkbook wb = new XLWorkbook();
                IXLWorksheet ws = wb.AddWorksheet("Ejemplo");

                ws.Cell("A1").Value = "Hola";
                ws.Cell("B1").Value = "Mundo!";

                wb.SaveAs(ms, validate: true, evaluateFormulae: true);
                byte[] bytes = ms.ToArray();

                return File(bytes, System.Net.Mime.MediaTypeNames.Application.Octet, "ExcelEjemplo.xlsx");
            }
        }

        [ActionName("GetSampleExcelAsByteArray")]
        public async Task<Stream> GetSampleExcelAsByteArrayFromGet()
        {
            return await GetSampleExcelAsByteArray(simulateDelay: false);
        }

        [HttpPost, ActionName("GetSampleExcelAsByteArray")]
        public async Task<Stream> GetSampleExcelAsByteArrayFromPost()
        {
            return await GetSampleExcelAsByteArray(simulateDelay: true);
        }

        private async Task<Stream> GetSampleExcelAsByteArray(bool simulateDelay = false)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                XLWorkbook wb = new XLWorkbook();
                IXLWorksheet ws = wb.AddWorksheet("Ejemplo");

                ws.Cell("A1").Value = "Hola";
                ws.Cell("B1").Value = "Mundo!";

                wb.SaveAs(ms, validate: true, evaluateFormulae: true);
                byte[] bytes = ms.ToArray();

                if(simulateDelay)
                {
                    //Simulando un retraso (Por ejemplo, un excel complejo)
                    await Task.Delay(3000);
                }

                return new MemoryStream(bytes);
            }
        }
    }
}
