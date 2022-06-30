
namespace DBMS_PROJECT_winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Flights_btn = new System.Windows.Forms.Button();
            this.Terminal_btn = new System.Windows.Forms.Button();
            this.Tickets_btn = new System.Windows.Forms.Button();
            this.Passengers_btn = new System.Windows.Forms.Button();
            this.Aircrafts_btn = new System.Windows.Forms.Button();
            this.Boarded_passengers_btn = new System.Windows.Forms.Button();
            this.Passport_btn = new System.Windows.Forms.Button();
            this.Airlines_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Flights_btn
            // 
            this.Flights_btn.Location = new System.Drawing.Point(310, 126);
            this.Flights_btn.Name = "Flights_btn";
            this.Flights_btn.Size = new System.Drawing.Size(175, 23);
            this.Flights_btn.TabIndex = 0;
            this.Flights_btn.Text = "Flights";
            this.Flights_btn.UseVisualStyleBackColor = true;
            this.Flights_btn.Click += new System.EventHandler(this.Flights_btn_Click);
            // 
            // Terminal_btn
            // 
            this.Terminal_btn.Location = new System.Drawing.Point(310, 155);
            this.Terminal_btn.Name = "Terminal_btn";
            this.Terminal_btn.Size = new System.Drawing.Size(175, 23);
            this.Terminal_btn.TabIndex = 1;
            this.Terminal_btn.Text = "Terminals";
            this.Terminal_btn.UseVisualStyleBackColor = true;
            this.Terminal_btn.Click += new System.EventHandler(this.Terminal_btn_Click);
            // 
            // Tickets_btn
            // 
            this.Tickets_btn.Location = new System.Drawing.Point(310, 184);
            this.Tickets_btn.Name = "Tickets_btn";
            this.Tickets_btn.Size = new System.Drawing.Size(175, 23);
            this.Tickets_btn.TabIndex = 2;
            this.Tickets_btn.Text = "Tickets";
            this.Tickets_btn.UseVisualStyleBackColor = true;
            this.Tickets_btn.Click += new System.EventHandler(this.Tickets_btn_Click);
            // 
            // Passengers_btn
            // 
            this.Passengers_btn.Location = new System.Drawing.Point(310, 213);
            this.Passengers_btn.Name = "Passengers_btn";
            this.Passengers_btn.Size = new System.Drawing.Size(175, 23);
            this.Passengers_btn.TabIndex = 3;
            this.Passengers_btn.Text = "Passengers";
            this.Passengers_btn.UseVisualStyleBackColor = true;
            this.Passengers_btn.Click += new System.EventHandler(this.Passengers_btn_Click);
            // 
            // Aircrafts_btn
            // 
            this.Aircrafts_btn.Location = new System.Drawing.Point(310, 271);
            this.Aircrafts_btn.Name = "Aircrafts_btn";
            this.Aircrafts_btn.Size = new System.Drawing.Size(175, 23);
            this.Aircrafts_btn.TabIndex = 5;
            this.Aircrafts_btn.Text = "Aircrafts";
            this.Aircrafts_btn.UseVisualStyleBackColor = true;
            this.Aircrafts_btn.Click += new System.EventHandler(this.Aircrafts_btn_Click);
            // 
            // Boarded_passengers_btn
            // 
            this.Boarded_passengers_btn.Location = new System.Drawing.Point(310, 300);
            this.Boarded_passengers_btn.Name = "Boarded_passengers_btn";
            this.Boarded_passengers_btn.Size = new System.Drawing.Size(175, 23);
            this.Boarded_passengers_btn.TabIndex = 6;
            this.Boarded_passengers_btn.Text = "Boarded Passengers";
            this.Boarded_passengers_btn.UseVisualStyleBackColor = true;
            this.Boarded_passengers_btn.Click += new System.EventHandler(this.Boarded_passengers_btn_Click);
            // 
            // Passport_btn
            // 
            this.Passport_btn.Location = new System.Drawing.Point(310, 329);
            this.Passport_btn.Name = "Passport_btn";
            this.Passport_btn.Size = new System.Drawing.Size(175, 22);
            this.Passport_btn.TabIndex = 7;
            this.Passport_btn.Text = "Passport";
            this.Passport_btn.UseVisualStyleBackColor = true;
            this.Passport_btn.Click += new System.EventHandler(this.Passport_btn_Click);
            // 
            // Airlines_btn
            // 
            this.Airlines_btn.Location = new System.Drawing.Point(310, 243);
            this.Airlines_btn.Name = "Airlines_btn";
            this.Airlines_btn.Size = new System.Drawing.Size(175, 23);
            this.Airlines_btn.TabIndex = 8;
            this.Airlines_btn.Text = "Airlines";
            this.Airlines_btn.UseVisualStyleBackColor = true;
            this.Airlines_btn.Click += new System.EventHandler(this.Airlines_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Airlines_btn);
            this.Controls.Add(this.Passport_btn);
            this.Controls.Add(this.Boarded_passengers_btn);
            this.Controls.Add(this.Aircrafts_btn);
            this.Controls.Add(this.Passengers_btn);
            this.Controls.Add(this.Tickets_btn);
            this.Controls.Add(this.Terminal_btn);
            this.Controls.Add(this.Flights_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Flights_btn;
        private System.Windows.Forms.Button Terminal_btn;
        private System.Windows.Forms.Button Tickets_btn;
        private System.Windows.Forms.Button Passengers_btn;
        private System.Windows.Forms.Button Aircrafts_btn;
        private System.Windows.Forms.Button Boarded_passengers_btn;
        private System.Windows.Forms.Button Passport_btn;
        private System.Windows.Forms.Button Airlines_btn;
    }
}

