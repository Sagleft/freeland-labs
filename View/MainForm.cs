using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FreelandLabs.Controller;

namespace FreelandLabs
{
	public partial class MainForm : Form
	{
		int x, y;
    	bool s = false;
    	Loader loader;
    	
		public MainForm()
		{
			this.InitializeComponent();
			this.panelTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
	        this.panelTitle.MouseMove  += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
	        this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
	        this.MouseMove  += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
	        this.panelTitle.Text = "Freeland Labs v." + Application.ProductVersion;
		}
		
		private void MoveForm(object sender, MouseEventArgs e) {
    		//перетаскивание формы
	        if (s == false) { x = e.X; y = e.Y; s = true; }
	        if (e.Button.ToString() == "Left")
	        { this.Location = new Point(this.Left + e.X - x, this.Top + e.Y - y); }
	        else { s = false; }
	    }
		
		void Btn_minimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		
		void Btn_exitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void updateCourseStats() {
			//неужели у списка нет метода слияния?
			List<string> course_local  = loader.LocalCourseList();
			List<string> course_crypto = loader.LocalCryptoList();
			List<string> volumes_list  = loader.LoadExchangeVolumes();
			
			listBox_fiatCourse.Items.Clear();
			listBox_cryptoCourse.Items.Clear();
			listBox_volumes.Items.Clear();
			
			for(int i=0; i<course_local.Count; i++) {
				listBox_fiatCourse.Items.Add(course_local[i]);
			}
			for(int i=0; i<course_crypto.Count; i++) {
				listBox_cryptoCourse.Items.Add(course_crypto[i]);
			}
			for(int i=0; i<volumes_list.Count; i++) {
				listBox_volumes.Items.Add(volumes_list[i]);
			}
		}
		
		void MainFormShown(object sender, EventArgs e)
		{
			loader = new Loader();
			number_visitor.Text  = loader.getVisitorCount().ToString();
			number_resident.Text = loader.getResidentCount().ToString();
			number_citizen.Text  = loader.getCitizenCount().ToString();
			
			updateCourseStats();
		}
		
		void Btn_refreshCourseClick(object sender, EventArgs e)
		{
			updateCourseStats();
		}
	}
}
