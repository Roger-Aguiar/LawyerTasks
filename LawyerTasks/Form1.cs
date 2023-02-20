using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Drawing.Text;
using System.Globalization;

namespace LawyerTasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGeneratePdf_Click(object sender, EventArgs e)
        {
            GeneratePdf();
        }

        private void GeneratePdf()
        {
            var file = @"C:\dev\LawyerTasks\LawyerTasks\pdf\attorney.pdf";

            using (PdfWriter pdfWriter = new PdfWriter(file, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(pdfWriter);
                var document = new Document(pdfDocument, PageSize.A4);
                
                document.Add(SetTitle("PROCURA��O"));

                document.Add(new Paragraph("\n"));

                document.Add(SetCustomer("OUTORGANTE: Roger Silva Santos Aguiar, brasileiro, casado, Analista de Sistemas, MG 14.766-058, 075.826.356-20, Rua Quatro, 98, Bairro Brasileia, Betim - MG, 32.920-000, (31)98345-3069, rogerdaviola@yahoo.com.br"));

                document.Add(new Paragraph("\n"));

                document.Add(SetLawyer("OUTORGADOS: VANA GRAZIELA RIBEIRO DE ASSIS, brasileira, casada, advogada, inscrita na OAB-MG sob n� 178.599, e-mail: vanaassis.adv@gmail.com, com endere�o profissional na rua da Bahia, n� 1.345, sala 604, Bairro Lourdes, Cep: 30160-017, Belo Horizonte � MG. onde recebe intima��o."));

                document.Add(new Paragraph("\n"));

                document.Add(new Paragraph(@"PODERES: Amplos, para o foro em geral, com a cl�usula ad judicia para, em qualquer Ju�zo, Tribunal ou Reparti��o P�blica, propor contra quem de direito as a��es competentes e defend�-lo(s) nas contr�rias, seguindo umas e outras, at� final decis�o, usando os recursos legais e acompanhando-os, conferindo-lhe, ainda, os poderes especiais para dar e receber quita��o, confessar, transigir, desistir, renunciar ao direito, retirar alvar�s em Cart�rio, podendo, ainda substabelecer, no todo ou em parte, com ou sem reservas de poderes."));

                document.Add(new Paragraph("\n"));

                document.Add(new Paragraph("PODERES ESPEC�FICOS: Atuar junto ao processo de REGULARIZA��O DE LOTE, S�O JOAQUIM DE BICAS - MG."));

                document.Add(new Paragraph("\n"));

                document.Add(new Paragraph("RESSALVA: Nos poderes ora conferidos n�o est� o de confessar em ju�zo ou fora dele."));

                document.Add(new Paragraph("\n"));

                document.Add(new Paragraph("VALIDADE: A presente procura��o tem dura��o at� o fim da a��o.\r\n"));

                document.Add(new Paragraph("\n"));

                document.Add(new Paragraph($"Belo Horizonte, {DateTime.Now.ToString("D", (new CultureInfo("pt-BR")))}"));

                document.Add(new Paragraph("\n"));

                document.Add(new Paragraph("ROGER SILVA SANTOS AGUIAR"));

                document.Close();
                pdfDocument.Close();

                MessageBox.Show("PDF generated in " + file);
            };

            
        }

        private Paragraph SetTitle(string title)
        {
            var _title = new Paragraph();
            _title.SetFont(PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD));
            _title.SetFontSize(30);
            _title.SetTextAlignment(TextAlignment.CENTER);
            _title.Add(title);

            return _title;
        }

        private Paragraph SetCustomer(string customer)
        {
            var _customer = new Paragraph();    
            _customer.SetTextAlignment(TextAlignment.LEFT);
            _customer.Add(customer);
            return _customer;
        }

        private Paragraph SetLawyer(string lawyer)
        {            
            var _lawyer = new Paragraph();
            _lawyer.SetTextAlignment(TextAlignment.JUSTIFIED);
            _lawyer.Add(lawyer);

            return _lawyer;
        }
    }
}