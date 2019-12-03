using System;

namespace Russian_Roulette
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
            this.gunfirepic = new System.Windows.Forms.PictureBox();
            this.chamberspinpic = new System.Windows.Forms.PictureBox();
            this.openchamberpic = new System.Windows.Forms.PictureBox();
            this.missfirepic = new System.Windows.Forms.PictureBox();
            this.btnshoot = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnsecondfire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gunfirepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamberspinpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openchamberpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missfirepic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil Std", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Russian Roulette";
            // 
            // gunfirepic
            // 
            this.gunfirepic.BackColor = System.Drawing.Color.Transparent;
            this.gunfirepic.Enabled = false;
            this.gunfirepic.Image = global::Russian_Roulette.Properties.Resources._3_32aG;
            this.gunfirepic.Location = new System.Drawing.Point(181, 85);
            this.gunfirepic.Name = "gunfirepic";
            this.gunfirepic.Size = new System.Drawing.Size(507, 254);
            this.gunfirepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunfirepic.TabIndex = 1;
            this.gunfirepic.TabStop = false;
            this.gunfirepic.Visible = false;
            // 
            // chamberspinpic
            // 
            this.chamberspinpic.BackColor = System.Drawing.Color.Transparent;
            this.chamberspinpic.Enabled = false;
            this.chamberspinpic.Image = global::Russian_Roulette.Properties.Resources._4726214_9972460655_tumbl;
            this.chamberspinpic.Location = new System.Drawing.Point(181, 85);
            this.chamberspinpic.Name = "chamberspinpic";
            this.chamberspinpic.Size = new System.Drawing.Size(507, 254);
            this.chamberspinpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chamberspinpic.TabIndex = 2;
            this.chamberspinpic.TabStop = false;
            this.chamberspinpic.Visible = false;
            // 
            // openchamberpic
            // 
            this.openchamberpic.BackColor = System.Drawing.Color.Transparent;
            this.openchamberpic.Enabled = false;
            this.openchamberpic.Image = global::Russian_Roulette.Properties.Resources.iIprA0Kb_o;
            this.openchamberpic.Location = new System.Drawing.Point(181, 85);
            this.openchamberpic.Name = "openchamberpic";
            this.openchamberpic.Size = new System.Drawing.Size(507, 254);
            this.openchamberpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openchamberpic.TabIndex = 3;
            this.openchamberpic.TabStop = false;
            this.openchamberpic.Click += new System.EventHandler(this.openchamberpic_Click);
            // 
            // missfirepic
            // 
            this.missfirepic.BackColor = System.Drawing.Color.Transparent;
            this.missfirepic.Enabled = false;
            this.missfirepic.Image = global::Russian_Roulette.Properties.Resources.Untitled;
            this.missfirepic.Location = new System.Drawing.Point(192, 85);
            this.missfirepic.Name = "missfirepic";
            this.missfirepic.Size = new System.Drawing.Size(507, 254);
            this.missfirepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.missfirepic.TabIndex = 4;
            this.missfirepic.TabStop = false;
            this.missfirepic.Visible = false;
            this.missfirepic.Click += new System.EventHandler(this.missfirepic_Click);
            // 
            // btnshoot
            // 
            this.btnshoot.BackColor = System.Drawing.Color.Transparent;
            this.btnshoot.Enabled = false;
            this.btnshoot.Font = new System.Drawing.Font("Stencil Std", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshoot.Location = new System.Drawing.Point(279, 381);
            this.btnshoot.Name = "btnshoot";
            this.btnshoot.Size = new System.Drawing.Size(131, 78);
            this.btnshoot.TabIndex = 6;
            this.btnshoot.Text = "Shoot Away";
            this.btnshoot.UseVisualStyleBackColor = false;
            this.btnshoot.Click += new System.EventHandler(this.Btnshoot_Click);
            // 
            // btnplay
            // 
            this.btnplay.BackColor = System.Drawing.Color.Transparent;
            this.btnplay.Enabled = false;
            this.btnplay.Font = new System.Drawing.Font("Stencil Std", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.Location = new System.Drawing.Point(614, 381);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(137, 78);
            this.btnplay.TabIndex = 7;
            this.btnplay.Text = "Play Again";
            this.btnplay.UseVisualStyleBackColor = false;
            this.btnplay.Click += new System.EventHandler(this.Btnplay_Click);
            // 
            // btnload
            // 
            this.btnload.Font = new System.Drawing.Font("Stencil Std", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(119, 381);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(137, 78);
            this.btnload.TabIndex = 8;
            this.btnload.Text = "Load Bullet";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.Btnload_Click_1);
            // 
            // btnsecondfire
            // 
            this.btnsecondfire.BackColor = System.Drawing.Color.Transparent;
            this.btnsecondfire.Enabled = false;
            this.btnsecondfire.Font = new System.Drawing.Font("Stencil Std", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsecondfire.Location = new System.Drawing.Point(440, 381);
            this.btnsecondfire.Name = "btnsecondfire";
            this.btnsecondfire.Size = new System.Drawing.Size(140, 78);
            this.btnsecondfire.TabIndex = 9;
            this.btnsecondfire.Text = "Second Shot";
            this.btnsecondfire.UseVisualStyleBackColor = false;
            this.btnsecondfire.Click += new System.EventHandler(this.Btnsecondfire_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Russian_Roulette.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(888, 503);
            this.Controls.Add(this.btnsecondfire);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.btnshoot);
            this.Controls.Add(this.missfirepic);
            this.Controls.Add(this.openchamberpic);
            this.Controls.Add(this.chamberspinpic);
            this.Controls.Add(this.gunfirepic);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Russian Roulette";
            ((System.ComponentModel.ISupportInitialize)(this.gunfirepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamberspinpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openchamberpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missfirepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Btnload_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox gunfirepic;
        private System.Windows.Forms.PictureBox chamberspinpic;
        private System.Windows.Forms.PictureBox openchamberpic;
        private System.Windows.Forms.PictureBox missfirepic;
        private System.Windows.Forms.Button btnshoot;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnsecondfire;
    }
}

