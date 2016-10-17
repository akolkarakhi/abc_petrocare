namespace WindowsFormsApplication2
{
    partial class viewatt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet2 = new WindowsFormsApplication2.databaseDataSet2();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceTableAdapter = new WindowsFormsApplication2.databaseDataSet2TableAdapters.attendanceTableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day14DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day15DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day16DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day17DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day18DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day19DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day20DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day21DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day22DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day23DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day24DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day25DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day26DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day27DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day28DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day29DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day30DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day31DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.day1DataGridViewTextBoxColumn,
            this.day2DataGridViewTextBoxColumn,
            this.day3DataGridViewTextBoxColumn,
            this.day4DataGridViewTextBoxColumn,
            this.day5DataGridViewTextBoxColumn,
            this.day6DataGridViewTextBoxColumn,
            this.day7DataGridViewTextBoxColumn,
            this.day8DataGridViewTextBoxColumn,
            this.day9DataGridViewTextBoxColumn,
            this.day10DataGridViewTextBoxColumn,
            this.day11DataGridViewTextBoxColumn,
            this.day12DataGridViewTextBoxColumn,
            this.day13DataGridViewTextBoxColumn,
            this.day14DataGridViewTextBoxColumn,
            this.day15DataGridViewTextBoxColumn,
            this.day16DataGridViewTextBoxColumn,
            this.day17DataGridViewTextBoxColumn,
            this.day18DataGridViewTextBoxColumn,
            this.day19DataGridViewTextBoxColumn,
            this.day20DataGridViewTextBoxColumn,
            this.day21DataGridViewTextBoxColumn,
            this.day22DataGridViewTextBoxColumn,
            this.day23DataGridViewTextBoxColumn,
            this.day24DataGridViewTextBoxColumn,
            this.day25DataGridViewTextBoxColumn,
            this.day26DataGridViewTextBoxColumn,
            this.day27DataGridViewTextBoxColumn,
            this.day28DataGridViewTextBoxColumn,
            this.day29DataGridViewTextBoxColumn,
            this.day30DataGridViewTextBoxColumn,
            this.day31DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // databaseDataSet2
            // 
            this.databaseDataSet2.DataSetName = "databaseDataSet2";
            this.databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "attendance";
            this.attendanceBindingSource.DataSource = this.databaseDataSet2;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // day1DataGridViewTextBoxColumn
            // 
            this.day1DataGridViewTextBoxColumn.DataPropertyName = "day1";
            this.day1DataGridViewTextBoxColumn.HeaderText = "day1";
            this.day1DataGridViewTextBoxColumn.Name = "day1DataGridViewTextBoxColumn";
            // 
            // day2DataGridViewTextBoxColumn
            // 
            this.day2DataGridViewTextBoxColumn.DataPropertyName = "day2";
            this.day2DataGridViewTextBoxColumn.HeaderText = "day2";
            this.day2DataGridViewTextBoxColumn.Name = "day2DataGridViewTextBoxColumn";
            // 
            // day3DataGridViewTextBoxColumn
            // 
            this.day3DataGridViewTextBoxColumn.DataPropertyName = "day3";
            this.day3DataGridViewTextBoxColumn.HeaderText = "day3";
            this.day3DataGridViewTextBoxColumn.Name = "day3DataGridViewTextBoxColumn";
            // 
            // day4DataGridViewTextBoxColumn
            // 
            this.day4DataGridViewTextBoxColumn.DataPropertyName = "day4";
            this.day4DataGridViewTextBoxColumn.HeaderText = "day4";
            this.day4DataGridViewTextBoxColumn.Name = "day4DataGridViewTextBoxColumn";
            // 
            // day5DataGridViewTextBoxColumn
            // 
            this.day5DataGridViewTextBoxColumn.DataPropertyName = "day5";
            this.day5DataGridViewTextBoxColumn.HeaderText = "day5";
            this.day5DataGridViewTextBoxColumn.Name = "day5DataGridViewTextBoxColumn";
            // 
            // day6DataGridViewTextBoxColumn
            // 
            this.day6DataGridViewTextBoxColumn.DataPropertyName = "day6";
            this.day6DataGridViewTextBoxColumn.HeaderText = "day6";
            this.day6DataGridViewTextBoxColumn.Name = "day6DataGridViewTextBoxColumn";
            // 
            // day7DataGridViewTextBoxColumn
            // 
            this.day7DataGridViewTextBoxColumn.DataPropertyName = "day7";
            this.day7DataGridViewTextBoxColumn.HeaderText = "day7";
            this.day7DataGridViewTextBoxColumn.Name = "day7DataGridViewTextBoxColumn";
            // 
            // day8DataGridViewTextBoxColumn
            // 
            this.day8DataGridViewTextBoxColumn.DataPropertyName = "day8";
            this.day8DataGridViewTextBoxColumn.HeaderText = "day8";
            this.day8DataGridViewTextBoxColumn.Name = "day8DataGridViewTextBoxColumn";
            // 
            // day9DataGridViewTextBoxColumn
            // 
            this.day9DataGridViewTextBoxColumn.DataPropertyName = "day9";
            this.day9DataGridViewTextBoxColumn.HeaderText = "day9";
            this.day9DataGridViewTextBoxColumn.Name = "day9DataGridViewTextBoxColumn";
            // 
            // day10DataGridViewTextBoxColumn
            // 
            this.day10DataGridViewTextBoxColumn.DataPropertyName = "day10";
            this.day10DataGridViewTextBoxColumn.HeaderText = "day10";
            this.day10DataGridViewTextBoxColumn.Name = "day10DataGridViewTextBoxColumn";
            // 
            // day11DataGridViewTextBoxColumn
            // 
            this.day11DataGridViewTextBoxColumn.DataPropertyName = "day11";
            this.day11DataGridViewTextBoxColumn.HeaderText = "day11";
            this.day11DataGridViewTextBoxColumn.Name = "day11DataGridViewTextBoxColumn";
            // 
            // day12DataGridViewTextBoxColumn
            // 
            this.day12DataGridViewTextBoxColumn.DataPropertyName = "day12";
            this.day12DataGridViewTextBoxColumn.HeaderText = "day12";
            this.day12DataGridViewTextBoxColumn.Name = "day12DataGridViewTextBoxColumn";
            // 
            // day13DataGridViewTextBoxColumn
            // 
            this.day13DataGridViewTextBoxColumn.DataPropertyName = "day13";
            this.day13DataGridViewTextBoxColumn.HeaderText = "day13";
            this.day13DataGridViewTextBoxColumn.Name = "day13DataGridViewTextBoxColumn";
            // 
            // day14DataGridViewTextBoxColumn
            // 
            this.day14DataGridViewTextBoxColumn.DataPropertyName = "day14";
            this.day14DataGridViewTextBoxColumn.HeaderText = "day14";
            this.day14DataGridViewTextBoxColumn.Name = "day14DataGridViewTextBoxColumn";
            // 
            // day15DataGridViewTextBoxColumn
            // 
            this.day15DataGridViewTextBoxColumn.DataPropertyName = "day15";
            this.day15DataGridViewTextBoxColumn.HeaderText = "day15";
            this.day15DataGridViewTextBoxColumn.Name = "day15DataGridViewTextBoxColumn";
            // 
            // day16DataGridViewTextBoxColumn
            // 
            this.day16DataGridViewTextBoxColumn.DataPropertyName = "day16";
            this.day16DataGridViewTextBoxColumn.HeaderText = "day16";
            this.day16DataGridViewTextBoxColumn.Name = "day16DataGridViewTextBoxColumn";
            // 
            // day17DataGridViewTextBoxColumn
            // 
            this.day17DataGridViewTextBoxColumn.DataPropertyName = "day17";
            this.day17DataGridViewTextBoxColumn.HeaderText = "day17";
            this.day17DataGridViewTextBoxColumn.Name = "day17DataGridViewTextBoxColumn";
            // 
            // day18DataGridViewTextBoxColumn
            // 
            this.day18DataGridViewTextBoxColumn.DataPropertyName = "day18";
            this.day18DataGridViewTextBoxColumn.HeaderText = "day18";
            this.day18DataGridViewTextBoxColumn.Name = "day18DataGridViewTextBoxColumn";
            // 
            // day19DataGridViewTextBoxColumn
            // 
            this.day19DataGridViewTextBoxColumn.DataPropertyName = "day19";
            this.day19DataGridViewTextBoxColumn.HeaderText = "day19";
            this.day19DataGridViewTextBoxColumn.Name = "day19DataGridViewTextBoxColumn";
            // 
            // day20DataGridViewTextBoxColumn
            // 
            this.day20DataGridViewTextBoxColumn.DataPropertyName = "day20";
            this.day20DataGridViewTextBoxColumn.HeaderText = "day20";
            this.day20DataGridViewTextBoxColumn.Name = "day20DataGridViewTextBoxColumn";
            // 
            // day21DataGridViewTextBoxColumn
            // 
            this.day21DataGridViewTextBoxColumn.DataPropertyName = "day21";
            this.day21DataGridViewTextBoxColumn.HeaderText = "day21";
            this.day21DataGridViewTextBoxColumn.Name = "day21DataGridViewTextBoxColumn";
            // 
            // day22DataGridViewTextBoxColumn
            // 
            this.day22DataGridViewTextBoxColumn.DataPropertyName = "day22";
            this.day22DataGridViewTextBoxColumn.HeaderText = "day22";
            this.day22DataGridViewTextBoxColumn.Name = "day22DataGridViewTextBoxColumn";
            // 
            // day23DataGridViewTextBoxColumn
            // 
            this.day23DataGridViewTextBoxColumn.DataPropertyName = "day23";
            this.day23DataGridViewTextBoxColumn.HeaderText = "day23";
            this.day23DataGridViewTextBoxColumn.Name = "day23DataGridViewTextBoxColumn";
            // 
            // day24DataGridViewTextBoxColumn
            // 
            this.day24DataGridViewTextBoxColumn.DataPropertyName = "day24";
            this.day24DataGridViewTextBoxColumn.HeaderText = "day24";
            this.day24DataGridViewTextBoxColumn.Name = "day24DataGridViewTextBoxColumn";
            // 
            // day25DataGridViewTextBoxColumn
            // 
            this.day25DataGridViewTextBoxColumn.DataPropertyName = "day25";
            this.day25DataGridViewTextBoxColumn.HeaderText = "day25";
            this.day25DataGridViewTextBoxColumn.Name = "day25DataGridViewTextBoxColumn";
            // 
            // day26DataGridViewTextBoxColumn
            // 
            this.day26DataGridViewTextBoxColumn.DataPropertyName = "day26";
            this.day26DataGridViewTextBoxColumn.HeaderText = "day26";
            this.day26DataGridViewTextBoxColumn.Name = "day26DataGridViewTextBoxColumn";
            // 
            // day27DataGridViewTextBoxColumn
            // 
            this.day27DataGridViewTextBoxColumn.DataPropertyName = "day27";
            this.day27DataGridViewTextBoxColumn.HeaderText = "day27";
            this.day27DataGridViewTextBoxColumn.Name = "day27DataGridViewTextBoxColumn";
            // 
            // day28DataGridViewTextBoxColumn
            // 
            this.day28DataGridViewTextBoxColumn.DataPropertyName = "day28";
            this.day28DataGridViewTextBoxColumn.HeaderText = "day28";
            this.day28DataGridViewTextBoxColumn.Name = "day28DataGridViewTextBoxColumn";
            // 
            // day29DataGridViewTextBoxColumn
            // 
            this.day29DataGridViewTextBoxColumn.DataPropertyName = "day29";
            this.day29DataGridViewTextBoxColumn.HeaderText = "day29";
            this.day29DataGridViewTextBoxColumn.Name = "day29DataGridViewTextBoxColumn";
            // 
            // day30DataGridViewTextBoxColumn
            // 
            this.day30DataGridViewTextBoxColumn.DataPropertyName = "day30";
            this.day30DataGridViewTextBoxColumn.HeaderText = "day30";
            this.day30DataGridViewTextBoxColumn.Name = "day30DataGridViewTextBoxColumn";
            // 
            // day31DataGridViewTextBoxColumn
            // 
            this.day31DataGridViewTextBoxColumn.DataPropertyName = "day31";
            this.day31DataGridViewTextBoxColumn.HeaderText = "day31";
            this.day31DataGridViewTextBoxColumn.Name = "day31DataGridViewTextBoxColumn";
            // 
            // viewatt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewatt";
            this.Text = "viewatt";
            this.Load += new System.EventHandler(this.viewatt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private databaseDataSet2 databaseDataSet2;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private databaseDataSet2TableAdapters.attendanceTableAdapter attendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day12DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day14DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day15DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day16DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day17DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day18DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day19DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day20DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day21DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day22DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day23DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day24DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day25DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day26DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day27DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day28DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day29DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day30DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn day31DataGridViewTextBoxColumn;
    }
}