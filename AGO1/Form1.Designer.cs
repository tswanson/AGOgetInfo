namespace AGO1
{
  partial class AGO_Org
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
        this.orgTxt = new System.Windows.Forms.TextBox();
        this.userTxt = new System.Windows.Forms.TextBox();
        this.pwdTxt = new System.Windows.Forms.TextBox();
        this.goBtn = new System.Windows.Forms.Button();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.logTxt = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.label6 = new System.Windows.Forms.Label();
        this.label7 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        this.SuspendLayout();
        // 
        // orgTxt
        // 
        this.orgTxt.Location = new System.Drawing.Point(95, 11);
        this.orgTxt.Name = "orgTxt";
        this.orgTxt.Size = new System.Drawing.Size(179, 20);
        this.orgTxt.TabIndex = 0;
        this.orgTxt.Text = "org id";
        // 
        // userTxt
        // 
        this.userTxt.Location = new System.Drawing.Point(93, 41);
        this.userTxt.Name = "userTxt";
        this.userTxt.Size = new System.Drawing.Size(179, 20);
        this.userTxt.TabIndex = 1;
        this.userTxt.Text = "username";
        // 
        // pwdTxt
        // 
        this.pwdTxt.Location = new System.Drawing.Point(93, 72);
        this.pwdTxt.Name = "pwdTxt";
        this.pwdTxt.PasswordChar = '*';
        this.pwdTxt.Size = new System.Drawing.Size(179, 20);
        this.pwdTxt.TabIndex = 2;
        // 
        // goBtn
        // 
        this.goBtn.Location = new System.Drawing.Point(95, 105);
        this.goBtn.Name = "goBtn";
        this.goBtn.Size = new System.Drawing.Size(176, 35);
        this.goBtn.TabIndex = 3;
        this.goBtn.Text = "Go!";
        this.goBtn.UseVisualStyleBackColor = true;
        this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
        // 
        // dataGridView1
        // 
        this.dataGridView1.AllowUserToAddRows = false;
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Location = new System.Drawing.Point(22, 180);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.ReadOnly = true;
        this.dataGridView1.Size = new System.Drawing.Size(1160, 211);
        this.dataGridView1.TabIndex = 4;
        // 
        // openFileDialog1
        // 
        this.openFileDialog1.FileName = "openFileDialog1";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(13, 18);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(66, 13);
        this.label1.TabIndex = 5;
        this.label1.Text = "Organization";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(12, 48);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(58, 13);
        this.label2.TabIndex = 6;
        this.label2.Text = "User Login";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(12, 75);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(53, 13);
        this.label3.TabIndex = 7;
        this.label3.Text = "Password";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label4.Location = new System.Drawing.Point(289, 124);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(471, 16);
        this.label4.TabIndex = 8;
        this.label4.Text = "Output written to C:\\Temp\\AGO_OrgData.csv and AGO_OrgUser.csv";
        // 
        // logTxt
        // 
        this.logTxt.Location = new System.Drawing.Point(22, 417);
        this.logTxt.Multiline = true;
        this.logTxt.Name = "logTxt";
        this.logTxt.Size = new System.Drawing.Size(1160, 175);
        this.logTxt.TabIndex = 9;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label5.Location = new System.Drawing.Point(289, 16);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(271, 16);
        this.label5.TabIndex = 10;
        this.label5.Text = "Precedes maps.arcgis.com for org url.";
        this.label5.Click += new System.EventHandler(this.label5_Click);
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label6.Location = new System.Drawing.Point(289, 46);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(178, 16);
        this.label6.TabIndex = 11;
        this.label6.Text = "Must be an Administrator";
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label7.Location = new System.Drawing.Point(289, 150);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(279, 16);
        this.label7.TabIndex = 12;
        this.label7.Text = "Process may take a minute to complete";
        // 
        // AGO_Org
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1218, 616);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.logTxt);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.dataGridView1);
        this.Controls.Add(this.goBtn);
        this.Controls.Add(this.pwdTxt);
        this.Controls.Add(this.userTxt);
        this.Controls.Add(this.orgTxt);
        this.Name = "AGO_Org";
        this.Text = "AGO_Org";
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox orgTxt;
    private System.Windows.Forms.TextBox userTxt;
    private System.Windows.Forms.TextBox pwdTxt;
    private System.Windows.Forms.Button goBtn;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    public System.Windows.Forms.TextBox logTxt;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
  }
}

