
namespace InventarioTI
{
    partial class FormCadastrarPecas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNomePeca = new System.Windows.Forms.TextBox();
            this.txtModeloPeca = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvPecas = new System.Windows.Forms.DataGridView();
            this.btnAddPeca = new System.Windows.Forms.Button();
            this.btnEditarPeca = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomePeca
            // 
            this.txtNomePeca.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNomePeca.Location = new System.Drawing.Point(106, 21);
            this.txtNomePeca.Name = "txtNomePeca";
            this.txtNomePeca.Size = new System.Drawing.Size(359, 23);
            this.txtNomePeca.TabIndex = 1;
            this.txtNomePeca.Text = "nome da peça";
            this.txtNomePeca.Enter += new System.EventHandler(this.txtNomePeca_Enter);
            this.txtNomePeca.Leave += new System.EventHandler(this.txtNomePeca_Leave);
            // 
            // txtModeloPeca
            // 
            this.txtModeloPeca.ForeColor = System.Drawing.Color.DarkGray;
            this.txtModeloPeca.Location = new System.Drawing.Point(106, 51);
            this.txtModeloPeca.Name = "txtModeloPeca";
            this.txtModeloPeca.Size = new System.Drawing.Size(359, 23);
            this.txtModeloPeca.TabIndex = 2;
            this.txtModeloPeca.Text = "modelo peça";
            this.txtModeloPeca.Enter += new System.EventHandler(this.textBox2_Enter);
            this.txtModeloPeca.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 676);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(105, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "marca peça";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(105, 114);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(99, 23);
            this.numericUpDown1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "B",
            "kB",
            "MB",
            "GB",
            "TB",
            "PB",
            "EB",
            "ZB",
            "YB"});
            this.comboBox1.Location = new System.Drawing.Point(210, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(48, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "B";
            // 
            // dgvPecas
            // 
            this.dgvPecas.AllowUserToAddRows = false;
            this.dgvPecas.AllowUserToDeleteRows = false;
            this.dgvPecas.AllowUserToOrderColumns = true;
            this.dgvPecas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPecas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPecas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPecas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPecas.Location = new System.Drawing.Point(104, 143);
            this.dgvPecas.MultiSelect = false;
            this.dgvPecas.Name = "dgvPecas";
            this.dgvPecas.ReadOnly = true;
            this.dgvPecas.RowTemplate.Height = 25;
            this.dgvPecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPecas.Size = new System.Drawing.Size(855, 533);
            this.dgvPecas.TabIndex = 7;
            // 
            // btnAddPeca
            // 
            this.btnAddPeca.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddPeca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPeca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddPeca.FlatAppearance.BorderSize = 0;
            this.btnAddPeca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddPeca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPeca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddPeca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddPeca.Location = new System.Drawing.Point(514, 19);
            this.btnAddPeca.Name = "btnAddPeca";
            this.btnAddPeca.Size = new System.Drawing.Size(72, 34);
            this.btnAddPeca.TabIndex = 8;
            this.btnAddPeca.Text = "cadastrar";
            this.btnAddPeca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddPeca.UseVisualStyleBackColor = false;
            this.btnAddPeca.MouseLeave += new System.EventHandler(this.btnAddPeca_MouseLeave);
            this.btnAddPeca.MouseHover += new System.EventHandler(this.btnAddPeca_MouseHover);
            // 
            // btnEditarPeca
            // 
            this.btnEditarPeca.BackColor = System.Drawing.Color.Gold;
            this.btnEditarPeca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPeca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarPeca.FlatAppearance.BorderSize = 0;
            this.btnEditarPeca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditarPeca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEditarPeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPeca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarPeca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarPeca.Location = new System.Drawing.Point(592, 19);
            this.btnEditarPeca.Name = "btnEditarPeca";
            this.btnEditarPeca.Size = new System.Drawing.Size(72, 34);
            this.btnEditarPeca.TabIndex = 9;
            this.btnEditarPeca.Text = "editar";
            this.btnEditarPeca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarPeca.UseVisualStyleBackColor = false;
            this.btnEditarPeca.Click += new System.EventHandler(this.btnEditarPeca_Click);
            this.btnEditarPeca.MouseLeave += new System.EventHandler(this.btnEditarPeca_MouseLeave);
            this.btnEditarPeca.MouseHover += new System.EventHandler(this.btnEditarPeca_MouseHover);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Crimson;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeletar.Location = new System.Drawing.Point(670, 19);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(72, 34);
            this.btnDeletar.TabIndex = 10;
            this.btnDeletar.Text = "deletar";
            this.btnDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // FormCadastrarPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 676);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditarPeca);
            this.Controls.Add(this.btnAddPeca);
            this.Controls.Add(this.dgvPecas);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtModeloPeca);
            this.Controls.Add(this.txtNomePeca);
            this.Name = "FormCadastrarPecas";
            this.Text = "Cadastrar Peças";
            this.Load += new System.EventHandler(this.FormCadastrarPecas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomePeca;
        private System.Windows.Forms.TextBox txtModeloPeca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvPecas;
        private System.Windows.Forms.Button btnAddPeca;
        private System.Windows.Forms.Button btnEditarPeca;
        private System.Windows.Forms.Button btnDeletar;
    }
}