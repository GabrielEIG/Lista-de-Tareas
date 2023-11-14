namespace Lista_de_Tareas
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnVerified = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.homeworkCheckedList = new System.Windows.Forms.ListBox();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOptionSave = new System.Windows.Forms.Button();
            this.CtBlack = new System.Windows.Forms.RadioButton();
            this.ctWhite = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.etCooper = new System.Windows.Forms.RadioButton();
            this.etImpact = new System.Windows.Forms.RadioButton();
            this.etLucida = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cfBlue = new System.Windows.Forms.RadioButton();
            this.cfBlack = new System.Windows.Forms.RadioButton();
            this.cfWhite = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOptionClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 56);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de tareas";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(477, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(477, 183);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnVerified
            // 
            this.btnVerified.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVerified.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerified.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerified.Location = new System.Drawing.Point(477, 221);
            this.btnVerified.Name = "btnVerified";
            this.btnVerified.Size = new System.Drawing.Size(131, 23);
            this.btnVerified.TabIndex = 5;
            this.btnVerified.Text = "Realizada";
            this.btnVerified.UseVisualStyleBackColor = false;
            this.btnVerified.Click += new System.EventHandler(this.btnVerified_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnShow.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShow.Location = new System.Drawing.Point(477, 103);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(131, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Ver";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(477, 259);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOptions.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOptions.Location = new System.Drawing.Point(477, 298);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(131, 23);
            this.btnOptions.TabIndex = 8;
            this.btnOptions.Text = "Opciones";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // homeworkCheckedList
            // 
            this.homeworkCheckedList.BackColor = System.Drawing.Color.LightGray;
            this.homeworkCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.homeworkCheckedList.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeworkCheckedList.FormattingEnabled = true;
            this.homeworkCheckedList.ItemHeight = 15;
            this.homeworkCheckedList.Location = new System.Drawing.Point(12, 107);
            this.homeworkCheckedList.Name = "homeworkCheckedList";
            this.homeworkCheckedList.Size = new System.Drawing.Size(436, 210);
            this.homeworkCheckedList.TabIndex = 9;
            this.homeworkCheckedList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.homeworkCheckedList_DrawItem);
            this.homeworkCheckedList.SelectedIndexChanged += new System.EventHandler(this.homeworkCheckedList_SelectedIndexChanged);
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.optionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionsPanel.Controls.Add(this.panel3);
            this.optionsPanel.Controls.Add(this.label2);
            this.optionsPanel.Controls.Add(this.btnOptionClose);
            this.optionsPanel.Location = new System.Drawing.Point(352, 57);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(256, 299);
            this.optionsPanel.TabIndex = 15;
            this.optionsPanel.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnOptionSave);
            this.panel3.Controls.Add(this.CtBlack);
            this.panel3.Controls.Add(this.ctWhite);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.etCooper);
            this.panel3.Controls.Add(this.etImpact);
            this.panel3.Controls.Add(this.etLucida);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cfBlue);
            this.panel3.Controls.Add(this.cfBlack);
            this.panel3.Controls.Add(this.cfWhite);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(31, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 233);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 9.75F);
            this.button1.Location = new System.Drawing.Point(6, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnOptionSave
            // 
            this.btnOptionSave.BackColor = System.Drawing.Color.White;
            this.btnOptionSave.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOptionSave.Location = new System.Drawing.Point(97, 199);
            this.btnOptionSave.Name = "btnOptionSave";
            this.btnOptionSave.Size = new System.Drawing.Size(75, 23);
            this.btnOptionSave.TabIndex = 12;
            this.btnOptionSave.Text = "Guardar";
            this.btnOptionSave.UseVisualStyleBackColor = false;
            this.btnOptionSave.Click += new System.EventHandler(this.btnOptionSave_Click);
            // 
            // CtBlack
            // 
            this.CtBlack.AutoSize = true;
            this.CtBlack.BackColor = System.Drawing.Color.Transparent;
            this.CtBlack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CtBlack.Location = new System.Drawing.Point(108, 172);
            this.CtBlack.Name = "CtBlack";
            this.CtBlack.Size = new System.Drawing.Size(54, 17);
            this.CtBlack.TabIndex = 10;
            this.CtBlack.TabStop = true;
            this.CtBlack.Text = "Negro";
            this.CtBlack.UseVisualStyleBackColor = false;
            this.CtBlack.CheckedChanged += new System.EventHandler(this.CtBlack_CheckedChanged);
            // 
            // ctWhite
            // 
            this.ctWhite.AutoSize = true;
            this.ctWhite.BackColor = System.Drawing.Color.Transparent;
            this.ctWhite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctWhite.Location = new System.Drawing.Point(15, 172);
            this.ctWhite.Name = "ctWhite";
            this.ctWhite.Size = new System.Drawing.Size(58, 17);
            this.ctWhite.TabIndex = 9;
            this.ctWhite.TabStop = true;
            this.ctWhite.Text = "Blanco";
            this.ctWhite.UseVisualStyleBackColor = false;
            this.ctWhite.CheckedChanged += new System.EventHandler(this.ctWhite_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(3, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Color de texto";
            // 
            // etCooper
            // 
            this.etCooper.AutoSize = true;
            this.etCooper.BackColor = System.Drawing.Color.Transparent;
            this.etCooper.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etCooper.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.etCooper.Location = new System.Drawing.Point(115, 103);
            this.etCooper.Name = "etCooper";
            this.etCooper.Size = new System.Drawing.Size(66, 17);
            this.etCooper.TabIndex = 7;
            this.etCooper.TabStop = true;
            this.etCooper.Text = "Cooper";
            this.etCooper.UseVisualStyleBackColor = false;
            this.etCooper.CheckedChanged += new System.EventHandler(this.etCooper_CheckedChanged);
            // 
            // etImpact
            // 
            this.etImpact.AutoSize = true;
            this.etImpact.BackColor = System.Drawing.Color.Transparent;
            this.etImpact.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.etImpact.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etImpact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.etImpact.Location = new System.Drawing.Point(63, 102);
            this.etImpact.Name = "etImpact";
            this.etImpact.Size = new System.Drawing.Size(56, 19);
            this.etImpact.TabIndex = 6;
            this.etImpact.TabStop = true;
            this.etImpact.Text = "Impact";
            this.etImpact.UseVisualStyleBackColor = false;
            this.etImpact.CheckedChanged += new System.EventHandler(this.etImpact_CheckedChanged);
            // 
            // etLucida
            // 
            this.etLucida.AutoSize = true;
            this.etLucida.BackColor = System.Drawing.Color.Transparent;
            this.etLucida.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etLucida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.etLucida.Location = new System.Drawing.Point(6, 102);
            this.etLucida.Name = "etLucida";
            this.etLucida.Size = new System.Drawing.Size(64, 18);
            this.etLucida.TabIndex = 5;
            this.etLucida.TabStop = true;
            this.etLucida.Text = "Lucida ";
            this.etLucida.UseVisualStyleBackColor = false;
            this.etLucida.CheckedChanged += new System.EventHandler(this.etLucida_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estilo de texto";
            // 
            // cfBlue
            // 
            this.cfBlue.AutoSize = true;
            this.cfBlue.BackColor = System.Drawing.Color.Transparent;
            this.cfBlue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cfBlue.Location = new System.Drawing.Point(127, 38);
            this.cfBlue.Name = "cfBlue";
            this.cfBlue.Size = new System.Drawing.Size(45, 17);
            this.cfBlue.TabIndex = 3;
            this.cfBlue.TabStop = true;
            this.cfBlue.Text = "Azul";
            this.cfBlue.UseVisualStyleBackColor = false;
            this.cfBlue.CheckedChanged += new System.EventHandler(this.cfBlue_CheckedChanged);
            // 
            // cfBlack
            // 
            this.cfBlack.AutoSize = true;
            this.cfBlack.BackColor = System.Drawing.Color.Transparent;
            this.cfBlack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cfBlack.Location = new System.Drawing.Point(63, 38);
            this.cfBlack.Name = "cfBlack";
            this.cfBlack.Size = new System.Drawing.Size(54, 17);
            this.cfBlack.TabIndex = 2;
            this.cfBlack.TabStop = true;
            this.cfBlack.Text = "Negro";
            this.cfBlack.UseVisualStyleBackColor = false;
            this.cfBlack.CheckedChanged += new System.EventHandler(this.cfBlack_CheckedChanged);
            // 
            // cfWhite
            // 
            this.cfWhite.AutoSize = true;
            this.cfWhite.BackColor = System.Drawing.Color.Transparent;
            this.cfWhite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cfWhite.Location = new System.Drawing.Point(6, 38);
            this.cfWhite.Name = "cfWhite";
            this.cfWhite.Size = new System.Drawing.Size(58, 17);
            this.cfWhite.TabIndex = 1;
            this.cfWhite.TabStop = true;
            this.cfWhite.Text = "Blanco";
            this.cfWhite.UseVisualStyleBackColor = false;
            this.cfWhite.CheckedChanged += new System.EventHandler(this.cfWhite_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Color de fondo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Opciones";
            // 
            // btnOptionClose
            // 
            this.btnOptionClose.BackColor = System.Drawing.Color.White;
            this.btnOptionClose.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOptionClose.Location = new System.Drawing.Point(159, 7);
            this.btnOptionClose.Name = "btnOptionClose";
            this.btnOptionClose.Size = new System.Drawing.Size(84, 24);
            this.btnOptionClose.TabIndex = 11;
            this.btnOptionClose.Text = "Reiniciar";
            this.btnOptionClose.UseVisualStyleBackColor = false;
            this.btnOptionClose.Click += new System.EventHandler(this.btnOptionClose_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 359);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.homeworkCheckedList);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnVerified);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Home";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnVerified;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.ListBox homeworkCheckedList;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton cfBlue;
        private System.Windows.Forms.RadioButton cfBlack;
        private System.Windows.Forms.RadioButton cfWhite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton etCooper;
        private System.Windows.Forms.RadioButton etImpact;
        private System.Windows.Forms.RadioButton etLucida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton CtBlack;
        private System.Windows.Forms.RadioButton ctWhite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOptionSave;
        private System.Windows.Forms.Button btnOptionClose;
        private System.Windows.Forms.Button button1;
    }
}

