namespace CompetitonSystem
{
    partial class athleteInfo
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
            this.赛事管理系统DataSet = new CompetitonSystem.赛事管理系统DataSet();
            this.运动员BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.运动员TableAdapter = new CompetitonSystem.赛事管理系统DataSetTableAdapters.运动员TableAdapter();
            this.编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年龄DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.组别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.文化成绩DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成绩DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.赛事管理系统DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.运动员BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号DataGridViewTextBoxColumn,
            this.身份证DataGridViewTextBoxColumn,
            this.年龄DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.组别DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.文化成绩DataGridViewTextBoxColumn,
            this.成绩DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.运动员BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(776, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // 赛事管理系统DataSet
            // 
            this.赛事管理系统DataSet.DataSetName = "赛事管理系统DataSet";
            this.赛事管理系统DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 运动员BindingSource
            // 
            this.运动员BindingSource.DataMember = "运动员";
            this.运动员BindingSource.DataSource = this.赛事管理系统DataSet;
            // 
            // 运动员TableAdapter
            // 
            this.运动员TableAdapter.ClearBeforeFill = true;
            // 
            // 编号DataGridViewTextBoxColumn
            // 
            this.编号DataGridViewTextBoxColumn.DataPropertyName = "编号";
            this.编号DataGridViewTextBoxColumn.HeaderText = "编号";
            this.编号DataGridViewTextBoxColumn.Name = "编号DataGridViewTextBoxColumn";
            // 
            // 身份证DataGridViewTextBoxColumn
            // 
            this.身份证DataGridViewTextBoxColumn.DataPropertyName = "身份证";
            this.身份证DataGridViewTextBoxColumn.HeaderText = "身份证";
            this.身份证DataGridViewTextBoxColumn.Name = "身份证DataGridViewTextBoxColumn";
            // 
            // 年龄DataGridViewTextBoxColumn
            // 
            this.年龄DataGridViewTextBoxColumn.DataPropertyName = "年龄";
            this.年龄DataGridViewTextBoxColumn.HeaderText = "年龄";
            this.年龄DataGridViewTextBoxColumn.Name = "年龄DataGridViewTextBoxColumn";
            // 
            // 性别DataGridViewTextBoxColumn
            // 
            this.性别DataGridViewTextBoxColumn.DataPropertyName = "性别";
            this.性别DataGridViewTextBoxColumn.HeaderText = "性别";
            this.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn";
            // 
            // 组别DataGridViewTextBoxColumn
            // 
            this.组别DataGridViewTextBoxColumn.DataPropertyName = "组别";
            this.组别DataGridViewTextBoxColumn.HeaderText = "组别";
            this.组别DataGridViewTextBoxColumn.Name = "组别DataGridViewTextBoxColumn";
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 文化成绩DataGridViewTextBoxColumn
            // 
            this.文化成绩DataGridViewTextBoxColumn.DataPropertyName = "文化成绩";
            this.文化成绩DataGridViewTextBoxColumn.HeaderText = "文化成绩";
            this.文化成绩DataGridViewTextBoxColumn.Name = "文化成绩DataGridViewTextBoxColumn";
            // 
            // 成绩DataGridViewTextBoxColumn
            // 
            this.成绩DataGridViewTextBoxColumn.DataPropertyName = "成绩";
            this.成绩DataGridViewTextBoxColumn.HeaderText = "成绩";
            this.成绩DataGridViewTextBoxColumn.Name = "成绩DataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 55);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(557, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "详细信息";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(303, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "运动员名单";
            // 
            // SportmanTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SportmanTable";
            this.Text = "SportmanTable";
            this.Load += new System.EventHandler(this.SportmanTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.赛事管理系统DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.运动员BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private 赛事管理系统DataSet 赛事管理系统DataSet;
        private System.Windows.Forms.BindingSource 运动员BindingSource;
        private 赛事管理系统DataSetTableAdapters.运动员TableAdapter 运动员TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年龄DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 组别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 文化成绩DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成绩DataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}