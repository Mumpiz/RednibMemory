/*
 * Created by SharpDevelop.
 * User: Micha
 * Date: 20.09.2017
 * Time: 13:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RednibMemoryReader
{
	partial class Main
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button_OpenProcess;
		private System.Windows.Forms.GroupBox groupBox_Memory;
		private System.Windows.Forms.TextBox textBox_CurrentProcess;
		private System.Windows.Forms.RichTextBox richTextBox_Console;
		private System.Windows.Forms.ComboBox comboBox_Process;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button_WriteMemory;
		private System.Windows.Forms.TextBox textBox_DecimalValue;
		private System.Windows.Forms.Button button_ReadMemory;
		private System.Windows.Forms.TextBox textBox_Offset6;
		private System.Windows.Forms.TextBox textBox_Offset5;
		private System.Windows.Forms.TextBox textBox_Offset4;
		private System.Windows.Forms.TextBox textBox_Offset3;
		private System.Windows.Forms.TextBox textBox_Offset2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_Offset1;
		private System.Windows.Forms.TextBox textBox_Address;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox_DataType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBox_Offset3Negative;
		private System.Windows.Forms.CheckBox checkBox_Offset6Negative;
		private System.Windows.Forms.CheckBox checkBox_Offset5Negative;
		private System.Windows.Forms.CheckBox checkBox_Offset4Negative;
		private System.Windows.Forms.CheckBox checkBox_Offset2Negative;
		private System.Windows.Forms.CheckBox checkBox_Offset1Negative;
		private System.Windows.Forms.Label label5;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.button_OpenProcess = new System.Windows.Forms.Button();
			this.groupBox_Memory = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox_DataType = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.checkBox_Offset3Negative = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button_WriteMemory = new System.Windows.Forms.Button();
			this.checkBox_Offset6Negative = new System.Windows.Forms.CheckBox();
			this.textBox_DecimalValue = new System.Windows.Forms.TextBox();
			this.button_ReadMemory = new System.Windows.Forms.Button();
			this.checkBox_Offset5Negative = new System.Windows.Forms.CheckBox();
			this.textBox_Address = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox_Offset4Negative = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_Offset6 = new System.Windows.Forms.TextBox();
			this.checkBox_Offset2Negative = new System.Windows.Forms.CheckBox();
			this.textBox_Offset5 = new System.Windows.Forms.TextBox();
			this.textBox_Offset4 = new System.Windows.Forms.TextBox();
			this.checkBox_Offset1Negative = new System.Windows.Forms.CheckBox();
			this.textBox_Offset3 = new System.Windows.Forms.TextBox();
			this.textBox_Offset1 = new System.Windows.Forms.TextBox();
			this.textBox_Offset2 = new System.Windows.Forms.TextBox();
			this.richTextBox_Console = new System.Windows.Forms.RichTextBox();
			this.textBox_CurrentProcess = new System.Windows.Forms.TextBox();
			this.comboBox_Process = new System.Windows.Forms.ComboBox();
			this.groupBox_Memory.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_OpenProcess
			// 
			this.button_OpenProcess.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button_OpenProcess.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_OpenProcess.Location = new System.Drawing.Point(172, 10);
			this.button_OpenProcess.Name = "button_OpenProcess";
			this.button_OpenProcess.Size = new System.Drawing.Size(87, 23);
			this.button_OpenProcess.TabIndex = 2;
			this.button_OpenProcess.Text = "Open/Refresh";
			this.button_OpenProcess.UseVisualStyleBackColor = false;
			this.button_OpenProcess.Click += new System.EventHandler(this.Button_OpenProcess_Click);
			// 
			// groupBox_Memory
			// 
			this.groupBox_Memory.BackColor = System.Drawing.Color.Transparent;
			this.groupBox_Memory.Controls.Add(this.label5);
			this.groupBox_Memory.Controls.Add(this.comboBox_DataType);
			this.groupBox_Memory.Controls.Add(this.label4);
			this.groupBox_Memory.Controls.Add(this.checkBox_Offset3Negative);
			this.groupBox_Memory.Controls.Add(this.label3);
			this.groupBox_Memory.Controls.Add(this.button_WriteMemory);
			this.groupBox_Memory.Controls.Add(this.checkBox_Offset6Negative);
			this.groupBox_Memory.Controls.Add(this.textBox_DecimalValue);
			this.groupBox_Memory.Controls.Add(this.button_ReadMemory);
			this.groupBox_Memory.Controls.Add(this.checkBox_Offset5Negative);
			this.groupBox_Memory.Controls.Add(this.textBox_Address);
			this.groupBox_Memory.Controls.Add(this.label1);
			this.groupBox_Memory.Controls.Add(this.checkBox_Offset4Negative);
			this.groupBox_Memory.Controls.Add(this.label2);
			this.groupBox_Memory.Controls.Add(this.textBox_Offset6);
			this.groupBox_Memory.Controls.Add(this.checkBox_Offset2Negative);
			this.groupBox_Memory.Controls.Add(this.textBox_Offset5);
			this.groupBox_Memory.Controls.Add(this.textBox_Offset4);
			this.groupBox_Memory.Controls.Add(this.checkBox_Offset1Negative);
			this.groupBox_Memory.Controls.Add(this.textBox_Offset3);
			this.groupBox_Memory.Controls.Add(this.textBox_Offset1);
			this.groupBox_Memory.Controls.Add(this.textBox_Offset2);
			this.groupBox_Memory.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_Memory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.groupBox_Memory.Location = new System.Drawing.Point(311, 36);
			this.groupBox_Memory.Name = "groupBox_Memory";
			this.groupBox_Memory.Size = new System.Drawing.Size(264, 311);
			this.groupBox_Memory.TabIndex = 4;
			this.groupBox_Memory.TabStop = false;
			this.groupBox_Memory.Text = "Memory";
			this.groupBox_Memory.Enter += new System.EventHandler(this.GroupBox_MemoryEnter);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(86, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 16);
			this.label5.TabIndex = 19;
			this.label5.Text = "Negative";
			// 
			// comboBox_DataType
			// 
			this.comboBox_DataType.BackColor = System.Drawing.Color.Black;
			this.comboBox_DataType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBox_DataType.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_DataType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.comboBox_DataType.FormattingEnabled = true;
			this.comboBox_DataType.Location = new System.Drawing.Point(170, 63);
			this.comboBox_DataType.Name = "comboBox_DataType";
			this.comboBox_DataType.Size = new System.Drawing.Size(77, 22);
			this.comboBox_DataType.TabIndex = 16;
			this.comboBox_DataType.Text = "4 Byte";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(170, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 15);
			this.label4.TabIndex = 15;
			this.label4.Text = "Data Type";
			// 
			// checkBox_Offset3Negative
			// 
			this.checkBox_Offset3Negative.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_Offset3Negative.Location = new System.Drawing.Point(103, 195);
			this.checkBox_Offset3Negative.Name = "checkBox_Offset3Negative";
			this.checkBox_Offset3Negative.Size = new System.Drawing.Size(16, 24);
			this.checkBox_Offset3Negative.TabIndex = 18;
			this.checkBox_Offset3Negative.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 14);
			this.label3.TabIndex = 14;
			this.label3.Text = "Dec. Value";
			// 
			// button_WriteMemory
			// 
			this.button_WriteMemory.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_WriteMemory.ForeColor = System.Drawing.Color.Black;
			this.button_WriteMemory.Location = new System.Drawing.Point(92, 83);
			this.button_WriteMemory.Name = "button_WriteMemory";
			this.button_WriteMemory.Size = new System.Drawing.Size(62, 23);
			this.button_WriteMemory.TabIndex = 13;
			this.button_WriteMemory.Text = "Write";
			this.button_WriteMemory.UseVisualStyleBackColor = true;
			this.button_WriteMemory.Click += new System.EventHandler(this.Button_WriteMemory_Click);
			// 
			// checkBox_Offset6Negative
			// 
			this.checkBox_Offset6Negative.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_Offset6Negative.Location = new System.Drawing.Point(103, 274);
			this.checkBox_Offset6Negative.Name = "checkBox_Offset6Negative";
			this.checkBox_Offset6Negative.Size = new System.Drawing.Size(16, 24);
			this.checkBox_Offset6Negative.TabIndex = 18;
			this.checkBox_Offset6Negative.UseVisualStyleBackColor = true;
			// 
			// textBox_DecimalValue
			// 
			this.textBox_DecimalValue.BackColor = System.Drawing.Color.Black;
			this.textBox_DecimalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_DecimalValue.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_DecimalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.textBox_DecimalValue.Location = new System.Drawing.Point(9, 84);
			this.textBox_DecimalValue.Name = "textBox_DecimalValue";
			this.textBox_DecimalValue.Size = new System.Drawing.Size(77, 22);
			this.textBox_DecimalValue.TabIndex = 12;
			this.textBox_DecimalValue.TextChanged += new System.EventHandler(this.TextBox_DecimalValueTextChanged);
			// 
			// button_ReadMemory
			// 
			this.button_ReadMemory.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_ReadMemory.ForeColor = System.Drawing.Color.Black;
			this.button_ReadMemory.Location = new System.Drawing.Point(92, 39);
			this.button_ReadMemory.Name = "button_ReadMemory";
			this.button_ReadMemory.Size = new System.Drawing.Size(62, 23);
			this.button_ReadMemory.TabIndex = 11;
			this.button_ReadMemory.Text = "Read";
			this.button_ReadMemory.UseVisualStyleBackColor = true;
			this.button_ReadMemory.Click += new System.EventHandler(this.Button_ReadMemory_Click);
			// 
			// checkBox_Offset5Negative
			// 
			this.checkBox_Offset5Negative.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_Offset5Negative.Location = new System.Drawing.Point(103, 248);
			this.checkBox_Offset5Negative.Name = "checkBox_Offset5Negative";
			this.checkBox_Offset5Negative.Size = new System.Drawing.Size(16, 24);
			this.checkBox_Offset5Negative.TabIndex = 18;
			this.checkBox_Offset5Negative.UseVisualStyleBackColor = true;
			// 
			// textBox_Address
			// 
			this.textBox_Address.BackColor = System.Drawing.Color.Black;
			this.textBox_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_Address.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.textBox_Address.Location = new System.Drawing.Point(9, 40);
			this.textBox_Address.Name = "textBox_Address";
			this.textBox_Address.Size = new System.Drawing.Size(77, 22);
			this.textBox_Address.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Address";
			// 
			// checkBox_Offset4Negative
			// 
			this.checkBox_Offset4Negative.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_Offset4Negative.Location = new System.Drawing.Point(103, 221);
			this.checkBox_Offset4Negative.Name = "checkBox_Offset4Negative";
			this.checkBox_Offset4Negative.Size = new System.Drawing.Size(16, 24);
			this.checkBox_Offset4Negative.TabIndex = 18;
			this.checkBox_Offset4Negative.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Offsets";
			// 
			// textBox_Offset6
			// 
			this.textBox_Offset6.BackColor = System.Drawing.Color.Black;
			this.textBox_Offset6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_Offset6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Offset6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.textBox_Offset6.Location = new System.Drawing.Point(9, 274);
			this.textBox_Offset6.Name = "textBox_Offset6";
			this.textBox_Offset6.Size = new System.Drawing.Size(77, 22);
			this.textBox_Offset6.TabIndex = 10;
			this.textBox_Offset6.Text = "0";
			// 
			// checkBox_Offset2Negative
			// 
			this.checkBox_Offset2Negative.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_Offset2Negative.Location = new System.Drawing.Point(103, 170);
			this.checkBox_Offset2Negative.Name = "checkBox_Offset2Negative";
			this.checkBox_Offset2Negative.Size = new System.Drawing.Size(16, 24);
			this.checkBox_Offset2Negative.TabIndex = 18;
			this.checkBox_Offset2Negative.UseVisualStyleBackColor = true;
			// 
			// textBox_Offset5
			// 
			this.textBox_Offset5.BackColor = System.Drawing.Color.Black;
			this.textBox_Offset5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_Offset5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Offset5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.textBox_Offset5.Location = new System.Drawing.Point(9, 248);
			this.textBox_Offset5.Name = "textBox_Offset5";
			this.textBox_Offset5.Size = new System.Drawing.Size(77, 22);
			this.textBox_Offset5.TabIndex = 9;
			this.textBox_Offset5.Text = "0";
			// 
			// textBox_Offset4
			// 
			this.textBox_Offset4.BackColor = System.Drawing.Color.Black;
			this.textBox_Offset4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_Offset4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Offset4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.textBox_Offset4.Location = new System.Drawing.Point(9, 222);
			this.textBox_Offset4.Name = "textBox_Offset4";
			this.textBox_Offset4.Size = new System.Drawing.Size(77, 22);
			this.textBox_Offset4.TabIndex = 8;
			this.textBox_Offset4.Text = "0";
			// 
			// checkBox_Offset1Negative
			// 
			this.checkBox_Offset1Negative.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_Offset1Negative.Location = new System.Drawing.Point(103, 144);
			this.checkBox_Offset1Negative.Name = "checkBox_Offset1Negative";
			this.checkBox_Offset1Negative.Size = new System.Drawing.Size(16, 24);
			this.checkBox_Offset1Negative.TabIndex = 17;
			this.checkBox_Offset1Negative.UseVisualStyleBackColor = true;
			// 
			// textBox_Offset3
			// 
			this.textBox_Offset3.BackColor = System.Drawing.Color.Black;
			this.textBox_Offset3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_Offset3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Offset3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.textBox_Offset3.Location = new System.Drawing.Point(9, 196);
			this.textBox_Offset3.Name = "textBox_Offset3";
			this.textBox_Offset3.Size = new System.Drawing.Size(77, 22);
			this.textBox_Offset3.TabIndex = 7;
			this.textBox_Offset3.Text = "0";
			// 
			// textBox_Offset1
			// 
			this.textBox_Offset1.BackColor = System.Drawing.Color.Black;
			this.textBox_Offset1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_Offset1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Offset1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.textBox_Offset1.Location = new System.Drawing.Point(9, 144);
			this.textBox_Offset1.Name = "textBox_Offset1";
			this.textBox_Offset1.Size = new System.Drawing.Size(77, 22);
			this.textBox_Offset1.TabIndex = 2;
			this.textBox_Offset1.Text = "0";
			// 
			// textBox_Offset2
			// 
			this.textBox_Offset2.BackColor = System.Drawing.Color.Black;
			this.textBox_Offset2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_Offset2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Offset2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.textBox_Offset2.Location = new System.Drawing.Point(9, 170);
			this.textBox_Offset2.Name = "textBox_Offset2";
			this.textBox_Offset2.Size = new System.Drawing.Size(77, 22);
			this.textBox_Offset2.TabIndex = 6;
			this.textBox_Offset2.Text = "0";
			// 
			// richTextBox_Console
			// 
			this.richTextBox_Console.BackColor = System.Drawing.Color.Black;
			this.richTextBox_Console.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox_Console.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox_Console.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.richTextBox_Console.Location = new System.Drawing.Point(10, 39);
			this.richTextBox_Console.Name = "richTextBox_Console";
			this.richTextBox_Console.ReadOnly = true;
			this.richTextBox_Console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.richTextBox_Console.Size = new System.Drawing.Size(295, 308);
			this.richTextBox_Console.TabIndex = 4;
			this.richTextBox_Console.Text = "";
			// 
			// textBox_CurrentProcess
			// 
			this.textBox_CurrentProcess.BackColor = System.Drawing.Color.Black;
			this.textBox_CurrentProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_CurrentProcess.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_CurrentProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.textBox_CurrentProcess.Location = new System.Drawing.Point(286, 11);
			this.textBox_CurrentProcess.Name = "textBox_CurrentProcess";
			this.textBox_CurrentProcess.ReadOnly = true;
			this.textBox_CurrentProcess.Size = new System.Drawing.Size(119, 22);
			this.textBox_CurrentProcess.TabIndex = 1;
			// 
			// comboBox_Process
			// 
			this.comboBox_Process.BackColor = System.Drawing.Color.Black;
			this.comboBox_Process.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Process.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_Process.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.comboBox_Process.FormattingEnabled = true;
			this.comboBox_Process.Location = new System.Drawing.Point(7, 10);
			this.comboBox_Process.Name = "comboBox_Process";
			this.comboBox_Process.Size = new System.Drawing.Size(131, 22);
			this.comboBox_Process.TabIndex = 3;
			this.comboBox_Process.Click += new System.EventHandler(this.ComboBox_Process_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(584, 356);
			this.Controls.Add(this.textBox_CurrentProcess);
			this.Controls.Add(this.comboBox_Process);
			this.Controls.Add(this.groupBox_Memory);
			this.Controls.Add(this.button_OpenProcess);
			this.Controls.Add(this.richTextBox_Console);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Main";
			this.Opacity = 0.9D;
			this.Text = "RednibMemory";
			this.Load += new System.EventHandler(this.MainLoad);
			this.Click += new System.EventHandler(this.Button_OpenProcess_Click);
			this.groupBox_Memory.ResumeLayout(false);
			this.groupBox_Memory.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
