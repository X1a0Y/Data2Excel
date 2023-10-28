namespace Data2Excel
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_New = new System.Windows.Forms.TabPage();
            this.button_txt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.button_resize = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_per_row_cell_num = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_row_height = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_col_width = new System.Windows.Forms.TextBox();
            this.tabPage_Add = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_num_col = new System.Windows.Forms.TextBox();
            this.textBox_target_cell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_save_add = new System.Windows.Forms.Button();
            this.button_run = new System.Windows.Forms.Button();
            this.textBox_row_count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_source_column = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_select_file = new System.Windows.Forms.Button();
            this.tabPage_Edit = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox_new_sheet = new System.Windows.Forms.CheckBox();
            this.checkBox_new_file = new System.Windows.Forms.CheckBox();
            this.button_edit_save = new System.Windows.Forms.Button();
            this.button_edit_run = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox_cells = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_end_rearrange_col = new System.Windows.Forms.TextBox();
            this.textBox_start_rearrange_clo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_end_keep_col = new System.Windows.Forms.TextBox();
            this.textBox_start_keep_col = new System.Windows.Forms.TextBox();
            this.button_select_edit_file = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage_New.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_Add.SuspendLayout();
            this.tabPage_Edit.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_New);
            this.tabControl1.Controls.Add(this.tabPage_Add);
            this.tabControl1.Controls.Add(this.tabPage_Edit);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(232, 321);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_New
            // 
            this.tabPage_New.Controls.Add(this.button_txt);
            this.tabPage_New.Controls.Add(this.panel1);
            this.tabPage_New.Controls.Add(this.button_select);
            this.tabPage_New.Controls.Add(this.groupBox3);
            this.tabPage_New.Controls.Add(this.groupBox2);
            this.tabPage_New.Controls.Add(this.groupBox1);
            this.tabPage_New.Location = new System.Drawing.Point(4, 22);
            this.tabPage_New.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_New.Name = "tabPage_New";
            this.tabPage_New.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_New.Size = new System.Drawing.Size(224, 295);
            this.tabPage_New.TabIndex = 0;
            this.tabPage_New.Text = "New";
            this.tabPage_New.UseVisualStyleBackColor = true;
            // 
            // button_txt
            // 
            this.button_txt.Location = new System.Drawing.Point(5, 214);
            this.button_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_txt.Name = "button_txt";
            this.button_txt.Size = new System.Drawing.Size(94, 25);
            this.button_txt.TabIndex = 5;
            this.button_txt.Text = "Output txt";
            this.button_txt.UseVisualStyleBackColor = true;
            this.button_txt.Click += new System.EventHandler(this.button_txt_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.button_resize);
            this.panel1.Location = new System.Drawing.Point(5, 174);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 25);
            this.panel1.TabIndex = 4;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(122, 0);
            this.button_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(94, 25);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_resize
            // 
            this.button_resize.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_resize.Location = new System.Drawing.Point(0, 0);
            this.button_resize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_resize.Name = "button_resize";
            this.button_resize.Size = new System.Drawing.Size(94, 25);
            this.button_resize.TabIndex = 0;
            this.button_resize.Text = "Resize Cell";
            this.button_resize.UseVisualStyleBackColor = true;
            this.button_resize.Click += new System.EventHandler(this.button_resize_Click);
            // 
            // button_select
            // 
            this.button_select.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_select.Location = new System.Drawing.Point(2, 137);
            this.button_select.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(220, 25);
            this.button_select.TabIndex = 3;
            this.button_select.Text = "Select Folder";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_per_row_cell_num);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(2, 92);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(220, 45);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // textBox_per_row_cell_num
            // 
            this.textBox_per_row_cell_num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_per_row_cell_num.Location = new System.Drawing.Point(2, 16);
            this.textBox_per_row_cell_num.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_per_row_cell_num.Name = "textBox_per_row_cell_num";
            this.textBox_per_row_cell_num.Size = new System.Drawing.Size(216, 21);
            this.textBox_per_row_cell_num.TabIndex = 0;
            this.textBox_per_row_cell_num.TextChanged += new System.EventHandler(this.textBox_per_row_cell_num_TextChanged);
            this.textBox_per_row_cell_num.Enter += new System.EventHandler(this.textBox_per_row_cell_num_Enter);
            this.textBox_per_row_cell_num.Leave += new System.EventHandler(this.textBox_per_row_cell_num_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_row_height);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(2, 47);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(220, 45);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // textBox_row_height
            // 
            this.textBox_row_height.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_row_height.Location = new System.Drawing.Point(2, 16);
            this.textBox_row_height.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_row_height.Name = "textBox_row_height";
            this.textBox_row_height.Size = new System.Drawing.Size(216, 21);
            this.textBox_row_height.TabIndex = 0;
            this.textBox_row_height.TextChanged += new System.EventHandler(this.textBox_row_height_TextChanged);
            this.textBox_row_height.Enter += new System.EventHandler(this.textBox_row_height_Enter);
            this.textBox_row_height.Leave += new System.EventHandler(this.textBox_row_height_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_col_width);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(220, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox_col_width
            // 
            this.textBox_col_width.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_col_width.Location = new System.Drawing.Point(2, 16);
            this.textBox_col_width.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_col_width.Name = "textBox_col_width";
            this.textBox_col_width.Size = new System.Drawing.Size(216, 21);
            this.textBox_col_width.TabIndex = 0;
            this.textBox_col_width.TextChanged += new System.EventHandler(this.textBox_col_width_TextChanged);
            this.textBox_col_width.Enter += new System.EventHandler(this.textBox_col_width_Enter);
            this.textBox_col_width.Leave += new System.EventHandler(this.textBox_col_width_Leave);
            // 
            // tabPage_Add
            // 
            this.tabPage_Add.Controls.Add(this.label4);
            this.tabPage_Add.Controls.Add(this.textBox_num_col);
            this.tabPage_Add.Controls.Add(this.textBox_target_cell);
            this.tabPage_Add.Controls.Add(this.label3);
            this.tabPage_Add.Controls.Add(this.button_save_add);
            this.tabPage_Add.Controls.Add(this.button_run);
            this.tabPage_Add.Controls.Add(this.textBox_row_count);
            this.tabPage_Add.Controls.Add(this.label2);
            this.tabPage_Add.Controls.Add(this.textBox_source_column);
            this.tabPage_Add.Controls.Add(this.label1);
            this.tabPage_Add.Controls.Add(this.button_select_file);
            this.tabPage_Add.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Add.Name = "tabPage_Add";
            this.tabPage_Add.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Add.Size = new System.Drawing.Size(224, 267);
            this.tabPage_Add.TabIndex = 1;
            this.tabPage_Add.Text = "Add";
            this.tabPage_Add.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "Column \"G\" Length";
            // 
            // textBox_num_col
            // 
            this.textBox_num_col.Location = new System.Drawing.Point(146, 114);
            this.textBox_num_col.Name = "textBox_num_col";
            this.textBox_num_col.Size = new System.Drawing.Size(65, 21);
            this.textBox_num_col.TabIndex = 21;
            this.textBox_num_col.Text = "A";
            this.textBox_num_col.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_num_col.TextChanged += new System.EventHandler(this.textBox_num_col_TextChanged);
            // 
            // textBox_target_cell
            // 
            this.textBox_target_cell.Location = new System.Drawing.Point(146, 83);
            this.textBox_target_cell.Name = "textBox_target_cell";
            this.textBox_target_cell.Size = new System.Drawing.Size(65, 21);
            this.textBox_target_cell.TabIndex = 20;
            this.textBox_target_cell.Text = "F";
            this.textBox_target_cell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_target_cell.TextChanged += new System.EventHandler(this.textBox_target_cell_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "Target Column";
            // 
            // button_save_add
            // 
            this.button_save_add.Location = new System.Drawing.Point(139, 175);
            this.button_save_add.Name = "button_save_add";
            this.button_save_add.Size = new System.Drawing.Size(71, 23);
            this.button_save_add.TabIndex = 18;
            this.button_save_add.Text = "Save";
            this.button_save_add.UseVisualStyleBackColor = true;
            this.button_save_add.Click += new System.EventHandler(this.button_save_add_Click);
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(16, 175);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(75, 23);
            this.button_run.TabIndex = 17;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // textBox_row_count
            // 
            this.textBox_row_count.Location = new System.Drawing.Point(146, 145);
            this.textBox_row_count.Name = "textBox_row_count";
            this.textBox_row_count.Size = new System.Drawing.Size(65, 21);
            this.textBox_row_count.TabIndex = 16;
            this.textBox_row_count.Text = "300";
            this.textBox_row_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_row_count.TextChanged += new System.EventHandler(this.textBox_row_count_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "Number Column";
            // 
            // textBox_source_column
            // 
            this.textBox_source_column.Location = new System.Drawing.Point(146, 52);
            this.textBox_source_column.Name = "textBox_source_column";
            this.textBox_source_column.Size = new System.Drawing.Size(65, 21);
            this.textBox_source_column.TabIndex = 14;
            this.textBox_source_column.Text = "H";
            this.textBox_source_column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_source_column.TextChanged += new System.EventHandler(this.textBox_info_column_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Source Column";
            // 
            // button_select_file
            // 
            this.button_select_file.Location = new System.Drawing.Point(13, 13);
            this.button_select_file.Name = "button_select_file";
            this.button_select_file.Size = new System.Drawing.Size(198, 23);
            this.button_select_file.TabIndex = 12;
            this.button_select_file.Text = "Select File";
            this.button_select_file.UseVisualStyleBackColor = true;
            this.button_select_file.Click += new System.EventHandler(this.button_select_file_Click);
            // 
            // tabPage_Edit
            // 
            this.tabPage_Edit.Controls.Add(this.progressBar1);
            this.tabPage_Edit.Controls.Add(this.groupBox7);
            this.tabPage_Edit.Controls.Add(this.button_edit_save);
            this.tabPage_Edit.Controls.Add(this.button_edit_run);
            this.tabPage_Edit.Controls.Add(this.groupBox6);
            this.tabPage_Edit.Controls.Add(this.groupBox5);
            this.tabPage_Edit.Controls.Add(this.groupBox4);
            this.tabPage_Edit.Controls.Add(this.button_select_edit_file);
            this.tabPage_Edit.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_Edit.Name = "tabPage_Edit";
            this.tabPage_Edit.Size = new System.Drawing.Size(224, 295);
            this.tabPage_Edit.TabIndex = 2;
            this.tabPage_Edit.Text = "Edit";
            this.tabPage_Edit.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox_new_sheet);
            this.groupBox7.Controls.Add(this.checkBox_new_file);
            this.groupBox7.Location = new System.Drawing.Point(8, 189);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Size = new System.Drawing.Size(200, 42);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "OutPut";
            // 
            // checkBox_new_sheet
            // 
            this.checkBox_new_sheet.AutoSize = true;
            this.checkBox_new_sheet.Checked = true;
            this.checkBox_new_sheet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_new_sheet.Location = new System.Drawing.Point(115, 18);
            this.checkBox_new_sheet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_new_sheet.Name = "checkBox_new_sheet";
            this.checkBox_new_sheet.Size = new System.Drawing.Size(78, 16);
            this.checkBox_new_sheet.TabIndex = 1;
            this.checkBox_new_sheet.Text = "New Sheet";
            this.checkBox_new_sheet.UseVisualStyleBackColor = true;
            this.checkBox_new_sheet.Click += new System.EventHandler(this.checkBox_new_sheet_Click);
            // 
            // checkBox_new_file
            // 
            this.checkBox_new_file.AutoSize = true;
            this.checkBox_new_file.Location = new System.Drawing.Point(6, 18);
            this.checkBox_new_file.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_new_file.Name = "checkBox_new_file";
            this.checkBox_new_file.Size = new System.Drawing.Size(72, 16);
            this.checkBox_new_file.TabIndex = 0;
            this.checkBox_new_file.Text = "New File";
            this.checkBox_new_file.UseVisualStyleBackColor = true;
            this.checkBox_new_file.Click += new System.EventHandler(this.checkBox_new_file_Click);
            // 
            // button_edit_save
            // 
            this.button_edit_save.Location = new System.Drawing.Point(137, 235);
            this.button_edit_save.Name = "button_edit_save";
            this.button_edit_save.Size = new System.Drawing.Size(71, 23);
            this.button_edit_save.TabIndex = 19;
            this.button_edit_save.Text = "Save";
            this.button_edit_save.UseVisualStyleBackColor = true;
            this.button_edit_save.Click += new System.EventHandler(this.button_edit_save_Click);
            // 
            // button_edit_run
            // 
            this.button_edit_run.Location = new System.Drawing.Point(10, 235);
            this.button_edit_run.Name = "button_edit_run";
            this.button_edit_run.Size = new System.Drawing.Size(75, 23);
            this.button_edit_run.TabIndex = 18;
            this.button_edit_run.Text = "Run";
            this.button_edit_run.UseVisualStyleBackColor = true;
            this.button_edit_run.Click += new System.EventHandler(this.button_edit_run_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox_cells);
            this.groupBox6.Location = new System.Drawing.Point(8, 138);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 45);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Number of cells in a rearranged row";
            // 
            // textBox_cells
            // 
            this.textBox_cells.Location = new System.Drawing.Point(111, 20);
            this.textBox_cells.Name = "textBox_cells";
            this.textBox_cells.Size = new System.Drawing.Size(83, 21);
            this.textBox_cells.TabIndex = 0;
            this.textBox_cells.Text = "1";
            this.textBox_cells.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.textBox_end_rearrange_col);
            this.groupBox5.Controls.Add(this.textBox_start_rearrange_clo);
            this.groupBox5.Location = new System.Drawing.Point(8, 93);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 45);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Columns to rearrange";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "-";
            // 
            // textBox_end_rearrange_col
            // 
            this.textBox_end_rearrange_col.Location = new System.Drawing.Point(111, 18);
            this.textBox_end_rearrange_col.Name = "textBox_end_rearrange_col";
            this.textBox_end_rearrange_col.Size = new System.Drawing.Size(83, 21);
            this.textBox_end_rearrange_col.TabIndex = 1;
            this.textBox_end_rearrange_col.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_start_rearrange_clo
            // 
            this.textBox_start_rearrange_clo.Location = new System.Drawing.Point(6, 18);
            this.textBox_start_rearrange_clo.Name = "textBox_start_rearrange_clo";
            this.textBox_start_rearrange_clo.Size = new System.Drawing.Size(83, 21);
            this.textBox_start_rearrange_clo.TabIndex = 0;
            this.textBox_start_rearrange_clo.Text = "D";
            this.textBox_start_rearrange_clo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBox_end_keep_col);
            this.groupBox4.Controls.Add(this.textBox_start_keep_col);
            this.groupBox4.Location = new System.Drawing.Point(8, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 45);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Columns to keep";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "-";
            // 
            // textBox_end_keep_col
            // 
            this.textBox_end_keep_col.Location = new System.Drawing.Point(111, 18);
            this.textBox_end_keep_col.Name = "textBox_end_keep_col";
            this.textBox_end_keep_col.Size = new System.Drawing.Size(83, 21);
            this.textBox_end_keep_col.TabIndex = 1;
            this.textBox_end_keep_col.Text = "C";
            this.textBox_end_keep_col.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_start_keep_col
            // 
            this.textBox_start_keep_col.Location = new System.Drawing.Point(6, 18);
            this.textBox_start_keep_col.Name = "textBox_start_keep_col";
            this.textBox_start_keep_col.Size = new System.Drawing.Size(83, 21);
            this.textBox_start_keep_col.TabIndex = 0;
            this.textBox_start_keep_col.Text = "A";
            this.textBox_start_keep_col.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_select_edit_file
            // 
            this.button_select_edit_file.Location = new System.Drawing.Point(8, 13);
            this.button_select_edit_file.Name = "button_select_edit_file";
            this.button_select_edit_file.Size = new System.Drawing.Size(198, 23);
            this.button_select_edit_file.TabIndex = 13;
            this.button_select_edit_file.Text = "Select File";
            this.button_select_edit_file.UseVisualStyleBackColor = true;
            this.button_select_edit_file.Click += new System.EventHandler(this.button_select_file_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Silver;
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(10, 264);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(198, 23);
            this.progressBar1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 321);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_New.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_Add.ResumeLayout(false);
            this.tabPage_Add.PerformLayout();
            this.tabPage_Edit.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_New;
        private System.Windows.Forms.TabPage tabPage_Add;
        private System.Windows.Forms.TabPage tabPage_Edit;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_per_row_cell_num;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_row_height;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_col_width;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_resize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_num_col;
        private System.Windows.Forms.TextBox textBox_target_cell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_save_add;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.TextBox textBox_row_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_source_column;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_select_file;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_end_rearrange_col;
        private System.Windows.Forms.TextBox textBox_start_rearrange_clo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_end_keep_col;
        private System.Windows.Forms.TextBox textBox_start_keep_col;
        private System.Windows.Forms.Button button_select_edit_file;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox_cells;
        private System.Windows.Forms.Button button_edit_save;
        private System.Windows.Forms.Button button_edit_run;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox checkBox_new_sheet;
        private System.Windows.Forms.CheckBox checkBox_new_file;
        private System.Windows.Forms.Button button_txt;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

