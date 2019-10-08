namespace WindowsFormsApp1
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
            this.txtNumOneInput = new System.Windows.Forms.TextBox();
            this.txtNum2Input = new System.Windows.Forms.TextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnDelegate = new System.Windows.Forms.Button();
            this.btnDelegateAlt = new System.Windows.Forms.Button();
            this.btnLamda = new System.Windows.Forms.Button();
            this.btnEnumerateCollection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "num 1 input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "num 2 Input:";
            // 
            // txtNumOneInput
            // 
            this.txtNumOneInput.Location = new System.Drawing.Point(107, 36);
            this.txtNumOneInput.Name = "txtNumOneInput";
            this.txtNumOneInput.Size = new System.Drawing.Size(100, 20);
            this.txtNumOneInput.TabIndex = 2;
            // 
            // txtNum2Input
            // 
            this.txtNum2Input.Location = new System.Drawing.Point(107, 78);
            this.txtNum2Input.Name = "txtNum2Input";
            this.txtNum2Input.Size = new System.Drawing.Size(100, 20);
            this.txtNum2Input.TabIndex = 3;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(40, 129);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(167, 112);
            this.rtbOutput.TabIndex = 4;
            this.rtbOutput.Text = "";
            // 
            // btnDelegate
            // 
            this.btnDelegate.Location = new System.Drawing.Point(40, 272);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Size = new System.Drawing.Size(75, 23);
            this.btnDelegate.TabIndex = 5;
            this.btnDelegate.Text = "Delegate";
            this.btnDelegate.UseVisualStyleBackColor = true;
            this.btnDelegate.Click += new System.EventHandler(this.BtnDelegate_Click);
            // 
            // btnDelegateAlt
            // 
            this.btnDelegateAlt.Location = new System.Drawing.Point(40, 318);
            this.btnDelegateAlt.Name = "btnDelegateAlt";
            this.btnDelegateAlt.Size = new System.Drawing.Size(75, 23);
            this.btnDelegateAlt.TabIndex = 6;
            this.btnDelegateAlt.Text = "Delegate 2";
            this.btnDelegateAlt.UseVisualStyleBackColor = true;
            this.btnDelegateAlt.Click += new System.EventHandler(this.BtnDelegateAlt_Click);
            // 
            // btnLamda
            // 
            this.btnLamda.Location = new System.Drawing.Point(134, 272);
            this.btnLamda.Name = "btnLamda";
            this.btnLamda.Size = new System.Drawing.Size(75, 23);
            this.btnLamda.TabIndex = 7;
            this.btnLamda.Text = "Lamda";
            this.btnLamda.UseVisualStyleBackColor = true;
            this.btnLamda.Click += new System.EventHandler(this.BtnLamda_Click);
            // 
            // btnEnumerateCollection
            // 
            this.btnEnumerateCollection.Location = new System.Drawing.Point(134, 318);
            this.btnEnumerateCollection.Name = "btnEnumerateCollection";
            this.btnEnumerateCollection.Size = new System.Drawing.Size(75, 23);
            this.btnEnumerateCollection.TabIndex = 8;
            this.btnEnumerateCollection.Text = "Collection";
            this.btnEnumerateCollection.UseVisualStyleBackColor = true;
            this.btnEnumerateCollection.Click += new System.EventHandler(this.BtnEnumerateCollection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 400);
            this.Controls.Add(this.btnEnumerateCollection);
            this.Controls.Add(this.btnLamda);
            this.Controls.Add(this.btnDelegateAlt);
            this.Controls.Add(this.btnDelegate);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.txtNum2Input);
            this.Controls.Add(this.txtNumOneInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Delegate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumOneInput;
        private System.Windows.Forms.TextBox txtNum2Input;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnDelegate;
        private System.Windows.Forms.Button btnDelegateAlt;
        private System.Windows.Forms.Button btnLamda;
        private System.Windows.Forms.Button btnEnumerateCollection;
    }
}

