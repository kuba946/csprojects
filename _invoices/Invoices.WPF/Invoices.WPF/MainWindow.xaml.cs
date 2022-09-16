using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Invoices.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Uri iconUri = new Uri("pack://application:,,,/Icon1.ico", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(iconUri);
            //generateInvoice();
            //Environment.Exit(0);
        }
        private void generateInvoice()
        {
            //percentage.Text = "clicked!";
            DateTime today = DateTime.Now;
            int month = today.Month;
            string monthAsString = month.ToString();
            if (month < 10) { monthAsString = "0" + monthAsString; }
            int day = today.Day;
            string dayAsString = day.ToString();
            if (day < 10) { dayAsString = "0" + dayAsString; }
            int fontSize = 11;


            FileStream fs = new FileStream("faktura-" + today.Year + "-" + monthAsString + "-NEW_INT.pdf", FileMode.Create);

            var path = @"data\data.txt";
            //string content = File.ReadAllText(path, Encoding.UTF8);
            string[] content = new string[100];
            int i = 0;
            foreach (string line in File.ReadLines(path, Encoding.UTF8))
            {
                content[i] = line;
                i++;
            }

            Document document = new Document(iTextSharp.text.PageSize.A4, 60, 60, 60, 60);
            PdfWriter pw = PdfWriter.GetInstance(document, fs);


            //iTextSharp.text.Paragraph para = new iTextSharp.text.Paragraph("asdf");
            iTextSharp.text.Paragraph para = new iTextSharp.text.Paragraph();

            /*iTextSharp.text.Paragraph*/ para = new iTextSharp.text.Paragraph(content[0] + monthAsString + "/" + today.Year.ToString()/*content[0] + "08" + "/" + "2022"*/, new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize))
            {
                Alignment = Element.ALIGN_CENTER
            };
            document.Open();
            document.Add(para);

            para = new iTextSharp.text.Paragraph(content[1], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize))
            {
                Alignment = Element.ALIGN_CENTER
            };
            document.Add(para);

            //TABELA Z DATA I MIEJSCEM
            PdfPTable dateAndPlace = new PdfPTable(2);
            dateAndPlace.WidthPercentage = 100;

            dateAndPlace.DefaultCell.Border = PdfPCell.NO_BORDER;
            dateAndPlace.SpacingBefore = 20f;
            para = new iTextSharp.text.Paragraph(content[2], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT,
                Border = PdfPCell.NO_BORDER
            };
            dateAndPlace.AddCell(cell);

            para = new iTextSharp.text.Paragraph("WARSZAWA " + today.Year + "-" + monthAsString + "-" + dayAsString/*"WARSZAWA " + "2022" + "-" + "08" + "-" + "31"*/, new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT,
                Border = PdfPCell.NO_BORDER
            };
            dateAndPlace.AddCell(cell);

            int daysNumber = DateTime.DaysInMonth(today.Year, today.Month);
            para = new iTextSharp.text.Paragraph(content[3], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            dateAndPlace.AddCell(para); para = new iTextSharp.text.Paragraph("od " + "01." + monthAsString + " do " + daysNumber.ToString() + "." + monthAsString + "." + today.Year/*"od " + "01." + "08" + " do " + "31" + "." + "08" + "." + "2022"*/, new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT,
                Border = PdfPCell.NO_BORDER
            };
            dateAndPlace.AddCell(cell);

            document.Add(dateAndPlace);

            para = new iTextSharp.text.Paragraph(content[4], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize))
            {
                SpacingBefore = 20f
            };
            document.Add(para);

            para = new iTextSharp.text.Paragraph(content[5], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            document.Add(para);

            para = new iTextSharp.text.Paragraph(content[6], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            document.Add(para);

            para = new iTextSharp.text.Paragraph(content[7], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            document.Add(para);

            para = new iTextSharp.text.Paragraph(content[8], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize))
            {
                SpacingBefore = 20f
            };
            document.Add(para);

            para = new iTextSharp.text.Paragraph(content[9], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            document.Add(para);

            para = new iTextSharp.text.Paragraph(content[10], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            document.Add(para);

            para = new iTextSharp.text.Paragraph(content[11], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            document.Add(para);

            para = new iTextSharp.text.Paragraph(content[12], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arialbd.ttf", BaseFont.CP1250, true), fontSize))
            {
                SpacingBefore = 20f,

            };
            document.Add(para);

            para = new iTextSharp.text.Paragraph(content[13], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arialbd.ttf", BaseFont.CP1250, true), fontSize));
            document.Add(para);

            //TABELA Z OPISEM USLUG
            PdfPTable serviceTable = new PdfPTable(8);
            serviceTable.WidthPercentage = 100;
            serviceTable.SpacingBefore = 20f;
            float[] widths = new float[] { 20f, 160f, 40f, 70f, 50f, 20f, 50f, 50f };
            serviceTable.SetWidths(widths);

            para = new iTextSharp.text.Paragraph(content[14], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                Rowspan = 2
            };
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[15], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                Rowspan = 2
            };
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[16], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                Rowspan = 2
            };
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[17], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                Rowspan = 2
            };
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[18], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                Rowspan = 2
            };
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[19], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                Colspan = 2
            };
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[20], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                Rowspan = 2
            };
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[21], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[22], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[23], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[24]/* + today.Year + "/" + monthAsString + "/01"*/, new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[25], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            serviceTable.AddCell(cell);

            float.TryParse(content[26], out float basis);
            float.TryParse(percentage.Text, out float percent);
            float netto = (float)(basis * percent / 100.000);
            para = new iTextSharp.text.Paragraph(string.Format("{0:0.00}", netto), new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            serviceTable.AddCell(cell);
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[27], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            serviceTable.AddCell(cell);

            float.TryParse(content[27], out float vatPercent);
            float tara = (float)(netto * vatPercent / 100.00);
            para = new iTextSharp.text.Paragraph(string.Format("{0:0.00}", tara), new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            serviceTable.AddCell(cell);

            float brutto = (float)(netto + tara);
            para = new iTextSharp.text.Paragraph(string.Format("{0:0.00}", brutto), new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[28], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                Border = PdfPCell.NO_BORDER
            };
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[29], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                Border = PdfPCell.NO_BORDER
            };
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[30], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                Border = PdfPCell.NO_BORDER
            };
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[31], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(string.Format("{0:0.00}", netto), new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[27], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(string.Format("{0:0.00}", tara), new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(string.Format("{0:0.00}", brutto), new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            serviceTable.AddCell(cell);

            int minimumHeight = 50;

            para = new iTextSharp.text.Paragraph(content[32], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                Border = PdfPCell.NO_BORDER
            };
            cell.MinimumHeight = minimumHeight;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[33], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                Border = PdfPCell.NO_BORDER
            };
            cell.MinimumHeight = minimumHeight;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[34], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                Border = PdfPCell.NO_BORDER
            };
            cell.MinimumHeight = minimumHeight;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[35], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            cell.MinimumHeight = minimumHeight;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(string.Format("{0:0.00}", netto), new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            cell.MinimumHeight = minimumHeight;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[27], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            cell.MinimumHeight = minimumHeight;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(string.Format("{0:0.00}", tara), new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            cell.MinimumHeight = minimumHeight;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            serviceTable.AddCell(cell);

            para = new iTextSharp.text.Paragraph(string.Format("{0:0.00}", brutto), new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para));
            cell.MinimumHeight = minimumHeight;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            serviceTable.AddCell(cell);

            document.Add(serviceTable);

            string bruttoAsString = string.Format("{0:0.00}", brutto);
            float.TryParse(bruttoAsString, out float bruttoZaokr);

            string kwotaSlownie = slownie(bruttoZaokr);


            para = new iTextSharp.text.Paragraph(content[36] + kwotaSlownie, new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arialbd.ttf", BaseFont.CP1250, true), fontSize + 1))
            {
                SpacingBefore = 40f,
                Alignment = Element.ALIGN_CENTER
            };
            document.Add(para);

            PdfPTable sign = new PdfPTable(2);
            sign.WidthPercentage = 100;

            sign.DefaultCell.Border = PdfPCell.NO_BORDER;
            sign.SpacingBefore = 150f;
            para = new iTextSharp.text.Paragraph(content[37], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arialbd.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT,
                Border = PdfPCell.NO_BORDER
            };
            sign.AddCell(cell);

            para = new iTextSharp.text.Paragraph(content[38], new Font(BaseFont.CreateFont(@"C:\Windows\Fonts\Arialbd.ttf", BaseFont.CP1250, true), fontSize));
            cell = new PdfPCell(new iTextSharp.text.Phrase(para))
            {
                HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT,
                Border = PdfPCell.NO_BORDER
            };
            sign.AddCell(cell);
            document.Add(sign);

            document.Close();
        }
        private void invoice_Click(object sender, RoutedEventArgs e)
        {
            ((Storyboard)Resources["animacja"]).Begin();
            generateInvoice();
        }

        private void percentage_GotFocus(object sender, RoutedEventArgs e)
        {
            percentage.Text = "";
        }

        private void percentage_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(percentage.Text))
            {
                percentage.Text = "100";
            }
        }

        private string slownie(float num)
        {
            //var str=prompt("podaj liczbe: ");
            var result = "";
            //num=28712.5542;
            var str = num.ToString();
            //str="12300.5";
            var l = str.Length;

            if (str[l - 2] == '.' || str[l - 2] == ',') { str += "0"; }
            l = str.Length;
            if (str[l - 3] != '.' && str[l - 3] != ',') { str += ".00"; }

            l = str.Length;

            switch (l)
            {
                case 8:
                    //================= TYSIĄCE
                    switch (str[0])
                    {
                        case '1':
                            result += Under20(str[1]);
                            break;
                        default:
                            result += Above20(str[0], str[1]);
                            break;
                    }
                    if (str[1] == '1' || str[0] == '1')
                    {
                        result += " tysięcy";
                    }
                    else if (str[1] == '2' || str[1] == '3' || str[1] == '4')
                    {
                        result += " tysiące";
                    }
                    else
                    {
                        result += " tysięcy";
                    }
                    //============ TYSIĄCE
                    break;
                case 7:
                    //================= TYSIĄCE
                    result += Under10(str[0]);
                    if (str[0] == '1')
                    {
                        result += " tysiąc";
                    }
                    else if (str[0] == '2' || str[0] == '3' || str[0] == '4')
                    {
                        result += " tysiące";
                    }
                    else
                    {
                        result += " tysięcy";
                    }
                    //============ TYSIĄCE
                    break;
            }
            //console.log(result);
            //============== SETKI
            switch (str[l - 6])
            {
                case '0':
                    break;
                default:
                    result += " " + Hundred(str[l - 6]);
                    break;
            }
            //========== SETKI
            //console.log(result);
            //=========== JENDOSCI
            switch (str[l - 5])
            {
                case '0':
                    if (str[l - 4] == '0') { result += ""; }
                    else { result += " " + Under10(str[l - 4]); }
                    break;
                case '1':
                    result += " " + Under20(str[l - 4]);
                    break;
                default:
                    result += " " + Above20(str[l - 5], str[l - 4]);
                    break;
            }
            //============== JEDNOSCI

            if (str[l - 5] == '1') { result += " " + "złotych"; }
            else if (str[l - 4] == '2' || str[l - 4] == '3' || str[l - 4] == '4') { result += " " + "złote"; }
            else { result += " " + "złotych"; }

            //=============== GROSZE
            result += " " + str[l - 2] + str[l - 1] + "/100";
            //=============== GROSZE

            //document.getElementById("wynik").innerHTML = result;
            return result;
        }
        private string Under10(char a)
        {
            var result = "";
            switch (a)
            {
                case '0':
                    result += "";
                    break;
                case '1':
                    result += "jeden";
                    break;
                case '2':
                    result += "dwa";
                    break;
                case '3':
                    result += "trzy";
                    break;
                case '4':
                    result += "cztery";
                    break;
                case '5':
                    result += "pięć";
                    break;
                case '6':
                    result += "sześć";
                    break;
                case '7':
                    result += "siedem";
                    break;
                case '8':
                    result += "osiem";
                    break;
                case '9':
                    result += "dziewięć";
                    break;
            }
            return result;
        }
        private string Under20(char a)
        {
            //
            var result = "";
            switch (a)
            {
                case '0':
                    result += "dziesięć";
                    break;
                case '1':
                    result += "jedenaście";
                    break;
                case '2':
                    result += "dwanaście";
                    break;
                case '3':
                    result += "trzynaście";
                    break;
                case '4':
                    result += "czternaście";
                    break;
                case '5':
                    result += "piętnaście";
                    break;
                case '6':
                    result += "szesnaście";
                    break;
                case '7':
                    result += "siedemnaście";
                    break;
                case '8':
                    result += "osiemnaście";
                    break;
                case '9':
                    result += "dziewiętnaście";
                    break;
            }
            return result;
        }
        private string SecondDigitAbove20(char a)
        {
            var result = "";
            switch (a)
            {
                case '0':
                    result += "";
                    break;
                case '1':
                    result += " jeden";
                    break;
                case '2':
                    result += " dwa";
                    break;
                case '3':
                    result += " trzy";
                    break;
                case '4':
                    result += " cztery";
                    break;
                case '5':
                    result += " pięć";
                    break;
                case '6':
                    result += " sześć";
                    break;
                case '7':
                    result += " siedem";
                    break;
                case '8':
                    result += " osiem";
                    break;
                case '9':
                    result += " dziewięć";
                    break;
            }
            return result;
        }
        private string Above20(char a, char b)
        {
            //
            var result = "";
            switch (a)
            {
                case '2':
                    result += "dwadzieścia";
                    break;
                case '3':
                    result += "trzydzieści";
                    break;
                case '4':
                    result += "czterdzieści";
                    break;
                case '5':
                    result += "pięćdziesiąt";
                    break;
                case '6':
                    result += "sześćdziesiąt";
                    break;
                case '7':
                    result += "siedemdziesiąt";
                    break;
                case '8':
                    result += "osiemdziesiąt";
                    break;
                case '9':
                    result += "dziewięćdziesiąt";
                    break;
            }
            result += SecondDigitAbove20(b);
            return result;
        }
        private string Hundred(char a)
        {
            var result = "";
            switch (a)
            {
                case '1':
                    result += "sto";
                    break;
                case '2':
                    result += "dwieście";
                    break;
                case '3':
                    result += "trzysta";
                    break;
                case '4':
                    result += "czterysta";
                    break;
                case '5':
                    result += "pięćset";
                    break;
                case '6':
                    result += "sześćset";
                    break;
                case '7':
                    result += "siedemset";
                    break;
                case '8':
                    result += "osiemset";
                    break;
                case '9':
                    result += "dziewięćset";
                    break;
            }
            return result;
        }
    }
}
