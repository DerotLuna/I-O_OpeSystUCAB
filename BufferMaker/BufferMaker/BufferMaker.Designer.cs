namespace BufferMaker
{
    partial class BufferMaker
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BufferMaker));
            this.controllerOption = new System.Windows.Forms.ComboBox();
            this.actionOption = new System.Windows.Forms.ComboBox();
            this.textRoute = new System.Windows.Forms.TextBox();
            this.textContent = new System.Windows.Forms.RichTextBox();
            this.controller = new System.Windows.Forms.Label();
            this.action = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.createBuffer = new System.Windows.Forms.Button();
            this.formatOption = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.informant = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // controllerOption
            // 
            this.controllerOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controllerOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controllerOption.FormattingEnabled = true;
            this.controllerOption.Location = new System.Drawing.Point(125, 22);
            this.controllerOption.Name = "controllerOption";
            this.controllerOption.Size = new System.Drawing.Size(160, 21);
            this.controllerOption.TabIndex = 0;
            // 
            // actionOption
            // 
            this.actionOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actionOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionOption.FormattingEnabled = true;
            this.actionOption.Location = new System.Drawing.Point(125, 49);
            this.actionOption.Name = "actionOption";
            this.actionOption.Size = new System.Drawing.Size(160, 21);
            this.actionOption.TabIndex = 1;
            // 
            // textRoute
            // 
            this.textRoute.Location = new System.Drawing.Point(125, 80);
            this.textRoute.Name = "textRoute";
            this.textRoute.Size = new System.Drawing.Size(160, 20);
            this.textRoute.TabIndex = 2;
            this.textRoute.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textContent
            // 
            this.textContent.Location = new System.Drawing.Point(18, 176);
            this.textContent.Name = "textContent";
            this.textContent.Size = new System.Drawing.Size(146, 120);
            this.textContent.TabIndex = 3;
            this.textContent.Text = "";
            // 
            // controller
            // 
            this.controller.AutoSize = true;
            this.controller.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controller.Location = new System.Drawing.Point(12, 25);
            this.controller.Name = "controller";
            this.controller.Size = new System.Drawing.Size(61, 13);
            this.controller.TabIndex = 4;
            this.controller.Text = "Controller";
            // 
            // action
            // 
            this.action.AutoSize = true;
            this.action.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action.Location = new System.Drawing.Point(15, 53);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(43, 13);
            this.action.TabIndex = 5;
            this.action.Text = "Action";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Direction/Route";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "File name";
            // 
            // textFileName
            // 
            this.textFileName.Location = new System.Drawing.Point(125, 106);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(160, 20);
            this.textFileName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Content";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // createBuffer
            // 
            this.createBuffer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBuffer.Location = new System.Drawing.Point(18, 302);
            this.createBuffer.Name = "createBuffer";
            this.createBuffer.Size = new System.Drawing.Size(75, 23);
            this.createBuffer.TabIndex = 10;
            this.createBuffer.Text = " Create buffer";
            this.createBuffer.UseVisualStyleBackColor = true;
            this.createBuffer.Click += new System.EventHandler(this.createBuffer_Click);
            // 
            // formatOption
            // 
            this.formatOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formatOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatOption.FormattingEnabled = true;
            this.formatOption.Location = new System.Drawing.Point(125, 133);
            this.formatOption.Name = "formatOption";
            this.formatOption.Size = new System.Drawing.Size(160, 21);
            this.formatOption.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "File format";
            // 
            // informant
            // 
            this.informant.BackColor = System.Drawing.SystemColors.ControlLight;
            this.informant.Cursor = System.Windows.Forms.Cursors.No;
            this.informant.Location = new System.Drawing.Point(170, 177);
            this.informant.Name = "informant";
            this.informant.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.informant.Size = new System.Drawing.Size(115, 119);
            this.informant.TabIndex = 13;
            this.informant.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(170, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Information";
            // 
            // BufferMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.informant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formatOption);
            this.Controls.Add(this.createBuffer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.action);
            this.Controls.Add(this.controller);
            this.Controls.Add(this.textContent);
            this.Controls.Add(this.textRoute);
            this.Controls.Add(this.actionOption);
            this.Controls.Add(this.controllerOption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(319, 377);
            this.MinimumSize = new System.Drawing.Size(319, 377);
            this.Name = "BufferMaker";
            this.Text = "Buffer Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox controllerOption;
        private System.Windows.Forms.ComboBox actionOption;
        private System.Windows.Forms.TextBox textRoute;
        private System.Windows.Forms.RichTextBox textContent;
        private System.Windows.Forms.Label controller;
        private System.Windows.Forms.Label action;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createBuffer;
        private System.Windows.Forms.ComboBox formatOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox informant;
        private System.Windows.Forms.Label label2;
    }
}

