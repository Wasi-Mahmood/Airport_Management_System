
namespace DBMS_PROJECT_winform
{
    partial class Tickets
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BookingRefSearch_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookingREF_Serach_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(758, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // BookingRefSearch_txtBox
            // 
            this.BookingRefSearch_txtBox.Location = new System.Drawing.Point(405, 105);
            this.BookingRefSearch_txtBox.Name = "BookingRefSearch_txtBox";
            this.BookingRefSearch_txtBox.Size = new System.Drawing.Size(100, 23);
            this.BookingRefSearch_txtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "BOOKING REFERENCE";
            // 
            // BookingREF_Serach_BTN
            // 
            this.BookingREF_Serach_BTN.Location = new System.Drawing.Point(647, 105);
            this.BookingREF_Serach_BTN.Name = "BookingREF_Serach_BTN";
            this.BookingREF_Serach_BTN.Size = new System.Drawing.Size(75, 23);
            this.BookingREF_Serach_BTN.TabIndex = 3;
            this.BookingREF_Serach_BTN.Text = "Search";
            this.BookingREF_Serach_BTN.UseVisualStyleBackColor = true;
            this.BookingREF_Serach_BTN.Click += new System.EventHandler(this.BookingREF_Serach_BTN_Click);
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookingREF_Serach_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookingRefSearch_txtBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Tickets";
            this.Text = "Tickets";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox BookingRefSearch_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BookingREF_Serach_BTN;
    }
}