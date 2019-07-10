namespace CompetitonSystem
{
    partial class sportTable
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
            this.赛事表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.赛事管理系统DataSet = new CompetitonSystem.赛事管理系统DataSet();
            this.赛事表TableAdapter = new CompetitonSystem.赛事管理系统DataSetTableAdapters.赛事表TableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.时间地点DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.比赛项目DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.赛事类型DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.赛事表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.赛事管理系统DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 赛事表BindingSource
            // 
            this.赛事表BindingSource.DataMember = "赛事表";
            this.赛事表BindingSource.DataSource = this.赛事管理系统DataSet;
            // 
            // 赛事管理系统DataSet
            // 
            this.赛事管理系统DataSet.DataSetName = "赛事管理系统DataSet";
            this.赛事管理系统DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 赛事表TableAdapter
            // 
            this.赛事表TableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 51);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(120, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "赛事表";
            // 
            // 时间地点DataGridViewTextBoxColumn
            // 
            this.时间地点DataGridViewTextBoxColumn.DataPropertyName = "时间地点";
            this.时间地点DataGridViewTextBoxColumn.HeaderText = "时间地点";
            this.时间地点DataGridViewTextBoxColumn.Name = "时间地点DataGridViewTextBoxColumn";
            // 
            // 比赛项目DataGridViewTextBoxColumn
            // 
            this.比赛项目DataGridViewTextBoxColumn.DataPropertyName = "比赛项目";
            this.比赛项目DataGridViewTextBoxColumn.HeaderText = "比赛项目";
            this.比赛项目DataGridViewTextBoxColumn.Name = "比赛项目DataGridViewTextBoxColumn";
            // 
            // 赛事类型DataGridViewTextBoxColumn
            // 
            this.赛事类型DataGridViewTextBoxColumn.DataPropertyName = "赛事类型";
            this.赛事类型DataGridViewTextBoxColumn.HeaderText = "赛事类型";
            this.赛事类型DataGridViewTextBoxColumn.Name = "赛事类型DataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.赛事类型DataGridViewTextBoxColumn,
            this.比赛项目DataGridViewTextBoxColumn,
            this.时间地点DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.赛事表BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(348, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // sportTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sportTable";
            this.Text = "sportTable";
            this.Load += new System.EventHandler(this.sportTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.赛事表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.赛事管理系统DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private 赛事管理系统DataSet 赛事管理系统DataSet;
        private System.Windows.Forms.BindingSource 赛事表BindingSource;
        private 赛事管理系统DataSetTableAdapters.赛事表TableAdapter 赛事表TableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间地点DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 比赛项目DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 赛事类型DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}