namespace MarioToadHouseCharts
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.sld_WorldSelector = new CometUI.CometSlider();
			this.lbl_SelectedWorld = new CometUI.CometLabel();
			this.pic_ToadHouseChart = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_ToadHouseChart)).BeginInit();
			this.SuspendLayout();
			// 
			// sld_WorldSelector
			// 
			this.sld_WorldSelector.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sld_WorldSelector.DefaultValue = 50;
			this.sld_WorldSelector.DragColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.sld_WorldSelector.KnobColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.sld_WorldSelector.Location = new System.Drawing.Point(12, 65);
			this.sld_WorldSelector.Maximum = 9;
			this.sld_WorldSelector.Minimum = 1;
			this.sld_WorldSelector.Name = "sld_WorldSelector";
			this.sld_WorldSelector.ShowSliderValue = false;
			this.sld_WorldSelector.Size = new System.Drawing.Size(351, 16);
			this.sld_WorldSelector.TabIndex = 0;
			this.sld_WorldSelector.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.sld_WorldSelector.TrackOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.sld_WorldSelector.Value = 1;
			this.sld_WorldSelector.ValueTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.sld_WorldSelector.ValueChanged += new System.EventHandler(this.ToadHouseSelector_ValueChanged);
			// 
			// lbl_SelectedWorld
			// 
			this.lbl_SelectedWorld.AutoSize = true;
			this.lbl_SelectedWorld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lbl_SelectedWorld.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lbl_SelectedWorld.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.lbl_SelectedWorld.Location = new System.Drawing.Point(12, 43);
			this.lbl_SelectedWorld.Name = "lbl_SelectedWorld";
			this.lbl_SelectedWorld.Size = new System.Drawing.Size(60, 19);
			this.lbl_SelectedWorld.TabIndex = 1;
			this.lbl_SelectedWorld.Text = "World: 1";
			// 
			// pic_ToadHouseChart
			// 
			this.pic_ToadHouseChart.Location = new System.Drawing.Point(12, 87);
			this.pic_ToadHouseChart.Name = "pic_ToadHouseChart";
			this.pic_ToadHouseChart.Size = new System.Drawing.Size(351, 327);
			this.pic_ToadHouseChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_ToadHouseChart.TabIndex = 2;
			this.pic_ToadHouseChart.TabStop = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CanResize = false;
			this.ClientSize = new System.Drawing.Size(375, 426);
			this.Controls.Add(this.pic_ToadHouseChart);
			this.Controls.Add(this.lbl_SelectedWorld);
			this.Controls.Add(this.sld_WorldSelector);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(233, 131);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mario Toad Houses";
			((System.ComponentModel.ISupportInitialize)(this.pic_ToadHouseChart)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CometUI.CometSlider sld_WorldSelector;
		private CometUI.CometLabel lbl_SelectedWorld;
		private System.Windows.Forms.PictureBox pic_ToadHouseChart;
	}
}

