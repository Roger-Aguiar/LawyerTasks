using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Drawing.Text;
using iText.Layout;
using iText.Kernel.Events;
using iText.Kernel.Pdf.Canvas;
using iText.IO.Image;

namespace LawyerTasks.Classes
{
    public class Attorney
    {
        public Attorney()
        {

        }

        public void GenerateAttorney()
        {
            var file = @"C:\dev\LawyerTasks\LawyerTasks\pdf\attorney.pdf";

            using (PdfWriter pdfWriter = new PdfWriter(file, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(pdfWriter);
                var document = new Document(pdfDocument, PageSize.A4);

                var header = new MigraDoc();

                document.SetMargins(85, 50, 50, 50);

                pdfDocument.AddEventHandler(PdfDocumentEvent.END_PAGE, new EndPageEventHandler(document, pdfDocument));

                document.Add(SetTitle("PROCURAÇÃO"));

                document.Add(SetTitle("OUTORGANTE"));

                document.Add(SetBody("Roger Silva Santos Aguiar, brasileiro, casado, Analista de Sistemas, MG 14.766-058, 075.826.356-20, Rua Quatro, 98, Bairro Brasileia, Betim - MG, 32.920-000, (31)98345-3069, rogerdaviola@yahoo.com.br"));

                document.Add(SetTitle("OUTORGADO"));

                document.Add(SetBodyAsJustified("VANA GRAZIELA RIBEIRO DE ASSIS, brasileira, casada, advogada, inscrita na OAB-MG sob nº 178.599, e-mail: vanaassis.adv@gmail.com, com endereço profissional na rua da Bahia, nº 1.345, sala 604, Bairro Lourdes, Cep: 30160-017, Belo Horizonte – MG. onde recebe intimação."));
                               
                document.Add(SetTitle("PODERES"));

                document.Add(SetBodyAsJustified("Amplos, para o foro em geral, com a cláusula ad judicia para, em qualquer Juízo, Tribunal ou Repartição Pública, propor contra quem de direito as ações competentes e defendê-lo(s) nas contrárias, seguindo umas e outras, até final decisão, usando os recursos legais e acompanhando-os, conferindo-lhe, ainda, os poderes especiais para dar e receber quitação, confessar, transigir, desistir, renunciar ao direito, retirar alvarás em Cartório, podendo, ainda substabelecer, no todo ou em parte, com ou sem reservas de poderes."));

                document.Add(SetTitle("PODERES ESPECÍFICOS"));

                document.Add(SetBody("Atuar junto ao processo de REGULARIZAÇÃO DE LOTE, SÃO JOAQUIM DE BICAS - MG."));

                document.Add(SetTitle("RESSALVA"));

                document.Add(SetBody("Nos poderes ora conferidos não está o de confessar em juízo ou fora dele."));

                document.Add(SetTitle("VALIDADE"));

                document.Add(SetBody("A presente procuração tem duração até o fim da ação.\n"));

                document.Add(new Paragraph("\n"));

                document.Add(SetBody($"Belo Horizonte, {DateTime.Now.ToString("D", (new CultureInfo("pt-BR")))}"));

                document.Add(SetTitle("___________________________________________________________"));

                document.Add(SetTitle("(Assinatura)"));

                document.Add(SetBody("ROGER SILVA SANTOS AGUIAR"));

                document.Close();
                pdfDocument.Close();

                MessageBox.Show("PDF generated in " + file);
            };
        }

        private Paragraph SetTitle(string title)
        {
            var _title = new Paragraph();
            _title.SetFont(PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD));
            
            if(title == "PROCURAÇÃO")
            {
                _title.SetFontSize(25);
            }
            else if(title == "(Assinatura)")
            {
                _title.SetFontSize(10);
            }
            else
            {
                _title.SetFontSize(13);
            }
            
            _title.SetTextAlignment(TextAlignment.CENTER);
            _title.Add(title);

            return _title;
        }

        private Paragraph SetBody(string customer)
        {
            var _customer = new Paragraph();
            _customer.SetTextAlignment(TextAlignment.CENTER);
            _customer.Add(customer);
            return _customer;
        }

        private Paragraph SetBodyAsJustified(string lawyer)
        {
            var _lawyer = new Paragraph();
            _lawyer.SetTextAlignment(TextAlignment.JUSTIFIED);
            _lawyer.Add(lawyer);

            return _lawyer;
        }

        /*private class EndPageEventHandler : IEventHandler
        {
            
        }*/
    }
}
