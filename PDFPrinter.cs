using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using H2H_App;
using iTextSharp.text;
using iTextSharp.text.pdf;

public class PDFPrinter
{
    public static void PrintInvoice(IEnumerable<DataGridViewRow> rows)
    {
        //string backgroundImagePath = "D:\\H2H_App\\H2H_App\\background.jpg";
        //Document doc = new Document();
        //PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Invoice.pdf", FileMode.Create));

        //doc.Open();

        //Image backgroundImage = Image.GetInstance(backgroundImagePath);
        //backgroundImage.SetAbsolutePosition(0, 0);
        //backgroundImage.ScaleAbsolute(doc.PageSize);
        //writer.DirectContent.AddImage(backgroundImage);

        //BaseFont arabicFont = BaseFont.CreateFont("D:\\H2H_App\\H2H_App\\bin\\Debug\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        //Font arabicCellFont = new Font(arabicFont, 12);

        //ArabicLigaturizer al = new ArabicLigaturizer();

        //PdfPTable table = new PdfPTable(2);
        //table.DefaultCell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
        //table.AddCell(new PdfPCell(new Phrase("Description", arabicCellFont)));
        //table.AddCell(new PdfPCell(new Phrase("Unit Price")));

        //foreach (DataGridViewRow row in rows)
        //{
        //    string money = row.Cells["اجمالي"].Value?.ToString();

        //    PdfPCell descriptionCell = new PdfPCell(new Phrase(al.Process(row.Cells["اسم المعامله"].Value?.ToString()), arabicCellFont));
        //    descriptionCell.HorizontalAlignment = Element.ALIGN_CENTER;
        //    table.AddCell(descriptionCell);

        //    PdfPCell unitPriceCell = new PdfPCell(new Phrase(money));
        //    unitPriceCell.HorizontalAlignment = Element.ALIGN_CENTER;
        //    table.AddCell(unitPriceCell);
        //}

        //table.TotalWidth = 500f;
        //table.WriteSelectedRows(0, -1, 50f, 700f, writer.DirectContent);

        //// Add the employee name, payment method,company name and total to the PDF
        //Chunk companyChunk = new Chunk("Company Name: " + al.Process(rows.First().Cells["اسم العميل"].Value?.ToString()), arabicCellFont);

        //Chunk employeeChunk = new Chunk("Employee: " + al.Process(rows.First().Cells["اسم الموظف"].Value?.ToString()), arabicCellFont);

        //Chunk paymentChunk = new Chunk("Payment Method: " + al.Process(rows.First().Cells["حالة التحصيل"].Value?.ToString()), arabicCellFont);

        //Chunk totalChunk = new Chunk("Total (After discount): " + CalculateDiscount(rows.Sum(row => Convert.ToInt32(row.Cells["اجمالي"].Value))).ToString(), arabicCellFont);

        //Chunk subtotalChunk = new Chunk("Subtotal: " + rows.Sum(row => Convert.ToInt32(row.Cells["اجمالي"].Value)).ToString(), arabicCellFont);

        //doc.Add(new Paragraph(companyChunk));
        //doc.Add(new Paragraph(employeeChunk));
        //doc.Add(new Paragraph(paymentChunk));
        //doc.Add(new Paragraph(totalChunk));
        //doc.Add(new Paragraph(subtotalChunk));

        //// Move the employee name, payment method, and total to the desired position
        //ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Paragraph(companyChunk), 50f, 510f, 0);
        //ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Paragraph(employeeChunk), 50f, 495f, 0);
        //ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Paragraph(paymentChunk), 50f, 480f, 0);
        //ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Paragraph(subtotalChunk), 50f, 465f, 0);
        //ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Paragraph(totalChunk), 50f, 450f, 0);

        //// Add today's date to the top left of the page
        //string dateFormat = "MM/dd/yyyy HH:mm:ss";
        //Chunk dateChunk2 = new Chunk(DateTime.Now.ToString(dateFormat));
        //dateChunk2.Font = FontFactory.GetFont(FontFactory.HELVETICA);
        //PdfPCell dateCell = new PdfPCell(new Phrase(dateChunk2));
        //dateCell.HorizontalAlignment = Element.ALIGN_LEFT;
        //dateCell.Border = PdfPCell.NO_BORDER;
        //PdfPTable dateTable = new PdfPTable(1);
        //dateTable.DefaultCell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
        //dateTable.TotalWidth = 600f;
        //dateTable.WidthPercentage = 100;
        //dateTable.AddCell(dateCell);
        //dateTable.WriteSelectedRows(0, -1, 50f, doc.PageSize.Height - 50f, writer.DirectContent);

        //// Close the document
        //doc.Close();

        //// Open the PDF file in the default PDF viewer
        //Process.Start("invoice.pdf");
    }

    //public static void PrintReports(IEnumerable<DataGridViewRow> rows, decimal totalOrderProfit, decimal sumOrderPaid, decimal sumOrderDeferred, decimal sumOrderAdvance,decimal sumVIsa,decimal sumCash)
    //{
    //    string backgroundImagePath = "C:\\Noor_work\\Projects\\H2H_App\\H2H_App\\background.jpg";
    //    Document doc = new Document();
    //    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Invoice.pdf", FileMode.Create));

    //    doc.Open();

    //    Image backgroundImage = Image.GetInstance(backgroundImagePath);
    //    backgroundImage.SetAbsolutePosition(0, 0);
    //    backgroundImage.ScaleAbsolute(doc.PageSize);
    //    writer.DirectContent.AddImage(backgroundImage);

    //    BaseFont arabicFont = BaseFont.CreateFont("C:\\Noor_work\\Projects\\H2H_App\\H2H_App\\bin\\Debug\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
    //    Font arabicCellFont = new Font(arabicFont, 12);

    //    ArabicLigaturizer al = new ArabicLigaturizer();

    //    PdfPTable table = new PdfPTable(2);
    //    table.DefaultCell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
    //    table.AddCell(new PdfPCell(new Phrase("Description", arabicCellFont)));
    //    table.AddCell(new PdfPCell(new Phrase("Unit Price")));

    //    foreach (DataGridViewRow row in rows)
    //    {
    //        string money = row.Cells["اجمالي"].Value?.ToString();

    //        PdfPCell descriptionCell = new PdfPCell(new Phrase(al.Process(row.Cells["اسم المعامله"].Value?.ToString()), arabicCellFont));
    //        descriptionCell.HorizontalAlignment = Element.ALIGN_CENTER;
    //        table.AddCell(descriptionCell);

    //        PdfPCell unitPriceCell = new PdfPCell(new Phrase(money));
    //        unitPriceCell.HorizontalAlignment = Element.ALIGN_CENTER;
    //        table.AddCell(unitPriceCell);
    //    }

    //    table.TotalWidth = 500f;
    //    table.WriteSelectedRows(0, -1, 50f, 700f, writer.DirectContent);

    //    // Add the employee name, payment method,company name and total to the PDF
    //    Chunk companyChunk = new Chunk("Company Name: " + al.Process(rows.First().Cells["اسم العميل"].Value?.ToString()), arabicCellFont);

    //    Chunk employeeChunk = new Chunk("Employee: " + al.Process(rows.First().Cells["اسم الموظف"].Value?.ToString()), arabicCellFont);

    //    Chunk paymentChunk = new Chunk("Payment Method: " + al.Process(rows.First().Cells["حالة التحصيل"].Value?.ToString()), arabicCellFont);

    //    Chunk totalChunk = new Chunk("Total (After discount): " + CalculateDiscount(rows.Sum(row => Convert.ToInt32(row.Cells["اجمالي"].Value))).ToString(), arabicCellFont);

    //    Chunk subtotalChunk = new Chunk("Subtotal: " + rows.Sum(row => Convert.ToInt32(row.Cells["اجمالي"].Value)).ToString(), arabicCellFont);

    //    doc.Add(new Paragraph(companyChunk));
    //    doc.Add(new Paragraph(employeeChunk));
    //    doc.Add(new Paragraph(paymentChunk));
    //    doc.Add(new Paragraph(totalChunk));
    //    doc.Add(new Paragraph(subtotalChunk));

    //    // Move the employee name, payment method, and total to the desired position
    //    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Paragraph(companyChunk), 50f, 510f, 0);
    //    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Paragraph(employeeChunk), 50f, 495f, 0);
    //    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Paragraph(paymentChunk), 50f, 480f, 0);
    //    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Paragraph(subtotalChunk), 50f, 465f, 0);
    //    ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_LEFT, new Paragraph(totalChunk), 50f, 450f, 0);

    //    // Add today's date to the top left of the page
    //    string dateFormat = "MM/dd/yyyy HH:mm:ss";
    //    Chunk dateChunk2 = new Chunk(DateTime.Now.ToString(dateFormat));
    //    dateChunk2.Font = FontFactory.GetFont(FontFactory.HELVETICA);
    //    PdfPCell dateCell = new PdfPCell(new Phrase(dateChunk2));
    //    dateCell.HorizontalAlignment = Element.ALIGN_LEFT;
    //    dateCell.Border = PdfPCell.NO_BORDER;
    //    PdfPTable dateTable = new PdfPTable(1);
    //    dateTable.DefaultCell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
    //    dateTable.TotalWidth = 600f;
    //    dateTable.WidthPercentage = 100;
    //    dateTable.AddCell(dateCell);
    //    dateTable.WriteSelectedRows(0, -1, 50f, doc.PageSize.Height - 50f, writer.DirectContent);

    //    // Close the document
    //    doc.Close();

    //    // Open the PDF file in the default PDF viewer
    //    Process.Start("invoice.pdf");
    //}

    //public static int CalculateDiscount(int money)
    //{
    //    //int discount = 0;
    //    //string discountText = Billing.dicountTb.Text;

    //    //if (!string.IsNullOrEmpty(discountText) && !discountText.Equals("نسبة الخصم(%)"))
    //    //{
    //    //    if (int.TryParse(discountText, out discount))
    //    //    {
    //    //        discount = (money * discount) / 100;
    //    //        money -= discount;
    //    //    }
    //    //    else
    //    //    {
    //    //        MessageBox.Show("Invalid discount amount. Please enter a valid number.");
    //    //    }
    //    //}
    //    //return money;
    //}
}
