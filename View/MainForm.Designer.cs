namespace FreelandLabs
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.number_visitor = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tab_stats = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.number_resident = new System.Windows.Forms.Label();
			this.number_citizen = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.img_citizen = new System.Windows.Forms.PictureBox();
			this.img_resident = new System.Windows.Forms.PictureBox();
			this.img_visitor = new System.Windows.Forms.PictureBox();
			this.tab_course = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.listBox_volumes = new System.Windows.Forms.ListBox();
			this.btn_refreshCourse = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listBox_cryptoCourse = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listBox_fiatCourse = new System.Windows.Forms.ListBox();
			this.btn_minimize = new System.Windows.Forms.Button();
			this.btn_exit = new System.Windows.Forms.Button();
			this.panelTitle = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tab_stats.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.img_citizen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.img_resident)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.img_visitor)).BeginInit();
			this.tab_course.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// number_visitor
			// 
			this.number_visitor.Location = new System.Drawing.Point(212, 65);
			this.number_visitor.Name = "number_visitor";
			this.number_visitor.Size = new System.Drawing.Size(104, 23);
			this.number_visitor.TabIndex = 6;
			this.number_visitor.Text = "0";
			this.number_visitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tab_stats);
			this.tabControl1.Controls.Add(this.tab_course);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tabControl1.Location = new System.Drawing.Point(0, 38);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1004, 478);
			this.tabControl1.TabIndex = 8;
			// 
			// tab_stats
			// 
			this.tab_stats.Controls.Add(this.groupBox4);
			this.tab_stats.Location = new System.Drawing.Point(4, 30);
			this.tab_stats.Name = "tab_stats";
			this.tab_stats.Padding = new System.Windows.Forms.Padding(3);
			this.tab_stats.Size = new System.Drawing.Size(996, 444);
			this.tab_stats.TabIndex = 0;
			this.tab_stats.Text = "Статистика";
			this.tab_stats.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.number_visitor);
			this.groupBox4.Controls.Add(this.number_resident);
			this.groupBox4.Controls.Add(this.number_citizen);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.img_citizen);
			this.groupBox4.Controls.Add(this.img_resident);
			this.groupBox4.Controls.Add(this.img_visitor);
			this.groupBox4.Location = new System.Drawing.Point(17, 18);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(356, 276);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Сообщество";
			// 
			// number_resident
			// 
			this.number_resident.Location = new System.Drawing.Point(212, 138);
			this.number_resident.Name = "number_resident";
			this.number_resident.Size = new System.Drawing.Size(104, 23);
			this.number_resident.TabIndex = 8;
			this.number_resident.Text = "0";
			this.number_resident.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// number_citizen
			// 
			this.number_citizen.Location = new System.Drawing.Point(212, 213);
			this.number_citizen.Name = "number_citizen";
			this.number_citizen.Size = new System.Drawing.Size(104, 23);
			this.number_citizen.TabIndex = 7;
			this.number_citizen.Text = "0";
			this.number_citizen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(102, 213);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Граждан:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(102, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Резидентов:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(102, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Гостей:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// img_citizen
			// 
			this.img_citizen.Image = ((System.Drawing.Image)(resources.GetObject("img_citizen.Image")));
			this.img_citizen.Location = new System.Drawing.Point(24, 190);
			this.img_citizen.Name = "img_citizen";
			this.img_citizen.Size = new System.Drawing.Size(72, 72);
			this.img_citizen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.img_citizen.TabIndex = 3;
			this.img_citizen.TabStop = false;
			// 
			// img_resident
			// 
			this.img_resident.Image = ((System.Drawing.Image)(resources.GetObject("img_resident.Image")));
			this.img_resident.Location = new System.Drawing.Point(24, 112);
			this.img_resident.Name = "img_resident";
			this.img_resident.Size = new System.Drawing.Size(72, 72);
			this.img_resident.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.img_resident.TabIndex = 2;
			this.img_resident.TabStop = false;
			// 
			// img_visitor
			// 
			this.img_visitor.Image = ((System.Drawing.Image)(resources.GetObject("img_visitor.Image")));
			this.img_visitor.Location = new System.Drawing.Point(24, 34);
			this.img_visitor.Name = "img_visitor";
			this.img_visitor.Size = new System.Drawing.Size(72, 72);
			this.img_visitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.img_visitor.TabIndex = 4;
			this.img_visitor.TabStop = false;
			// 
			// tab_course
			// 
			this.tab_course.Controls.Add(this.groupBox3);
			this.tab_course.Controls.Add(this.btn_refreshCourse);
			this.tab_course.Controls.Add(this.groupBox2);
			this.tab_course.Controls.Add(this.groupBox1);
			this.tab_course.Location = new System.Drawing.Point(4, 30);
			this.tab_course.Name = "tab_course";
			this.tab_course.Padding = new System.Windows.Forms.Padding(3);
			this.tab_course.Size = new System.Drawing.Size(996, 444);
			this.tab_course.TabIndex = 1;
			this.tab_course.Text = "Курс и объемы";
			this.tab_course.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.listBox_volumes);
			this.groupBox3.Location = new System.Drawing.Point(614, 23);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(365, 343);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Объемы торгов";
			// 
			// listBox_volumes
			// 
			this.listBox_volumes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox_volumes.FormattingEnabled = true;
			this.listBox_volumes.ItemHeight = 21;
			this.listBox_volumes.Location = new System.Drawing.Point(20, 28);
			this.listBox_volumes.Name = "listBox_volumes";
			this.listBox_volumes.Size = new System.Drawing.Size(326, 273);
			this.listBox_volumes.TabIndex = 0;
			// 
			// btn_refreshCourse
			// 
			this.btn_refreshCourse.Location = new System.Drawing.Point(878, 372);
			this.btn_refreshCourse.Name = "btn_refreshCourse";
			this.btn_refreshCourse.Size = new System.Drawing.Size(101, 32);
			this.btn_refreshCourse.TabIndex = 3;
			this.btn_refreshCourse.Text = "Обновить";
			this.btn_refreshCourse.UseVisualStyleBackColor = true;
			this.btn_refreshCourse.Click += new System.EventHandler(this.Btn_refreshCourseClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listBox_cryptoCourse);
			this.groupBox2.Location = new System.Drawing.Point(320, 23);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(288, 343);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Курс к криптовалютам";
			// 
			// listBox_cryptoCourse
			// 
			this.listBox_cryptoCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox_cryptoCourse.FormattingEnabled = true;
			this.listBox_cryptoCourse.ItemHeight = 21;
			this.listBox_cryptoCourse.Location = new System.Drawing.Point(18, 28);
			this.listBox_cryptoCourse.Name = "listBox_cryptoCourse";
			this.listBox_cryptoCourse.Size = new System.Drawing.Size(251, 273);
			this.listBox_cryptoCourse.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listBox_fiatCourse);
			this.groupBox1.Location = new System.Drawing.Point(22, 23);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(292, 343);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Курс к фиатным валютам";
			// 
			// listBox_fiatCourse
			// 
			this.listBox_fiatCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox_fiatCourse.FormattingEnabled = true;
			this.listBox_fiatCourse.ItemHeight = 21;
			this.listBox_fiatCourse.Location = new System.Drawing.Point(18, 28);
			this.listBox_fiatCourse.Name = "listBox_fiatCourse";
			this.listBox_fiatCourse.Size = new System.Drawing.Size(256, 273);
			this.listBox_fiatCourse.TabIndex = 1;
			// 
			// btn_minimize
			// 
			this.btn_minimize.FlatAppearance.BorderSize = 0;
			this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_minimize.ForeColor = System.Drawing.Color.LightSkyBlue;
			this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
			this.btn_minimize.Location = new System.Drawing.Point(910, 12);
			this.btn_minimize.Name = "btn_minimize";
			this.btn_minimize.Size = new System.Drawing.Size(38, 38);
			this.btn_minimize.TabIndex = 9;
			this.btn_minimize.UseVisualStyleBackColor = true;
			this.btn_minimize.Click += new System.EventHandler(this.Btn_minimizeClick);
			// 
			// btn_exit
			// 
			this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_exit.ForeColor = System.Drawing.Color.LightSkyBlue;
			this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
			this.btn_exit.Location = new System.Drawing.Point(954, 12);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(38, 38);
			this.btn_exit.TabIndex = 10;
			this.btn_exit.UseVisualStyleBackColor = true;
			this.btn_exit.Click += new System.EventHandler(this.Btn_exitClick);
			// 
			// panelTitle
			// 
			this.panelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.panelTitle.ForeColor = System.Drawing.Color.White;
			this.panelTitle.Location = new System.Drawing.Point(12, 9);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(452, 23);
			this.panelTitle.TabIndex = 11;
			this.panelTitle.Text = "Freeland Labs";
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(1004, 516);
			this.Controls.Add(this.btn_minimize);
			this.Controls.Add(this.btn_exit);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panelTitle);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Shown += new System.EventHandler(this.MainFormShown);
			this.tabControl1.ResumeLayout(false);
			this.tab_stats.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.img_citizen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.img_resident)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.img_visitor)).EndInit();
			this.tab_course.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ListBox listBox_volumes;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btn_refreshCourse;
		private System.Windows.Forms.ListBox listBox_fiatCourse;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox listBox_cryptoCourse;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label number_resident;
		private System.Windows.Forms.Label number_visitor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label number_citizen;
		private System.Windows.Forms.PictureBox img_visitor;
		private System.Windows.Forms.PictureBox img_resident;
		private System.Windows.Forms.PictureBox img_citizen;
		private System.Windows.Forms.Label panelTitle;
		private System.Windows.Forms.Button btn_minimize;
		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.TabPage tab_course;
		private System.Windows.Forms.TabPage tab_stats;
		private System.Windows.Forms.TabControl tabControl1;
	}
}
