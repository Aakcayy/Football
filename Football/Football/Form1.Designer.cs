namespace Football
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnKaleci = new System.Windows.Forms.Button();
            this.btnSolBek = new System.Windows.Forms.Button();
            this.btnSolStoper = new System.Windows.Forms.Button();
            this.btnSagStoper = new System.Windows.Forms.Button();
            this.btnSagBek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKaleci
            // 
            this.btnKaleci.Location = new System.Drawing.Point(79, 611);
            this.btnKaleci.Name = "btnKaleci";
            this.btnKaleci.Size = new System.Drawing.Size(93, 49);
            this.btnKaleci.TabIndex = 0;
            this.btnKaleci.Text = "Fabri";
            this.btnKaleci.UseVisualStyleBackColor = true;
            this.btnKaleci.Click += new System.EventHandler(this.btnKaleci_Click);
            // 
            // btnSolBek
            // 
            this.btnSolBek.Location = new System.Drawing.Point(234, 191);
            this.btnSolBek.Name = "btnSolBek";
            this.btnSolBek.Size = new System.Drawing.Size(95, 42);
            this.btnSolBek.TabIndex = 1;
            this.btnSolBek.Text = "Adriano";
            this.btnSolBek.UseVisualStyleBackColor = true;
            // 
            // btnSolStoper
            // 
            this.btnSolStoper.Location = new System.Drawing.Point(234, 456);
            this.btnSolStoper.Name = "btnSolStoper";
            this.btnSolStoper.Size = new System.Drawing.Size(95, 42);
            this.btnSolStoper.TabIndex = 2;
            this.btnSolStoper.Text = "Marcelo";
            this.btnSolStoper.UseVisualStyleBackColor = true;
            // 
            // btnSagStoper
            // 
            this.btnSagStoper.Location = new System.Drawing.Point(234, 652);
            this.btnSagStoper.Name = "btnSagStoper";
            this.btnSagStoper.Size = new System.Drawing.Size(95, 42);
            this.btnSagStoper.TabIndex = 3;
            this.btnSagStoper.Text = "Pepe";
            this.btnSagStoper.UseVisualStyleBackColor = true;
            // 
            // btnSagBek
            // 
            this.btnSagBek.Location = new System.Drawing.Point(234, 898);
            this.btnSagBek.Name = "btnSagBek";
            this.btnSagBek.Size = new System.Drawing.Size(95, 42);
            this.btnSagBek.TabIndex = 4;
            this.btnSagBek.Text = "Beck";
            this.btnSagBek.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1599, 1055);
            this.Controls.Add(this.btnSagBek);
            this.Controls.Add(this.btnSagStoper);
            this.Controls.Add(this.btnSolStoper);
            this.Controls.Add(this.btnSolBek);
            this.Controls.Add(this.btnKaleci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKaleci;
        private System.Windows.Forms.Button btnSolBek;
        private System.Windows.Forms.Button btnSolStoper;
        private System.Windows.Forms.Button btnSagStoper;
        private System.Windows.Forms.Button btnSagBek;
    }
}

