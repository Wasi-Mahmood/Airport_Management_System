
namespace DBMS_PROJECT_winform
{
    partial class Flights
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Show_DEP_Flights_btn = new System.Windows.Forms.Button();
            this.Show_ARR_Flights = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(793, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 467);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(793, 257);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arrivals";
            // 
            // Show_DEP_Flights_btn
            // 
            this.Show_DEP_Flights_btn.Location = new System.Drawing.Point(683, 83);
            this.Show_DEP_Flights_btn.Name = "Show_DEP_Flights_btn";
            this.Show_DEP_Flights_btn.Size = new System.Drawing.Size(113, 26);
            this.Show_DEP_Flights_btn.TabIndex = 4;
            this.Show_DEP_Flights_btn.Text = "Show Flights";
            this.Show_DEP_Flights_btn.UseVisualStyleBackColor = true;
            this.Show_DEP_Flights_btn.Click += new System.EventHandler(this.Show_DEP_Flights_btn_Click);
            // 
            // Show_ARR_Flights
            // 
            this.Show_ARR_Flights.Location = new System.Drawing.Point(683, 438);
            this.Show_ARR_Flights.Name = "Show_ARR_Flights";
            this.Show_ARR_Flights.Size = new System.Drawing.Size(113, 26);
            this.Show_ARR_Flights.TabIndex = 5;
            this.Show_ARR_Flights.Text = "Show Flights";
            this.Show_ARR_Flights.UseVisualStyleBackColor = true;
            this.Show_ARR_Flights.Click += new System.EventHandler(this.Show_ARR_Flights_Click);
            // 
            // Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 749);
            this.Controls.Add(this.Show_ARR_Flights);
            this.Controls.Add(this.Show_DEP_Flights_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Flights";
            this.Text = "Flights";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Show_DEP_Flights_btn;
        private System.Windows.Forms.Button Show_ARR_Flights;
    }
}