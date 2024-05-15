
namespace bancoDeDados
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelnome = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.inserir = new System.Windows.Forms.Button();
            this.procurar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.ConectarBD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banco de Dados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome,
            this.Email});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuText;
            this.dataGridView1.Location = new System.Drawing.Point(29, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 180);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnome.Location = new System.Drawing.Point(460, 61);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(55, 20);
            this.labelnome.TabIndex = 2;
            this.labelnome.Text = "Nome:";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(460, 108);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(57, 20);
            this.labelemail.TabIndex = 3;
            this.labelemail.Text = "E-mail:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(522, 60);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(178, 20);
            this.txtnome.TabIndex = 4;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(521, 110);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(178, 20);
            this.txtemail.TabIndex = 5;
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Location = new System.Drawing.Point(604, 201);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(143, 39);
            this.create.TabIndex = 6;
            this.create.Text = "Criar Tabela";
            this.create.UseVisualStyleBackColor = true;
            // 
            // inserir
            // 
            this.inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inserir.Location = new System.Drawing.Point(604, 246);
            this.inserir.Name = "inserir";
            this.inserir.Size = new System.Drawing.Size(143, 39);
            this.inserir.TabIndex = 7;
            this.inserir.Text = "Inserir ";
            this.inserir.UseVisualStyleBackColor = true;
            // 
            // procurar
            // 
            this.procurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procurar.Location = new System.Drawing.Point(604, 291);
            this.procurar.Name = "procurar";
            this.procurar.Size = new System.Drawing.Size(143, 39);
            this.procurar.TabIndex = 8;
            this.procurar.Text = "Procurar";
            this.procurar.UseVisualStyleBackColor = true;
            // 
            // excluir
            // 
            this.excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluir.Location = new System.Drawing.Point(604, 336);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(143, 39);
            this.excluir.TabIndex = 9;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            // 
            // editar
            // 
            this.editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar.Location = new System.Drawing.Point(604, 381);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(143, 39);
            this.editar.TabIndex = 10;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            // 
            // ConectarBD
            // 
            this.ConectarBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConectarBD.Location = new System.Drawing.Point(60, 381);
            this.ConectarBD.Name = "ConectarBD";
            this.ConectarBD.Size = new System.Drawing.Size(143, 39);
            this.ConectarBD.TabIndex = 11;
            this.ConectarBD.Text = "Conectar BD";
            this.ConectarBD.UseVisualStyleBackColor = true;
            this.ConectarBD.Click += new System.EventHandler(this.ConectarBD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConectarBD);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.procurar);
            this.Controls.Add(this.inserir);
            this.Controls.Add(this.create);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labelnome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button inserir;
        private System.Windows.Forms.Button procurar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button ConectarBD;
    }
}

