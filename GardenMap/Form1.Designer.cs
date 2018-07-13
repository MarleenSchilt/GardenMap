namespace GardenMap
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
            this.roundButton2 = new GardenMap.RoundButton();
            this.roundButton1 = new GardenMap.RoundButton();
            this.roundButton3 = new GardenMap.RoundButton();
            this.SuspendLayout();
            // 
            // roundButton2
            // 
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Location = new System.Drawing.Point(366, 196);
            this.roundButton2.Margin = new System.Windows.Forms.Padding(0);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(75, 75);
            this.roundButton2.TabIndex = 1;
            this.roundButton2.Text = "Acer";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Location = new System.Drawing.Point(390, 110);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(0);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(75, 75);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "Clematis";
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // roundButton3
            // 
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Location = new System.Drawing.Point(105, 247);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(75, 75);
            this.roundButton3.TabIndex = 2;
            this.roundButton3.Text = "roundButton3";
            this.roundButton3.UseVisualStyleBackColor = true;
            this.roundButton3.Click += new System.EventHandler(this.roundButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GardenMap.Properties.Resources.achtergrond_tuin;
            this.ClientSize = new System.Drawing.Size(484, 761);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private RoundButton roundButton3;
    }
}

