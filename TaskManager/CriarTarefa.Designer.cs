namespace TaskManager
{
    partial class CriarTarefa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeTarefa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInico = new System.Windows.Forms.DateTimePicker();
            this.dtTermino = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.dtTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.dtTimeFim = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data Inicio *";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome da Tarefa *";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeTarefa
            // 
            this.txtNomeTarefa.Location = new System.Drawing.Point(10, 35);
            this.txtNomeTarefa.Name = "txtNomeTarefa";
            this.txtNomeTarefa.Size = new System.Drawing.Size(271, 20);
            this.txtNomeTarefa.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data Término *";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtInico
            // 
            this.dtInico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInico.Location = new System.Drawing.Point(10, 78);
            this.dtInico.Name = "dtInico";
            this.dtInico.Size = new System.Drawing.Size(95, 20);
            this.dtInico.TabIndex = 16;
            // 
            // dtTermino
            // 
            this.dtTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTermino.Location = new System.Drawing.Point(10, 122);
            this.dtTermino.Name = "dtTermino";
            this.dtTermino.Size = new System.Drawing.Size(95, 20);
            this.dtTermino.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Descrição";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(10, 178);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(271, 65);
            this.txtDescricao.TabIndex = 18;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(97, 261);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 20;
            this.btnCriar.Text = "Criar Tarefa";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // dtTimeInicio
            // 
            this.dtTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTimeInicio.Location = new System.Drawing.Point(111, 78);
            this.dtTimeInicio.Name = "dtTimeInicio";
            this.dtTimeInicio.Size = new System.Drawing.Size(75, 20);
            this.dtTimeInicio.TabIndex = 21;
            // 
            // dtTimeFim
            // 
            this.dtTimeFim.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTimeFim.Location = new System.Drawing.Point(111, 122);
            this.dtTimeFim.Name = "dtTimeFim";
            this.dtTimeFim.Size = new System.Drawing.Size(75, 20);
            this.dtTimeFim.TabIndex = 22;
            // 
            // CriarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 290);
            this.Controls.Add(this.dtTimeFim);
            this.Controls.Add(this.dtTimeInicio);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.dtTermino);
            this.Controls.Add(this.dtInico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeTarefa);
            this.Name = "CriarTarefa";
            this.Text = "CriarTarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeTarefa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtInico;
        private System.Windows.Forms.DateTimePicker dtTermino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.DateTimePicker dtTimeInicio;
        private System.Windows.Forms.DateTimePicker dtTimeFim;
    }
}