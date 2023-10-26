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
            this.tabPage_Add = new System.Windows.Forms.TabPage();
            this.tabPage_Edit = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_col_width = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_row_height = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_per_row_cell_num = new System.Windows.Forms.TextBox();
            this.button_select = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_resize = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_num_col = new System.Windows.Forms.TextBox();
            this.textBox_target_cell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_run = new System.Windows.Forms.Button();
            this.textBox_row_count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_source_column = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_select_file = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_New.SuspendLayout();
            this.tabPage_Add.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_New);
            this.tabControl1.Controls.Add(this.tabPage_Add);
            this.tabControl1.Controls.Add(this.tabPage_Edit);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 356);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_New
            // 
            this.tabPage_New.Controls.Add(this.panel1);
            this.tabPage_New.Controls.Add(this.button_select);
            this.tabPage_New.Controls.Add(this.groupBox3);
            this.tabPage_New.Controls.Add(this.groupBox2);
            this.tabPage_New.Controls.Add(this.groupBox1);
            this.tabPage_New.Location = new System.Drawing.Point(4, 28);
            this.tabPage_New.Name = "tabPage_New";
            this.tabPage_New.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_New.Size = new System.Drawing.Size(340, 324);
            this.tabPage_New.TabIndex = 0;
            this.tabPage_New.Text = "New";
            this.tabPage_New.UseVisualStyleBackColor = true;
            // 
            // tabPage_Add
            // 
            this.tabPage_Add.Controls.Add(this.label4);
            this.tabPage_Add.Controls.Add(this.textBox_num_col);
            this.tabPage_Add.Controls.Add(this.textBox_target_cell);
            this.tabPage_Add.Controls.Add(this.label3);
            this.tabPage_Add.Controls.Add(this.button1);
            this.tabPage_Add.Controls.Add(this.button_run);
            this.tabPage_Add.Controls.Add(this.textBox_row_count);
            this.tabPage_Add.Controls.Add(this.label2);
            this.tabPage_Add.Controls.Add(this.textBox_source_column);
            this.tabPage_Add.Controls.Add(this.label1);
            this.tabPage_Add.Controls.Add(this.button_select_file);
            this.tabPage_Add.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Add.Name = "tabPage_Add";
            this.tabPage_Add.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Add.Size = new System.Drawing.Size(340, 324);
            this.tabPage_Add.TabIndex = 1;
            this.tabPage_Add.Text = "Add";
            this.tabPage_Add.UseVisualStyleBackColor = true;
            // 
            // tabPage_Edit
            // 
            this.tabPage_Edit.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Edit.Name = "tabPage_Edit";
            this.tabPage_Edit.Size = new System.Drawing.Size(792, 418);
            this.tabPage_Edit.TabIndex = 2;
            this.tabPage_Edit.Text = "Edit";
            this.tabPage_Edit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_col_width);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox_col_width
            // 
            this.textBox_col_width.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_col_width.Location = new System.Drawing.Point(3, 24);
            this.textBox_col_width.Name = "textBox_col_width";
            this.textBox_col_width.Size = new System.Drawing.Size(328, 28);
            this.textBox_col_width.TabIndex = 0;
            this.textBox_col_width.TextChanged += new System.EventHandler(this.textBox_col_width_TextChanged);
            this.textBox_col_width.Enter += new System.EventHandler(this.textBox_col_width_Enter);
            this.textBox_col_width.Leave += new System.EventHandler(this.textBox_col_width_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_row_height);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // textBox_row_height
            // 
            this.textBox_row_height.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_row_height.Location = new System.Drawing.Point(3, 24);
            this.textBox_row_height.Name = "textBox_row_height";
            this.textBox_row_height.Size = new System.Drawing.Size(328, 28);
            this.textBox_row_height.TabIndex = 0;
            this.textBox_row_height.TextChanged += new System.EventHandler(this.textBox_row_height_TextChanged);
            this.textBox_row_height.Enter += new System.EventHandler(this.textBox_row_height_Enter);
            this.textBox_row_height.Leave += new System.EventHandler(this.textBox_row_height_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_per_row_cell_num);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // textBox_per_row_cell_num
            // 
            this.textBox_per_row_cell_num.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_per_row_cell_num.Location = new System.Drawing.Point(3, 24);
            this.textBox_per_row_cell_num.Name = "textBox_per_row_cell_num";
            this.textBox_per_row_cell_num.Size = new System.Drawing.Size(328, 28);
            this.textBox_per_row_cell_num.TabIndex = 0;
            this.textBox_per_row_cell_num.TextChanged += new System.EventHandler(this.textBox_per_row_cell_num_TextChanged);
            this.textBox_per_row_cell_num.Enter += new System.EventHandler(this.textBox_per_row_cell_num_Enter);
            this.textBox_per_row_cell_num.Leave += new System.EventHandler(this.textBox_per_row_cell_num_Leave);
            // 
            // button_select
            // 
            this.button_select.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_select.Location = new System.Drawing.Point(3, 207);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(334, 37);
            this.button_select.TabIndex = 3;
            this.button_select.Text = "Select Folder";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.button_resize);
            this.panel1.Location = new System.Drawing.Point(8, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 37);
            this.panel1.TabIndex = 4;
            // 
            // button_resize
            // 
            this.button_resize.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_resize.Location = new System.Drawing.Point(0, 0);
            this.button_resize.Name = "button_resize";
            this.button_resize.Size = new System.Drawing.Size(141, 37);
            this.button_resize.TabIndex = 0;
            this.button_resize.Text = "Resize Cell";
            this.button_resize.UseVisualStyleBackColor = true;
            this.button_resize.Click += new System.EventHandler(this.button_resize_Click);
            // 
            // button_save
            // 
            this.button_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_save.Location = new System.Drawing.Point(183, 0);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(141, 37);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Column \"G\" Length";
            // 
            // textBox_num_col
            // 
            this.textBox_num_col.Location = new System.Drawing.Point(219, 171);
            this.textBox_num_col.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_num_col.Name = "textBox_num_col";
            this.textBox_num_col.Size = new System.Drawing.Size(96, 28);
            this.textBox_num_col.TabIndex = 21;
            this.textBox_num_col.Text = "A";
            this.textBox_num_col.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_num_col.TextChanged += new System.EventHandler(this.textBox_num_col_TextChanged);
            // 
            // textBox_target_cell
            // 
            this.textBox_target_cell.Location = new System.Drawing.Point(219, 124);
            this.textBox_target_cell.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_target_cell.Name = "textBox_target_cell";
            this.textBox_target_cell.Size = new System.Drawing.Size(96, 28);
            this.textBox_target_cell.TabIndex = 20;
            this.textBox_target_cell.Text = "F";
            this.textBox_target_cell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_target_cell.TextChanged += new System.EventHandler(this.textBox_target_cell_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Target Column";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(24, 263);
            this.button_run.Margin = new System.Windows.Forms.Padding(4);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(112, 34);
            this.button_run.TabIndex = 17;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // textBox_row_count
            // 
            this.textBox_row_count.Location = new System.Drawing.Point(219, 218);
            this.textBox_row_count.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_row_count.Name = "textBox_row_count";
            this.textBox_row_count.Size = new System.Drawing.Size(96, 28);
            this.textBox_row_count.TabIndex = 16;
            this.textBox_row_count.Text = "300";
            this.textBox_row_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_row_count.TextChanged += new System.EventHandler(this.textBox_row_count_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Number Column";
            // 
            // textBox_source_column
            // 
            this.textBox_source_column.Location = new System.Drawing.Point(219, 78);
            this.textBox_source_column.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_source_column.Name = "textBox_source_column";
            this.textBox_source_column.Size = new System.Drawing.Size(96, 28);
            this.textBox_source_column.TabIndex = 14;
            this.textBox_source_column.Text = "H";
            this.textBox_source_column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_source_column.TextChanged += new System.EventHandler(this.textBox_info_column_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Source Column";
            // 
            // button_select_file
            // 
            this.button_select_file.Location = new System.Drawing.Point(20, 20);
            this.button_select_file.Margin = new System.Windows.Forms.Padding(4);
            this.button_select_file.Name = "button_select_file";
            this.button_select_file.Size = new System.Drawing.Size(297, 34);
            this.button_select_file.TabIndex = 12;
            this.button_select_file.Text = "Select File";
            this.button_select_file.UseVisualStyleBackColor = true;
            this.button_select_file.Click += new System.EventHandler(this.button_select_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 356);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_New.ResumeLayout(false);
            this.tabPage_Add.ResumeLayout(false);
            this.tabPage_Add.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.TextBox textBox_row_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_source_column;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_select_file;
    }
}

