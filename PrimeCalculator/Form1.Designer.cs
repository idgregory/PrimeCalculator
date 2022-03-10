
namespace PrimeCalculator
{
    partial class MainWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckPrimeBtn = new System.Windows.Forms.Button();
            this.PrimeNumTextBox = new System.Windows.Forms.TextBox();
            this.PrimeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CheckPrimeBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.PrimeNumTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PrimeLabel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 83);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number";
            // 
            // CheckPrimeBtn
            // 
            this.CheckPrimeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CheckPrimeBtn.Location = new System.Drawing.Point(525, 20);
            this.CheckPrimeBtn.Name = "CheckPrimeBtn";
            this.CheckPrimeBtn.Size = new System.Drawing.Size(75, 23);
            this.CheckPrimeBtn.TabIndex = 2;
            this.CheckPrimeBtn.Text = "Check";
            this.CheckPrimeBtn.UseVisualStyleBackColor = true;
            this.CheckPrimeBtn.Click += new System.EventHandler(this.CheckPrimeBtn_Click);
            // 
            // PrimeNumTextBox
            // 
            this.PrimeNumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimeNumTextBox.Location = new System.Drawing.Point(264, 21);
            this.PrimeNumTextBox.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.PrimeNumTextBox.Name = "PrimeNumTextBox";
            this.PrimeNumTextBox.Size = new System.Drawing.Size(255, 20);
            this.PrimeNumTextBox.TabIndex = 1;
            // 
            // PrimeLabel
            // 
            this.PrimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrimeLabel.AutoSize = true;
            this.PrimeLabel.Location = new System.Drawing.Point(365, 66);
            this.PrimeLabel.Name = "PrimeLabel";
            this.PrimeLabel.Size = new System.Drawing.Size(53, 13);
            this.PrimeLabel.TabIndex = 3;
            this.PrimeLabel.Text = "Not Prime";
            this.PrimeLabel.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 111);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(800, 150);
            this.MinimumSize = new System.Drawing.Size(424, 150);
            this.Name = "MainWindow";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Prime Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrimeNumTextBox;
        private System.Windows.Forms.Button CheckPrimeBtn;
        private System.Windows.Forms.Label PrimeLabel;
    }
}

