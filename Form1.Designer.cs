namespace CarStimulator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBrake = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.car1 = new System.Windows.Forms.PictureBox();
            this.txtmove = new System.Windows.Forms.Button();
            this.gear1 = new System.Windows.Forms.RadioButton();
            this.gear2 = new System.Windows.Forms.RadioButton();
            this.gear3 = new System.Windows.Forms.RadioButton();
            this.gear4 = new System.Windows.Forms.RadioButton();
            this.txtlaunch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrake
            // 
            this.txtBrake.BackColor = System.Drawing.Color.White;
            this.txtBrake.ForeColor = System.Drawing.Color.Blue;
            this.txtBrake.Location = new System.Drawing.Point(43, 347);
            this.txtBrake.Name = "txtBrake";
            this.txtBrake.Size = new System.Drawing.Size(110, 41);
            this.txtBrake.TabIndex = 0;
            this.txtBrake.Text = "BRAKE";
            this.txtBrake.UseVisualStyleBackColor = false;
            this.txtBrake.Click += new System.EventHandler(this.txtBrake_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // car1
            // 
            this.car1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.car1.BackColor = System.Drawing.Color.Black;
            this.car1.Image = ((System.Drawing.Image)(resources.GetObject("car1.Image")));
            this.car1.Location = new System.Drawing.Point(653, 86);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(174, 104);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 1;
            this.car1.TabStop = false;
            // 
            // txtmove
            // 
            this.txtmove.ForeColor = System.Drawing.Color.Lime;
            this.txtmove.Location = new System.Drawing.Point(667, 347);
            this.txtmove.Name = "txtmove";
            this.txtmove.Size = new System.Drawing.Size(110, 41);
            this.txtmove.TabIndex = 2;
            this.txtmove.Text = "MOVE";
            this.txtmove.UseVisualStyleBackColor = true;
            this.txtmove.Click += new System.EventHandler(this.txtmove_Click);
            // 
            // gear1
            // 
            this.gear1.AutoSize = true;
            this.gear1.BackColor = System.Drawing.Color.White;
            this.gear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gear1.Location = new System.Drawing.Point(355, 249);
            this.gear1.Name = "gear1";
            this.gear1.Size = new System.Drawing.Size(88, 24);
            this.gear1.TabIndex = 3;
            this.gear1.TabStop = true;
            this.gear1.Text = "GEAR1";
            this.gear1.UseVisualStyleBackColor = false;
            this.gear1.CheckedChanged += new System.EventHandler(this.gear1_CheckedChanged);
            // 
            // gear2
            // 
            this.gear2.AutoSize = true;
            this.gear2.BackColor = System.Drawing.Color.White;
            this.gear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gear2.Location = new System.Drawing.Point(355, 292);
            this.gear2.Name = "gear2";
            this.gear2.Size = new System.Drawing.Size(88, 24);
            this.gear2.TabIndex = 4;
            this.gear2.TabStop = true;
            this.gear2.Text = "GEAR2";
            this.gear2.UseVisualStyleBackColor = false;
            this.gear2.CheckedChanged += new System.EventHandler(this.gear2_CheckedChanged);
            // 
            // gear3
            // 
            this.gear3.AutoSize = true;
            this.gear3.BackColor = System.Drawing.Color.White;
            this.gear3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gear3.Location = new System.Drawing.Point(355, 330);
            this.gear3.Name = "gear3";
            this.gear3.Size = new System.Drawing.Size(88, 24);
            this.gear3.TabIndex = 5;
            this.gear3.TabStop = true;
            this.gear3.Text = "GEAR3";
            this.gear3.UseVisualStyleBackColor = false;
            this.gear3.CheckedChanged += new System.EventHandler(this.gear3_CheckedChanged);
            // 
            // gear4
            // 
            this.gear4.AutoSize = true;
            this.gear4.BackColor = System.Drawing.Color.White;
            this.gear4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gear4.Location = new System.Drawing.Point(355, 364);
            this.gear4.Name = "gear4";
            this.gear4.Size = new System.Drawing.Size(88, 24);
            this.gear4.TabIndex = 6;
            this.gear4.TabStop = true;
            this.gear4.Text = "GEAR4";
            this.gear4.UseVisualStyleBackColor = false;
            this.gear4.CheckedChanged += new System.EventHandler(this.gear4_CheckedChanged);
            // 
            // txtlaunch
            // 
            this.txtlaunch.ForeColor = System.Drawing.Color.Red;
            this.txtlaunch.Location = new System.Drawing.Point(667, 266);
            this.txtlaunch.Name = "txtlaunch";
            this.txtlaunch.Size = new System.Drawing.Size(110, 41);
            this.txtlaunch.TabIndex = 7;
            this.txtlaunch.Text = "LAUNCH";
            this.txtlaunch.UseVisualStyleBackColor = true;
            this.txtlaunch.Click += new System.EventHandler(this.txtlaunch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 407);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.txtlaunch);
            this.Controls.Add(this.gear4);
            this.Controls.Add(this.gear3);
            this.Controls.Add(this.gear2);
            this.Controls.Add(this.gear1);
            this.Controls.Add(this.txtmove);
            this.Controls.Add(this.txtBrake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtBrake;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.Button txtmove;
        private System.Windows.Forms.RadioButton gear1;
        private System.Windows.Forms.RadioButton gear2;
        private System.Windows.Forms.RadioButton gear3;
        private System.Windows.Forms.RadioButton gear4;
        private System.Windows.Forms.Button txtlaunch;
    }
}

