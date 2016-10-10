namespace MenuTest
{
    partial class HomeScreen
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
            this.Page1 = new System.Windows.Forms.Panel();
            this.confirm = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.newPlayer = new System.Windows.Forms.TextBox();
            this.Page1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.confirm);
            this.Page1.Controls.Add(this.Start);
            this.Page1.Controls.Add(this.label2);
            this.Page1.Controls.Add(this.label1);
            this.Page1.Controls.Add(this.create);
            this.Page1.Controls.Add(this.newPlayer);
            this.Page1.Location = new System.Drawing.Point(48, 41);
            this.Page1.Name = "Page1";
            this.Page1.Size = new System.Drawing.Size(395, 261);
            this.Page1.TabIndex = 2;
            this.Page1.Visible = false;
            // 
            // confirm
            // 
            this.confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm.AutoSize = true;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(157, 99);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(81, 24);
            this.confirm.TabIndex = 4;
            this.confirm.Text = "Created:";
            this.confirm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirm.Visible = false;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(157, 144);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Visible = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your name:";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(250, 94);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(71, 23);
            this.create.TabIndex = 1;
            this.create.Text = "Create ";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // newPlayer
            // 
            this.newPlayer.Location = new System.Drawing.Point(157, 94);
            this.newPlayer.Name = "newPlayer";
            this.newPlayer.Size = new System.Drawing.Size(87, 20);
            this.newPlayer.TabIndex = 0;
            this.newPlayer.TextChanged += new System.EventHandler(this.newPlayer_TextChanged);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 339);
            this.Controls.Add(this.Page1);
            this.KeyPreview = true;
            this.Name = "HomeScreen";
            this.Text = "Form1";
            this.Page1.ResumeLayout(false);
            this.Page1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Page1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox newPlayer;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label confirm;
    }
}

