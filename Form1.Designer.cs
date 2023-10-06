namespace FileIODemoProduct
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btncreateDirectory = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnStreWrite = new System.Windows.Forms.Button();
            this.btnStreamRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product price";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(245, 85);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(241, 22);
            this.txtID.TabIndex = 3;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(245, 196);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(241, 22);
            this.txtProductName.TabIndex = 4;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(245, 312);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(241, 22);
            this.txtProductPrice.TabIndex = 5;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(91, 389);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(185, 71);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(383, 389);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(164, 65);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncreateDirectory
            // 
            this.btncreateDirectory.Location = new System.Drawing.Point(536, 80);
            this.btncreateDirectory.Name = "btncreateDirectory";
            this.btncreateDirectory.Size = new System.Drawing.Size(164, 51);
            this.btncreateDirectory.TabIndex = 8;
            this.btncreateDirectory.Text = "Create Directory";
            this.btncreateDirectory.UseVisualStyleBackColor = true;
            this.btncreateDirectory.Click += new System.EventHandler(this.btncreateDirectory_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(536, 190);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(161, 49);
            this.btnCreateFile.TabIndex = 9;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(799, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 96);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnStreWrite
            // 
            this.btnStreWrite.Location = new System.Drawing.Point(799, 204);
            this.btnStreWrite.Name = "btnStreWrite";
            this.btnStreWrite.Size = new System.Drawing.Size(169, 56);
            this.btnStreWrite.TabIndex = 12;
            this.btnStreWrite.Text = "Stream Write";
            this.btnStreWrite.UseVisualStyleBackColor = true;
            this.btnStreWrite.Click += new System.EventHandler(this.btnStreWrite_Click);
            // 
            // btnStreamRead
            // 
            this.btnStreamRead.Location = new System.Drawing.Point(997, 206);
            this.btnStreamRead.Name = "btnStreamRead";
            this.btnStreamRead.Size = new System.Drawing.Size(147, 54);
            this.btnStreamRead.TabIndex = 13;
            this.btnStreamRead.Text = "Stream Read";
            this.btnStreamRead.UseVisualStyleBackColor = true;
            this.btnStreamRead.Click += new System.EventHandler(this.btnStreamRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 692);
            this.Controls.Add(this.btnStreamRead);
            this.Controls.Add(this.btnStreWrite);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btncreateDirectory);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "    ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btncreateDirectory;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnStreWrite;
        private System.Windows.Forms.Button btnStreamRead;
    }
}

