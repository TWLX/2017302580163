namespace CompetitonSystem
{
    partial class coach
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
            this.编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.教练员BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.赛事管理系统DataSet = new CompetitonSystem.赛事管理系统DataSet();
            this.教练员TableAdapter = new CompetitonSystem.赛事管理系统DataSetTableAdapters.教练员TableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.教练员BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.赛事管理系统DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.电话DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.身份证DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.教练员BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(558, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // 编号DataGridViewTextBoxColumn
            // 
            this.编号DataGridViewTextBoxColumn.DataPropertyName = "编号";
            this.编号DataGridViewTextBoxColumn.HeaderText = "编号";
            this.编号DataGridViewTextBoxColumn.Name = "编号DataGridViewTextBoxColumn";
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 电话DataGridViewTextBoxColumn
            // 
            this.电话DataGridViewTextBoxColumn.DataPropertyName = "电话";
            this.电话DataGridViewTextBoxColumn.HeaderText = "电话";
            this.电话DataGridViewTextBoxColumn.Name = "电话DataGridViewTextBoxColumn";
            // 
            // 性别DataGridViewTextBoxColumn
            // 
            this.性别DataGridViewTextBoxColumn.DataPropertyName = "性别";
            this.性别DataGridViewTextBoxColumn.HeaderText = "性别";
            this.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn";
            // 
            // 身份证DataGridViewTextBoxColumn
            // 
            this.身份证DataGridViewTextBoxColumn.DataPropertyName = "身份证";
            this.身份证DataGridViewTextBoxColumn.HeaderText = "身份证";
            this.身份证DataGridViewTextBoxColumn.Name = "身份证DataGridViewTextBoxColumn";
            // 
            // 教练员BindingSource
            // 
            this.教练员BindingSource.DataMember = "教练员";
            this.教练员BindingSource.DataSource = this.赛事管理系统DataSet;
            // 
            // 赛事管理系统DataSet
            // 
            this.赛事管理系统DataSet.DataSetName = "赛事管理系统DataSet";
            this.赛事管理系统DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 教练员TableAdapter
            // 
            this.教练员TableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 72);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "刷新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(194, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "教练员名单";
            // 
            // coach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 407);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "coach";
            this.Text = "coach";
            this.Load += new System.EventHandler(this.coach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.教练员BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.赛事管理系统DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private 赛事管理系统DataSet 赛事管理系统DataSet;
        private System.Windows.Forms.BindingSource 教练员BindingSource;
        private 赛事管理系统DataSetTableAdapters.教练员TableAdapter 教练员TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证DataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}