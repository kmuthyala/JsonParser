namespace JsonUtils.Client
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
      this.lblJson = new System.Windows.Forms.Label();
      this.txtInput = new System.Windows.Forms.TextBox();
      this.btnParse = new System.Windows.Forms.Button();
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lblJson
      // 
      this.lblJson.AutoSize = true;
      this.lblJson.Location = new System.Drawing.Point(35, 86);
      this.lblJson.Name = "lblJson";
      this.lblJson.Size = new System.Drawing.Size(153, 32);
      this.lblJson.TabIndex = 0;
      this.lblJson.Text = "Input Json:";
      // 
      // txtInput
      // 
      this.txtInput.Location = new System.Drawing.Point(213, 86);
      this.txtInput.Multiline = true;
      this.txtInput.Name = "txtInput";
      this.txtInput.Size = new System.Drawing.Size(2648, 640);
      this.txtInput.TabIndex = 1;
      // 
      // btnParse
      // 
      this.btnParse.Location = new System.Drawing.Point(223, 759);
      this.btnParse.Name = "btnParse";
      this.btnParse.Size = new System.Drawing.Size(250, 70);
      this.btnParse.TabIndex = 2;
      this.btnParse.Text = "Parse";
      this.btnParse.UseVisualStyleBackColor = true;
      this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
      // 
      // txtOutput
      // 
      this.txtOutput.Location = new System.Drawing.Point(213, 866);
      this.txtOutput.Multiline = true;
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.Size = new System.Drawing.Size(2648, 563);
      this.txtOutput.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(3140, 1526);
      this.Controls.Add(this.txtOutput);
      this.Controls.Add(this.btnParse);
      this.Controls.Add(this.txtInput);
      this.Controls.Add(this.lblJson);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblJson;
    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.Button btnParse;
    private System.Windows.Forms.TextBox txtOutput;
  }
}

