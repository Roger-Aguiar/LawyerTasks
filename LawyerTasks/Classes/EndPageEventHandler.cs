using iText.IO.Font.Constants;
using iText.Kernel.Events;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Properties;
using iText.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerTasks.Classes
{
    public class EndPageEventHandler : IEventHandler
    {
        protected Document document;
        protected PdfDocument pdfDocument;

        public EndPageEventHandler(Document document, PdfDocument pdfDocument)
        {
            this.document = document;
            this.pdfDocument = pdfDocument;
        }

        public void HandleEvent(Event currentEvent)
        {
            PdfDocumentEvent pdfDocumentEvent = (PdfDocumentEvent)currentEvent;
            PdfPage page = pdfDocumentEvent.GetPage();

            iText.Kernel.Geom.Rectangle pageSize = page.GetPageSize();

            PdfFont? font = null;

            try
            {
                font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            }
            catch (IOException exception)
            {
                MessageBox.Show($"{exception.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            float leftX = pageSize.GetLeft() + document.GetLeftMargin();
            float centerX = (pageSize.GetLeft() + document.GetLeftMargin() + (pageSize.GetRight() - document.GetRightMargin())) / 2;
            float rightX = pageSize.GetRight() - document.GetRightMargin();

            float headerY = pageSize.GetTop() - document.GetTopMargin() + 25;
            float footerY = document.GetBottomMargin() - 15;

            Canvas canva = new Canvas(pdfDocumentEvent.GetPage(), pageSize);

            //Header                
            canva.SetFont(font).SetFontSize(18).ShowTextAligned("Dra. Vana Assis\nADVOGADA", centerX, headerY, TextAlignment.CENTER);

            //Footer
            canva.SetFont(font).SetFontSize(10).ShowTextAligned("Dra. Vana Assis", leftX, footerY, TextAlignment.LEFT);

        }
    }
}
