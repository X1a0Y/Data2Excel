using Excel;
using Office;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;
using Ookii.Dialogs.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Data2Excel
{
    public partial class Form1 : Form
    {
        //11
        public string watermarkText1 = "Column Width";
        public string watermarkText2 = "Row Height";
        public string watermarkText3 = "Number of cells added per row";

        public double col_width = 0;
        public double row_height = 0;
        public int cell_per_row = 0;
        public int count_in;
        public List<int> lst_need_change_col = new List<int>();
        public List<int> lst_need_change_row = new List<int>();
        public Worksheet mysheet;
        public Workbook myworkbook;
        public Excel.Application app;

        public string folder_path;
        //22
        //Worksheet mysheet;
        //Excel.Application app;
        int offset = 0;
        int source_cell_idx = 8;
        int target_cell_idx = 6;
        int column_G_length = 300;
        int num_col_idx = 1;
        Dictionary<int, List<int>> copy_source = new Dictionary<int, List<int>>();
        Dictionary<int, int> copy_col = new Dictionary<int, int>();
        string filename = null;


        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = button_select;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 获取屏幕的大小
            System.Drawing.Rectangle screenRect = Screen.PrimaryScreen.WorkingArea;

            // 计算窗体左上角的坐标使其位于屏幕中央
            int left = (screenRect.Width - this.Width) / 2;
            int top = (screenRect.Height - this.Height) / 2;

            // 设置窗体位置
            this.Location = new System.Drawing.Point(left, top);


            textBox_col_width.Text = watermarkText1;
            textBox_col_width.ForeColor = Color.Gray;

            textBox_row_height.Text = watermarkText2;
            textBox_row_height.ForeColor = Color.Gray;

            textBox_per_row_cell_num.Text = watermarkText3;
            textBox_per_row_cell_num.ForeColor = Color.Gray;
        }

        private void TextBoxEnter(TextBox textBox, string watermarkText)
        {
            if (textBox.Text == watermarkText)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void TextBoxLeave(TextBox textBox, string watermarkText)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = watermarkText;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void textBox_col_width_Enter(object sender, EventArgs e)
        {
            TextBoxEnter((TextBox)sender, watermarkText1);
        }

        private void textBox_col_width_Leave(object sender, EventArgs e)
        {
            TextBoxLeave((TextBox)sender, watermarkText1);
        }

        private void textBox_row_height_Enter(object sender, EventArgs e)
        {
            TextBoxEnter((TextBox)sender, watermarkText2);
        }

        private void textBox_row_height_Leave(object sender, EventArgs e)
        {
            TextBoxLeave((TextBox)sender, watermarkText2);
        }

        private void textBox_per_row_cell_num_Enter(object sender, EventArgs e)
        {
            TextBoxEnter((TextBox)sender, watermarkText3);
        }

        private void textBox_per_row_cell_num_Leave(object sender, EventArgs e)
        {
            TextBoxLeave((TextBox)sender, watermarkText3);
        }


        private void textBox_col_width_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(((TextBox)sender).Text, out col_width);
        }

        private void textBox_row_height_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(((TextBox)sender).Text, out row_height);
        }

        private void textBox_per_row_cell_num_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(((TextBox)sender).Text, out cell_per_row);
        }

        private void button_select_Click(object sender, EventArgs e)
        {

            double.TryParse(textBox_col_width.Text, out col_width);
            double.TryParse(textBox_row_height.Text, out row_height);
            int.TryParse(textBox_per_row_cell_num.Text, out cell_per_row);

            //FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.Description = "Choose Folder";
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    folder_path = dialog.SelectedPath;
            //}
            VistaFolderBrowserDialog folderBrowserDialog = new VistaFolderBrowserDialog();
            folderBrowserDialog.Description = "Choose Folder";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folder_path = folderBrowserDialog.SelectedPath;
                // 使用 selectedFolderPath 进行后续操作
            }
            else
            {
                return;
            }

            app = new Excel.Application();
            app.Visible = true;
            myworkbook = app.Workbooks.Add();
            mysheet = myworkbook.Sheets[1];
            //mysheet.Name = "Sheet1";

            //workbook.SaveAs(filePath);
            ProcessFolder(mysheet, folder_path, 1, 1);
        }


        public void ProcessFolder(Excel.Worksheet sheet, string folderPath, int startRow, int startCol)
        {
            if (!lst_need_change_row.Contains(startRow))
            {
                lst_need_change_row.Add(startRow);
            }
            if (!lst_need_change_col.Contains(startCol))
            {
                lst_need_change_col.Add(startCol);
            }

            ChangeColWidth(sheet, startCol);
            ChangeRowHeight(sheet, startRow);

            sheet.Cells[startRow, startCol] = Path.GetFileName(folderPath);

            string[] subfolders = Directory.GetDirectories(folderPath);
            string[] files = Directory.GetFiles(folderPath);

            string[] pngFiles = Array.FindAll(files, s => s.EndsWith(".png", StringComparison.OrdinalIgnoreCase));
            int cur_col = startCol + 1;
            int cur_pic_idx = 0;
            int lenpng = pngFiles.Length;

            while (lenpng > 0)
            {
                int range_each = cell_per_row > 0 ? Math.Min(lenpng, cell_per_row) : lenpng;
                for (int i = 0; i < range_each; i++)
                {
                    string imgName = pngFiles[cur_pic_idx];
                    cur_pic_idx++;
                    AddImage(sheet, imgName, startRow, cur_col + i);
                }
                if (cell_per_row <= 0)
                {
                    break;
                }
                lenpng = lenpng - cell_per_row;
                if (lenpng > 0)
                {
                    startRow++;
                }
            }

            //for (int i = 0; i < pngFiles.Length; i++)
            //{

            //    //startRow++;
            //}

            if (subfolders.Length > 0)
            {
                foreach (string subfolderPath in subfolders)
                {
                    ProcessFolder(sheet, subfolderPath, startRow + 1, startCol + 1);
                    startRow = count_in;
                }
            }
            else
            {
                count_in = startRow;
            }
        }

        public void AddImage(Worksheet sheet, string image_path, int start_row, int start_col)
        {
            Image image = Image.FromFile(image_path);
            if (!lst_need_change_col.Contains(start_col))
            {
                lst_need_change_col.Add(start_col);
            }
            if (!lst_need_change_row.Contains(start_row))
            {
                lst_need_change_row.Add(start_row);
            }

            ChangeColWidth(sheet, start_col);
            ChangeRowHeight(sheet, start_row);
            var cellRange = sheet.Cells[start_row, start_col];



            // 插入图片并将其锚定到单元格
            var picture = sheet.Shapes.AddPicture(image_path, MsoTriState.msoFalse, MsoTriState.msoCTrue, cellRange.Left, cellRange.Top, image.Width / 2, image.Height / 2);
        }


        public void ChangeColWidth(Worksheet sheet, int start_col)
        {
            if (col_width > 0)
            {
                var mycolumn = sheet.Columns[start_col];
                mycolumn.ColumnWidth = col_width;

            }
        }

        public void ChangeRowHeight(Worksheet sheet, int start_row)
        {
            if (row_height > 0)
            {
                var myrow = sheet.Rows[start_row];
                myrow.RowHeight = row_height;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (app != null)
            {
                app.Quit();
                filename = null;
            }

        }

        private void button_resize_Click(object sender, EventArgs e)
        {
            if (folder_path == null)
            {
                MessageBox.Show("Please Select Folder");
                return;
            }
            foreach (var item in lst_need_change_col)
            {
                ChangeColWidth(mysheet, item);
            }
            foreach (var item in lst_need_change_row)
            {
                ChangeRowHeight(mysheet, item);
            }

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (folder_path == null)
            {
                MessageBox.Show("Please Select Folder");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save File";
            saveFileDialog.Filter = "Excel File (*.xlsx)|*.xlsx|所有文件 (*.*)|*.*";
            saveFileDialog.DefaultExt = "*.xlsx";
            saveFileDialog.FileName = "mysheet";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                mysheet.SaveAs(saveFileDialog.FileName);

                app.Quit();
                folder_path = null;
            }
        }



        //22
        private void button_select_file_Click(object sender, EventArgs e)
        {
            string filefullname = null;
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Choose Excel File";
            openfile.Filter = "Excel File (*.xlsx;*.xls;*.csv)|*.xlsx;*.xls;*.csv|所有文件 (*.*)|*.*";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                // 获取所选文件的路径
                filefullname = openfile.FileName;
                filename = openfile.SafeFileName;

            }
            else
            {

                //MessageBox.Show("Please Choose File");
                return;
            }
            app = new Excel.Application();
            app.Visible = true;
            Workbook myworkbook = app.Workbooks.Open(filefullname);
            mysheet = myworkbook.Sheets[1];
            ;

        }
        // 将Excel列字母转换为列数字
        static int ColumnLetterToNumber(string columnLetter)
        {
            int result = 0;
            int length = columnLetter.Length;

            for (int i = 0; i < length; i++)
            {
                char letter = columnLetter[i];
                int value = letter - 'A' + 1; // 将字母转换为对应的数字，A=1，B=2，C=3，...

                // 计算列数字
                result = result * 26 + value;
            }

            return result;
        }

        private void textBox_info_column_TextChanged(object sender, EventArgs e)
        {
            source_cell_idx = ColumnLetterToNumber(textBox_source_column.Text);
        }

        private void textBox_row_count_TextChanged(object sender, EventArgs e)
        {
            column_G_length = int.Parse(textBox_row_count.Text);
        }

        public void CalcCell()
        {
            //textBox1.AppendText("CalcCell In" + Environment.NewLine);
            Range range;
            List<string> number_cell_value = new List<string>(); ;
            for (int i = 1; i < column_G_length + 1; i++)
            {
                //textBox1.AppendText($"mysheet.cells[{i},{source_cell_idx - 1}]" + Environment.NewLine);
                range = mysheet.Cells[i, source_cell_idx - 1];//"G列在设置的H列左侧"

                //copy_col.Add(i, 6);
                if (range.Value != null)
                {
                    foreach (var each_value in range.Value.ToString().Split(','))
                    {
                        number_cell_value.Add(each_value);
                    }
                    copy_source.Add(i, new List<int>());
                    foreach (string number in number_cell_value)
                    {
                        //textBox1.AppendText($"copy_source[{i},{int.Parse(number)}]" + Environment.NewLine);
                        copy_source[i].Add(int.Parse(number));
                    }
                    number_cell_value.Clear();
                }
            }
        }

        public void CopyCell()
        {
            //textBox1.AppendText("CopyCell IN" + Environment.NewLine);
            Range source_cell;
            Range target_cell;
            foreach (int key in copy_source.Keys)
            {
                //textBox1.AppendText($"Source_Cell[{key},{source_cell_idx}]" + Environment.NewLine);
                source_cell = mysheet.Cells[key, source_cell_idx];

                foreach (int value in copy_source[key])
                {
                    int col = value - offset;
                    //textBox1.AppendText($"int col:{col}" + Environment.NewLine);
                    if (col < 1)
                    {
                        continue;
                    }
                    if (!copy_col.Keys.Contains(col))
                    {
                        copy_col.Add(col, target_cell_idx);
                    }
                    //textBox1.AppendText($"Target_cell[{col},{copy_col[col]}]" + Environment.NewLine);
                    target_cell = mysheet.Cells[col, copy_col[col]];

                    if (source_cell.Value != null)
                    {
                        copy_col[col]++;
                    }
                    source_cell.Copy();
                    target_cell.PasteSpecial();

                }
            }
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            if (filename == null)
            {
                MessageBox.Show("Please Select File");
                return;
            }
            num_col_idx = ColumnLetterToNumber(textBox_num_col.Text);
            Range cell_1_1 = mysheet.Cells[1, num_col_idx];
            try
            {
                offset = int.Parse(cell_1_1.Value.ToString()) - 1;
            }
            catch
            {
                MessageBox.Show("Please Choose Right Number Colunm");
                return;
            }

            //MessageBox.Show(ColumnLetterToNumber("AA").ToString())
            try
            {
                CalcCell();

                CopyCell();
                MessageBox.Show("ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace);
            }
            finally
            {
                copy_col.Clear();
                copy_source.Clear();
            }



        }

        private void textBox_target_cell_TextChanged(object sender, EventArgs e)
        {
            target_cell_idx = ColumnLetterToNumber(textBox_target_cell.Text);
        }

        private void textBox_num_col_TextChanged(object sender, EventArgs e)
        {
            num_col_idx = ColumnLetterToNumber(textBox_num_col.Text);
        }
    }
}
