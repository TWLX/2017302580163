namespace CompetitonSystem
{
    partial class Doctor
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
            this.队医BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.队医TableAdapter = new CompetitonSystem.赛事管理系统DataSetTableAdapters.队医TableAdapter();
            this.编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.赛事管理系统DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.队医BindingSource)).BeginInit();
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
            this.电话DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.队医BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(487, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // 赛事管理系统DataSet
            // 
            this.赛事管理系统DataSet.DataSetName = "赛事管理系统DataSet";
            this.赛事管理系统DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 队医BindingSource
            // 
            this.队医BindingSource.DataMember = "队医";
            this.队医BindingSource.DataSource = this.赛事管理系统DataSet;
            // 
            // 队医TableAdapter
            // 
            this.队医TableAdapter.ClearBeforeFill = true;
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
            // 电话DataGridViewTextBoxColumn
            // 
            this.电话DataGridViewTextBoxColumn.DataPropertyName = "电话";
            this.电话DataGridViewTextBoxColumn.HeaderText = "电话";
            this.电话DataGridViewTextBoxColumn.Name = "电话DataGridViewTextBoxColumn";
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 57);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(161, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "队医名单";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "更新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 432);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.赛事管理系统DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.队医BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private 赛事管理系统DataSet 赛事管理系统DataSet;
        private System.Windows.Forms.BindingSource 队医BindingSource;
        private 赛事管理系统DataSetTableAdapters.队医TableAdapter 队医TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}