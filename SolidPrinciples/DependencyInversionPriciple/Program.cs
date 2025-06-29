using DependencyInversionPriciple;

namespace DependencyInversionPrinciple;
public class Program
{
    private static void Main(string[] args)
    {
        EmailSender emailSender = new EmailSender();
        PdfGenerator pdfGenerator = new PdfGenerator();
        WordGenerator wordGenerator = new WordGenerator();
        ReportGenerator pdfReportGenerator = new ReportGenerator(emailSender,pdfGenerator);
        ReportGenerator wordReportGenerator = new ReportGenerator(emailSender, wordGenerator);

        pdfReportGenerator.GenerateAndSendReport();
        wordReportGenerator.GenerateAndSendReport();

    }
}