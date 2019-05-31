namespace HWMS
{
    partial class TrashcustomerO
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
            this.customerOrderP = new System.Windows.Forms.Panel();
            this.supplierOrderP = new System.Windows.Forms.Panel();
            this.customerOrderP.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerOrderP
            // 
            this.customerOrderP.Controls.Add(this.supplierOrderP);
            this.customerOrderP.Location = new System.Drawing.Point(132, 74);
            this.customerOrderP.Name = "customerOrderP";
            this.customerOrderP.Size = new System.Drawing.Size(587, 352);
            this.customerOrderP.TabIndex = 1;
            // 
            // supplierOrderP
            // 
            this.supplierOrderP.Location = new System.Drawing.Point(382, 198);
            this.supplierOrderP.Name = "supplierOrderP";
            this.supplierOrderP.Size = new System.Drawing.Size(200, 100);
            this.supplierOrderP.TabIndex = 0;
            // 
            // TrashcustomerO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 753);
            this.Controls.Add(this.customerOrderP);
            this.Name = "TrashcustomerO";
            this.Text = "TrashcustomerO";
            this.customerOrderP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel customerOrderP;
        private System.Windows.Forms.Panel supplierOrderP;
    }
}