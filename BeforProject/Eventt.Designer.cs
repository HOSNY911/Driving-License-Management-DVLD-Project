namespace BeforProject
{
    partial class Eventt
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
            this.ctrlSimpleCalcolator1 = new BeforProject.CtrlSimpleCalcolator();
            this.SuspendLayout();
            // 
            // ctrlSimpleCalcolator1
            // 
            this.ctrlSimpleCalcolator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSimpleCalcolator1.Location = new System.Drawing.Point(74, 103);
            this.ctrlSimpleCalcolator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSimpleCalcolator1.Name = "ctrlSimpleCalcolator1";
            this.ctrlSimpleCalcolator1.Size = new System.Drawing.Size(578, 87);
            this.ctrlSimpleCalcolator1.TabIndex = 0;
            this.ctrlSimpleCalcolator1.OnCalcolateCompleat += new System.Action<int>(this.ctrlSimpleCalcolator1_OnCalcolateCompleat);
            // 
            // Eventt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlSimpleCalcolator1);
            this.Name = "Eventt";
            this.Text = "Eventt";
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlSimpleCalcolator ctrlSimpleCalcolator1;
    }
}