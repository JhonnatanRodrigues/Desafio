
namespace CadastroCliente
{
    partial class FormMain
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
            this.TBNome = new System.Windows.Forms.TextBox();
            this.TBCNPJ = new System.Windows.Forms.TextBox();
            this.TBEndereco = new System.Windows.Forms.TextBox();
            this.LBNome = new System.Windows.Forms.Label();
            this.LBCNPJ = new System.Windows.Forms.Label();
            this.LBEndereco = new System.Windows.Forms.Label();
            this.BTInsert = new System.Windows.Forms.Button();
            this.BTDelete = new System.Windows.Forms.Button();
            this.BTEdit = new System.Windows.Forms.Button();
            this.DGVData = new System.Windows.Forms.DataGridView();
            this.BTSave = new System.Windows.Forms.Button();
            this.LBTelefone = new System.Windows.Forms.Label();
            this.TBTelefone = new System.Windows.Forms.TextBox();
            this.LBTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).BeginInit();
            this.SuspendLayout();
            // 
            // TBNome
            // 
            this.TBNome.Location = new System.Drawing.Point(1093, 63);
            this.TBNome.Name = "TBNome";
            this.TBNome.Size = new System.Drawing.Size(372, 22);
            this.TBNome.TabIndex = 0;
            // 
            // TBCNPJ
            // 
            this.TBCNPJ.Location = new System.Drawing.Point(1093, 91);
            this.TBCNPJ.Name = "TBCNPJ";
            this.TBCNPJ.Size = new System.Drawing.Size(372, 22);
            this.TBCNPJ.TabIndex = 1;
            // 
            // TBEndereco
            // 
            this.TBEndereco.Location = new System.Drawing.Point(1093, 119);
            this.TBEndereco.Name = "TBEndereco";
            this.TBEndereco.Size = new System.Drawing.Size(372, 22);
            this.TBEndereco.TabIndex = 2;
            // 
            // LBNome
            // 
            this.LBNome.AutoSize = true;
            this.LBNome.Location = new System.Drawing.Point(1018, 66);
            this.LBNome.Name = "LBNome";
            this.LBNome.Size = new System.Drawing.Size(49, 17);
            this.LBNome.TabIndex = 3;
            this.LBNome.Text = "Nome:";
            // 
            // LBCNPJ
            // 
            this.LBCNPJ.AutoSize = true;
            this.LBCNPJ.Location = new System.Drawing.Point(1018, 94);
            this.LBCNPJ.Name = "LBCNPJ";
            this.LBCNPJ.Size = new System.Drawing.Size(47, 17);
            this.LBCNPJ.TabIndex = 4;
            this.LBCNPJ.Text = "CNPJ:";
            // 
            // LBEndereco
            // 
            this.LBEndereco.AutoSize = true;
            this.LBEndereco.Location = new System.Drawing.Point(1018, 119);
            this.LBEndereco.Name = "LBEndereco";
            this.LBEndereco.Size = new System.Drawing.Size(73, 17);
            this.LBEndereco.TabIndex = 5;
            this.LBEndereco.Text = "Endereço:";
            // 
            // BTInsert
            // 
            this.BTInsert.BackColor = System.Drawing.Color.White;
            this.BTInsert.ForeColor = System.Drawing.Color.Black;
            this.BTInsert.Location = new System.Drawing.Point(1156, 195);
            this.BTInsert.Name = "BTInsert";
            this.BTInsert.Size = new System.Drawing.Size(115, 33);
            this.BTInsert.TabIndex = 7;
            this.BTInsert.Text = "Insert";
            this.BTInsert.UseVisualStyleBackColor = false;
            this.BTInsert.Click += new System.EventHandler(this.BTInsert_Click);
            // 
            // BTDelete
            // 
            this.BTDelete.BackColor = System.Drawing.Color.White;
            this.BTDelete.Location = new System.Drawing.Point(1156, 263);
            this.BTDelete.Name = "BTDelete";
            this.BTDelete.Size = new System.Drawing.Size(115, 33);
            this.BTDelete.TabIndex = 8;
            this.BTDelete.Text = "Delete";
            this.BTDelete.UseVisualStyleBackColor = false;
            this.BTDelete.Click += new System.EventHandler(this.BTDelete_Click);
            // 
            // BTEdit
            // 
            this.BTEdit.BackColor = System.Drawing.Color.White;
            this.BTEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTEdit.Location = new System.Drawing.Point(1288, 195);
            this.BTEdit.Name = "BTEdit";
            this.BTEdit.Size = new System.Drawing.Size(115, 33);
            this.BTEdit.TabIndex = 9;
            this.BTEdit.Text = "Edit";
            this.BTEdit.UseVisualStyleBackColor = false;
            this.BTEdit.Click += new System.EventHandler(this.BTEdit_Click);
            // 
            // DGVData
            // 
            this.DGVData.AllowUserToAddRows = false;
            this.DGVData.AllowUserToDeleteRows = false;
            this.DGVData.AllowUserToOrderColumns = true;
            this.DGVData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVData.Location = new System.Drawing.Point(12, 12);
            this.DGVData.MultiSelect = false;
            this.DGVData.Name = "DGVData";
            this.DGVData.ReadOnly = true;
            this.DGVData.RowHeadersWidth = 51;
            this.DGVData.RowTemplate.Height = 24;
            this.DGVData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVData.Size = new System.Drawing.Size(991, 361);
            this.DGVData.TabIndex = 10;
            this.DGVData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVData_CellMouseClick);
            // 
            // BTSave
            // 
            this.BTSave.BackColor = System.Drawing.Color.White;
            this.BTSave.Location = new System.Drawing.Point(1288, 263);
            this.BTSave.Name = "BTSave";
            this.BTSave.Size = new System.Drawing.Size(115, 33);
            this.BTSave.TabIndex = 11;
            this.BTSave.Text = "Save";
            this.BTSave.UseVisualStyleBackColor = false;
            this.BTSave.Click += new System.EventHandler(this.BTSave_Click);
            // 
            // LBTelefone
            // 
            this.LBTelefone.AutoSize = true;
            this.LBTelefone.Location = new System.Drawing.Point(1018, 147);
            this.LBTelefone.Name = "LBTelefone";
            this.LBTelefone.Size = new System.Drawing.Size(68, 17);
            this.LBTelefone.TabIndex = 13;
            this.LBTelefone.Text = "Telefone:";
            // 
            // TBTelefone
            // 
            this.TBTelefone.Location = new System.Drawing.Point(1093, 147);
            this.TBTelefone.Name = "TBTelefone";
            this.TBTelefone.Size = new System.Drawing.Size(372, 22);
            this.TBTelefone.TabIndex = 12;
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitulo.Location = new System.Drawing.Point(1219, 12);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(101, 36);
            this.LBTitulo.TabIndex = 6;
            this.LBTitulo.Text = "Dados";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1477, 400);
            this.Controls.Add(this.LBTelefone);
            this.Controls.Add(this.TBTelefone);
            this.Controls.Add(this.BTSave);
            this.Controls.Add(this.DGVData);
            this.Controls.Add(this.BTEdit);
            this.Controls.Add(this.BTDelete);
            this.Controls.Add(this.BTInsert);
            this.Controls.Add(this.LBTitulo);
            this.Controls.Add(this.LBEndereco);
            this.Controls.Add(this.LBCNPJ);
            this.Controls.Add(this.LBNome);
            this.Controls.Add(this.TBEndereco);
            this.Controls.Add(this.TBCNPJ);
            this.Controls.Add(this.TBNome);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBNome;
        private System.Windows.Forms.TextBox TBCNPJ;
        private System.Windows.Forms.TextBox TBEndereco;
        private System.Windows.Forms.Label LBNome;
        private System.Windows.Forms.Label LBCNPJ;
        private System.Windows.Forms.Label LBEndereco;
        private System.Windows.Forms.Button BTInsert;
        private System.Windows.Forms.Button BTDelete;
        private System.Windows.Forms.Button BTEdit;
        private System.Windows.Forms.DataGridView DGVData;
        private System.Windows.Forms.Button BTSave;
        private System.Windows.Forms.Label LBTelefone;
        private System.Windows.Forms.TextBox TBTelefone;
        private System.Windows.Forms.Label LBTitulo;
    }
}

