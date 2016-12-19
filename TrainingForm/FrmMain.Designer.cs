namespace TrainingForm
{
	partial class FrmMain
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
			this.pnlMenu = new System.Windows.Forms.FlowLayoutPanel();
			this.lstInvoice = new System.Windows.Forms.ListView();
			this.cmdClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// pnlMenu
			// 
			this.pnlMenu.Location = new System.Drawing.Point(305, 40);
			this.pnlMenu.Name = "pnlMenu";
			this.pnlMenu.Size = new System.Drawing.Size(498, 583);
			this.pnlMenu.TabIndex = 1;
			// 
			// lstInvoice
			// 
			this.lstInvoice.Location = new System.Drawing.Point(12, 49);
			this.lstInvoice.Name = "lstInvoice";
			this.lstInvoice.Size = new System.Drawing.Size(262, 499);
			this.lstInvoice.TabIndex = 2;
			this.lstInvoice.UseCompatibleStateImageBehavior = false;
			this.lstInvoice.View = System.Windows.Forms.View.List;
			// 
			// cmdClear
			// 
			this.cmdClear.Location = new System.Drawing.Point(13, 568);
			this.cmdClear.Name = "cmdClear";
			this.cmdClear.Size = new System.Drawing.Size(75, 23);
			this.cmdClear.TabIndex = 3;
			this.cmdClear.Text = "Clear";
			this.cmdClear.UseVisualStyleBackColor = true;
			this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(857, 651);
			this.Controls.Add(this.cmdClear);
			this.Controls.Add(this.lstInvoice);
			this.Controls.Add(this.pnlMenu);
			this.Name = "FrmMain";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel pnlMenu;
		private System.Windows.Forms.ListView lstInvoice;
		private System.Windows.Forms.Button cmdClear;
	}
}

