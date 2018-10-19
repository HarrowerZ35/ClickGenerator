namespace Clicl_Generator_Test_1._0
{
    partial class shop
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
            this.btn2X = new System.Windows.Forms.Button();
            this.btn3X = new System.Windows.Forms.Button();
            this.btn4X = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2X
            // 
            this.btn2X.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2X.Location = new System.Drawing.Point(39, 39);
            this.btn2X.Name = "btn2X";
            this.btn2X.Size = new System.Drawing.Size(84, 77);
            this.btn2X.TabIndex = 0;
            this.btn2X.Text = "2X";
            this.btn2X.UseVisualStyleBackColor = true;
            this.btn2X.Click += new System.EventHandler(this.btn2X_Click);
            // 
            // btn3X
            // 
            this.btn3X.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3X.Location = new System.Drawing.Point(154, 39);
            this.btn3X.Name = "btn3X";
            this.btn3X.Size = new System.Drawing.Size(84, 77);
            this.btn3X.TabIndex = 1;
            this.btn3X.Text = "3X";
            this.btn3X.UseVisualStyleBackColor = true;
            this.btn3X.Click += new System.EventHandler(this.btn3X_Click);
            // 
            // btn4X
            // 
            this.btn4X.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4X.Location = new System.Drawing.Point(269, 39);
            this.btn4X.Name = "btn4X";
            this.btn4X.Size = new System.Drawing.Size(84, 77);
            this.btn4X.TabIndex = 2;
            this.btn4X.Text = "4X";
            this.btn4X.UseVisualStyleBackColor = true;
            this.btn4X.Click += new System.EventHandler(this.btn4X_Click);
            // 
            // shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.btn4X);
            this.Controls.Add(this.btn3X);
            this.Controls.Add(this.btn2X);
            this.Name = "shop";
            this.Text = "shop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn2X;
        private System.Windows.Forms.Button btn3X;
        private System.Windows.Forms.Button btn4X;
    }
}