namespace BeforProject
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
            this.ctrlSimpleCalcolator3 = new BeforProject.CtrlSimpleCalcolator();
            this.ctrlSimpleCalcolator2 = new BeforProject.CtrlSimpleCalcolator();
            this.ctrlSimpleCalcolator1 = new BeforProject.CtrlSimpleCalcolator();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlSimpleCalcolator3
            // 
            this.ctrlSimpleCalcolator3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSimpleCalcolator3.Location = new System.Drawing.Point(4, 227);
            this.ctrlSimpleCalcolator3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSimpleCalcolator3.Name = "ctrlSimpleCalcolator3";
            this.ctrlSimpleCalcolator3.Size = new System.Drawing.Size(578, 87);
            this.ctrlSimpleCalcolator3.TabIndex = 2;
            // 
            // ctrlSimpleCalcolator2
            // 
            this.ctrlSimpleCalcolator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSimpleCalcolator2.Location = new System.Drawing.Point(4, 119);
            this.ctrlSimpleCalcolator2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSimpleCalcolator2.Name = "ctrlSimpleCalcolator2";
            this.ctrlSimpleCalcolator2.Size = new System.Drawing.Size(578, 87);
            this.ctrlSimpleCalcolator2.TabIndex = 1;
            // 
            // ctrlSimpleCalcolator1
            // 
            this.ctrlSimpleCalcolator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSimpleCalcolator1.Location = new System.Drawing.Point(4, 4);
            this.ctrlSimpleCalcolator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSimpleCalcolator1.Name = "ctrlSimpleCalcolator1";
            this.ctrlSimpleCalcolator1.Size = new System.Drawing.Size(578, 87);
            this.ctrlSimpleCalcolator1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show Calack Form 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlSimpleCalcolator3);
            this.Controls.Add(this.ctrlSimpleCalcolator2);
            this.Controls.Add(this.ctrlSimpleCalcolator1);
            this.Name = "Form1";
            this.Text = "User Control";
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlSimpleCalcolator ctrlSimpleCalcolator1;
        private CtrlSimpleCalcolator ctrlSimpleCalcolator2;
        private CtrlSimpleCalcolator ctrlSimpleCalcolator3;
        private System.Windows.Forms.Button button1;
    }
}

