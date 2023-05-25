using CometUI;
using MarioToadHouseCharts.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MarioToadHouseCharts
{
	public partial class Main : CometForm
	{
		public Main()
		{
			InitializeComponent();
		}

		private Dictionary<int, Bitmap> dict_ToadHouseCharts = new Dictionary<int, Bitmap>
		{
			{ 1, Resources.world_1 },
			{ 2, Resources.world_2 },
			{ 3, Resources.world_3 },
			{ 4, Resources.world_4 },
			{ 5, Resources.world_5 },
			{ 6, Resources.world_6 },
			{ 7, Resources.world_7 },
			{ 8, Resources.world_8 },
			{ 9, Resources.world_9 }
		};

		private void ToadHouseSelector_ValueChanged(object sender, EventArgs e)
		{
			pic_ToadHouseChart.Image = dict_ToadHouseCharts[sld_WorldSelector.Value];
			lbl_SelectedWorld.Text = $"World: {sld_WorldSelector.Value}";
		}
	}
}
