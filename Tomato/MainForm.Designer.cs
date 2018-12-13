/*
 * Created by SharpDevelop.
 * User: Bullshit
 * Date: 5/6/2018
 * Time: 6:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tomato
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox arduinoPortCB;
		private System.Windows.Forms.Button connectCOM;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button openCamera;
		private System.Windows.Forms.Label label2;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.CheckBox autoCheckBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cameraListBox;
		
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cameraListBox = new System.Windows.Forms.ComboBox();
			this.autoCheckBox1 = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.arduinoPortCB = new System.Windows.Forms.ComboBox();
			this.connectCOM = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.openCamera = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(117, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(557, 74);
			this.label1.TabIndex = 0;
			this.label1.Text = "Giao diện điều khiển phân loại sản phẩm";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 86);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(662, 518);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Camera";
			this.groupBox1.Enter += new System.EventHandler(this.GroupBox1Enter);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(7, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(640, 480);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cameraListBox);
			this.groupBox2.Controls.Add(this.autoCheckBox1);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.button7);
			this.groupBox2.Controls.Add(this.button6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.arduinoPortCB);
			this.groupBox2.Controls.Add(this.connectCOM);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.openCamera);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(685, 86);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(412, 518);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Control";
			// 
			// cameraListBox
			// 
			this.cameraListBox.FormattingEnabled = true;
			this.cameraListBox.Location = new System.Drawing.Point(8, 58);
			this.cameraListBox.Name = "cameraListBox";
			this.cameraListBox.Size = new System.Drawing.Size(397, 32);
			this.cameraListBox.TabIndex = 23;
			// 
			// autoCheckBox1
			// 
			this.autoCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.autoCheckBox1.Location = new System.Drawing.Point(5, 465);
			this.autoCheckBox1.Name = "autoCheckBox1";
			this.autoCheckBox1.Size = new System.Drawing.Size(338, 24);
			this.autoCheckBox1.TabIndex = 22;
			this.autoCheckBox1.Text = "Tự động";
			this.autoCheckBox1.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(6, 439);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(311, 23);
			this.label6.TabIndex = 20;
			this.label6.Text = "Hệ thống";
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(6, 384);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(146, 23);
			this.button7.TabIndex = 16;
			this.button7.Text = "Vị trí 3";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(159, 355);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(146, 23);
			this.button6.TabIndex = 15;
			this.button6.Text = "Vị trí 2";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(5, 228);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(311, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Điều khiển băng tải";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 291);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(311, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "Điều khiển cánh tay";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(6, 355);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(146, 23);
			this.button3.TabIndex = 10;
			this.button3.Text = "Vị trí 1";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(159, 254);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(144, 23);
			this.button2.TabIndex = 9;
			this.button2.Text = "Dừng băng tải";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(5, 254);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(148, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Chạy băng tải";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// arduinoPortCB
			// 
			this.arduinoPortCB.FormattingEnabled = true;
			this.arduinoPortCB.Location = new System.Drawing.Point(7, 156);
			this.arduinoPortCB.Name = "arduinoPortCB";
			this.arduinoPortCB.Size = new System.Drawing.Size(398, 32);
			this.arduinoPortCB.TabIndex = 7;
			// 
			// connectCOM
			// 
			this.connectCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.connectCOM.Location = new System.Drawing.Point(5, 194);
			this.connectCOM.Name = "connectCOM";
			this.connectCOM.Size = new System.Drawing.Size(148, 23);
			this.connectCOM.TabIndex = 6;
			this.connectCOM.Text = "Kết nối";
			this.connectCOM.UseVisualStyleBackColor = true;
			this.connectCOM.Click += new System.EventHandler(this.ConnectCOMClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 129);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(311, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Cổng COM Arduino:";
			// 
			// openCamera
			// 
			this.openCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.openCamera.Location = new System.Drawing.Point(6, 97);
			this.openCamera.Name = "openCamera";
			this.openCamera.Size = new System.Drawing.Size(148, 23);
			this.openCamera.TabIndex = 3;
			this.openCamera.Text = "Mở camera";
			this.openCamera.UseVisualStyleBackColor = true;
			this.openCamera.Click += new System.EventHandler(this.OpenCameraClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(5, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(311, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Địa chỉ camera:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1113, 631);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.Name = "MainForm";
			this.Text = "ArmController";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
