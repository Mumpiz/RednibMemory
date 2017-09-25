/*
 * 
 * User: Rednib
 * Date: 20.09.2017
 * Time: 13:29
 * Version: 0.1
 *
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RednibMemory;
using System.Diagnostics; // for Process
using System.Text;
using System.Globalization;

namespace RednibMemoryReader
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class Main : Form
	{
		// Instanciate my Rednib Dll
		RednibMemory.MemoryReader memReader = new RednibMemory.MemoryReader();
		
		// Array of all running processes
		public Process[] Processes = Process.GetProcesses();
		
		public Main()
		{
			InitializeComponent();
			AddProcessesToComboBox();
			AddValueTypesToComboBox();
			Print("Select a process... \n");
			
		}
		

		
		void WriteMemeory()
		{
			int pAddress = GetAddressFromTextBox();
			if (pAddress == 0)
				return;
			
			int offsetSum = GetOffsetFromTextBoxes();
			if (offsetSum == -1)
				return;
			
			// not the best but the quickes and easiest way :p
			sbyte byteToWrite = -1;
			short shortToWrite = -1;
			int intToWrite = -1;
			long longToWrite = -1;
			switch (GetDataTypeFromComboBox())
			{
				case 1:
					GetDecimalValueFromTextBox(out byteToWrite);
					break;
				case 2:
					GetDecimalValueFromTextBox(out shortToWrite);
					break;
				case 8:
					GetDecimalValueFromTextBox(out longToWrite);
					break;
				default:
				case 4:
					GetDecimalValueFromTextBox(out intToWrite);
					break;
			}
			byte[] bytesToWrite = null;
			
			if (byteToWrite != -1)
			{
				bytesToWrite = BitConverter.GetBytes(byteToWrite);
				// Strange: BitConverter.GetBytes returns a two element array even though
				// a one byte value was passed as argument.
				// The first element contains the value of the passed byte
				// the second is always 0.
				// So to fit the byte data type, the array needs to be resized
				// to one element.
				// As short array has two elements,
				// int four and long eight elements.
				Array.Resize(ref bytesToWrite, 1);
			}
			else if (shortToWrite != -1)
			{
				bytesToWrite = BitConverter.GetBytes(shortToWrite);
			}
			else if (intToWrite != -1)
			{
				bytesToWrite = BitConverter.GetBytes(intToWrite);
			}
			else if (longToWrite != -1)
			{
				bytesToWrite = BitConverter.GetBytes(longToWrite);
			}
			else
			{
				Print("Invalid data to write \n");
				textBox_DecimalValue.Text = "0";
				return;
			}
			
			
			string hexOutput = BitConverter.ToString(bytesToWrite);
			long decOutput = ConvertToDecimal(bytesToWrite);
			
			//has the value that needs to be written into memory the size that
			//was entered into the combobox "Data type"
			if (bytesToWrite.Length == (int)GetDataTypeFromComboBox())
			{
				string sign = "";
				if (offsetSum < 0)
				{
					uint offset = (uint)Math.Abs(offsetSum);
					memReader.WriteMemory((IntPtr)(pAddress - offset), bytesToWrite);
					sign = "-";
				}
				else
				{
					memReader.WriteMemory((IntPtr)(pAddress + (uint)offsetSum), bytesToWrite);//, out int bytesWritten)
				}
				
					
					Print("WRITE:\t" + comboBox_DataType.Text + " " + textBox_Address.Text
				      	 + " Offset " + sign + Math.Abs(offsetSum).ToString("X") + ":\n \t"
					     + "Dec:\t" + decOutput + "\n \t"
					     + "Hex:\t" + hexOutput + "\n" );
				}
				else
				{
					Print("Invalid data type for this decimal value: " + GetDataTypeFromComboBox() + " \n");
				}

		}
		
		void ReadMemory()
		{
			if (textBox_Address.Text != "")
			{
				//Process process = memReader.CurrentProcess; // gets initialised when process is opened
					
				int pAddress = GetAddressFromTextBox();
				if (pAddress == 0)
					return;
				
				int offsetSum = GetOffsetFromTextBoxes();
				if (offsetSum == -1)
					return;
				
				uint bytesToRead = GetDataTypeFromComboBox();
				if (bytesToRead == 0)
					return;
				
				byte[] buffer;
				string sign = "";
				if (offsetSum < 0)
				{
					uint offset = (uint)Math.Abs(offsetSum);
					buffer = memReader.ReadMemory((IntPtr)(pAddress - offset), bytesToRead);
					sign = "-";
				}
				else
				{
					buffer = memReader.ReadMemory((IntPtr)(pAddress + (uint)offsetSum), bytesToRead);
				}
				
				string hexOutput = BitConverter.ToString(buffer);
				long decOutput = ConvertToDecimal(buffer);
				
				Print("READ:\t" + comboBox_DataType.Text + " " + textBox_Address.Text
				     + " Offset " + sign + Math.Abs(offsetSum).ToString("X") + ":\n \t"
				     + "Dec:\t" + decOutput + "\n \t"
				     + "Hex:\t" + hexOutput + "\n" );
				textBox_DecimalValue.Text = decOutput.ToString();
			}
			else
			{
				if (textBox_CurrentProcess.Text == "")
				{
					Print("No process handle! \n");
				}
				else
				{
					Print("No address! \n");	
				}
			}
			
		}
		
		//Converts a byte array into a decimal number (supports only 1, 2, 4 and 8 byte array atm)
		long ConvertToDecimal(byte[] bytes)
		{
			long decOutput = 0;
			switch (bytes.Length) // Value Type
				{
					case 1:
						decOutput = bytes[0];
						return decOutput;
					case 2:
						decOutput = BitConverter.ToInt16(bytes, 0);
						return decOutput;
					case 4:
						decOutput = BitConverter.ToInt32(bytes, 0);
						return decOutput;
					case 8:
						decOutput = BitConverter.ToInt64(bytes, 0);
						return decOutput;
					default:
						return 0;	
				}
		}
		
		// add type here
		void GetDecimalValueFromTextBox(out long value)
		{
			if(!(Int64.TryParse(textBox_DecimalValue.Text, NumberStyles.Integer, CultureInfo.CurrentCulture, out value)))
			{
				Print("Invalid decimal value format: " + textBox_DecimalValue.Text + "\n");
				textBox_DecimalValue.Text = "";
				value = -1;
			}
		}
		void GetDecimalValueFromTextBox(out int value)
		{
			if(!(Int32.TryParse(textBox_DecimalValue.Text, NumberStyles.Integer, CultureInfo.CurrentCulture, out value)))
			{
				Print("Invalid decimal value format: " + textBox_DecimalValue.Text + "\n");
				textBox_DecimalValue.Text = "";
				value = -1;
			}
		}
		void GetDecimalValueFromTextBox(out short value)
		{
			if(!(Int16.TryParse(textBox_DecimalValue.Text, NumberStyles.Integer, CultureInfo.CurrentCulture, out value)))
			{
				Print("Invalid decimal value format: " + textBox_DecimalValue.Text + "\n");
				textBox_DecimalValue.Text = "";
				value = -1;
			}
		}
		void GetDecimalValueFromTextBox(out sbyte value)
		{
			if(!(SByte.TryParse(textBox_DecimalValue.Text, NumberStyles.Integer, CultureInfo.CurrentCulture, out value)))
			{
				Print("Invalid decimal value format: " + textBox_DecimalValue.Text + "\n");
				textBox_DecimalValue.Text = "";
				value = -1;
			}
		}
		
		uint GetDataTypeFromComboBox()
		{	
			switch (comboBox_DataType.Text)
			{
				case "":
					Print("Data type not defined! \n");
					return 0;
				case "1 Byte":
					return 1;
				case "2 Byte":
					return 2;
				case "4 Byte":
					return 4;
				case "8 Byte":
					return 8;
				default:
					Print("Invalid data type " + comboBox_DataType.Text + "\n");
					comboBox_DataType.Text = "4 Byte";
					return 4;
			}
		}
		
		int GetAddressFromTextBox()
		{
			int pAddress;
			if(!(Int32.TryParse(textBox_Address.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out pAddress)))
			{
				Print("Invalid address format: " + textBox_Address.Text + "\n");
				textBox_Address.Text = "";
				return 0;
			}
			return pAddress;
		}
		
		int GetOffsetFromTextBoxes()
		{
			int offsetSum = 0;
			int offset1 = 0;
			int offset2 = 0;
			int offset3 = 0;
			int offset4 = 0;
			int offset5 = 0;
			int offset6 = 0;
			
			if(!(Int32.TryParse(textBox_Offset1.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out offset1)))
			{
				Print("Invalid offset 1 format: " + textBox_Offset1.Text + "\n");
				textBox_Offset1.Text = "0";
				return -1;
			}
			if(!(Int32.TryParse(textBox_Offset2.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out offset2)))
			{
				Print("Invalid offset 2 format: " + textBox_Offset2.Text + "\n");
				textBox_Offset2.Text = "0";
				return -1;
			}
			if(!(Int32.TryParse(textBox_Offset3.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out offset3)))
			{
				Print("Invalid offset 3 format: " + textBox_Offset3.Text + "\n");
				textBox_Offset3.Text = "0";
				return -1;
			}
			if(!(Int32.TryParse(textBox_Offset4.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out offset4)))
			{
				Print("Invalid offset 4 format: " + textBox_Offset4.Text + "\n");
				textBox_Offset4.Text = "0";
				return -1;
			}
			if(!(Int32.TryParse(textBox_Offset5.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out offset5)))
			{
				Print("Invalid offset 5 format: " + textBox_Offset5.Text + "\n");
				textBox_Offset5.Text = "0";
				return -1;
			}
			if(!(Int32.TryParse(textBox_Offset6.Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out offset6)))
			{
				Print("Invalid offset 6 format: " + textBox_Offset6.Text + "\n");
				textBox_Offset6.Text = "0";
				return -1;
			}
			
			if (checkBox_Offset1Negative.Checked)
			{
				offsetSum -= offset1;
			}
			else
			{
				offsetSum += offset1;
			}
			
			if (checkBox_Offset2Negative.Checked)
			{
				offsetSum -= offset2;
			}
			else
			{
				offsetSum += offset2;
			}
			
			if (checkBox_Offset3Negative.Checked)
			{
				offsetSum -= offset3;
			}
			else
			{
				offsetSum += offset3;
			}
			
			if (checkBox_Offset4Negative.Checked)
			{
				offsetSum -= offset4;
			}
			else
			{
				offsetSum += offset4;
			}
			
			if (checkBox_Offset5Negative.Checked)
			{
				offsetSum -= offset5;
			}
			else
			{
				offsetSum += offset5;
			}
			
			if (checkBox_Offset6Negative.Checked)
			{
				offsetSum -= offset6;
			}
			else
			{
				offsetSum += offset6;
			}
			
			//offsetSum = offset1 + offset2 + offset3 + offset4 + offset5 + offset6;
			
			return offsetSum;
		}
		
		
		// add all running processes to combobox
		void AddProcessesToComboBox()
		{
			comboBox_Process.Items.Clear();
			foreach (Process p in Processes)
			{
				comboBox_Process.Items.Add(p.ProcessName);
			}
		}
		
		
		// add all value types to combobox
		void AddValueTypesToComboBox()
		{
			comboBox_DataType.Items.Add("1 Byte");
			comboBox_DataType.Items.Add("2 Byte");
			comboBox_DataType.Items.Add("4 Byte");
			comboBox_DataType.Items.Add("8 Byte");
		}
		
		void Button_OpenProcess_Click(object sender, EventArgs e)
		{
			
			if (memReader.HasHandle())
			{
				memReader.CloseHandle();
				Print("Closing handle: "+ textBox_CurrentProcess.Text + "\n");
			}
			
			if (comboBox_Process.Text != "")
			{
				Cls();
				
				Process[] processes = Process.GetProcessesByName(comboBox_Process.Text);
				Process selectedProcess = processes[0];
				if (selectedProcess == null)
				{
					throw new Exception("Unable to open process: " + comboBox_Process.Text +"!");
				}
				memReader.OpenProcess(selectedProcess);
				textBox_CurrentProcess.Text = selectedProcess.ProcessName;
				Print("Setting handle to: "+ textBox_CurrentProcess.Text + "\n");
			}
			else
			{
				Print("Select a process first! \n");
			}
		}
		
		void Button_WriteMemory_Click(object sender, EventArgs e)
		{
			WriteMemeory();
		}
		
		void Button_ReadMemory_Click(object sender, EventArgs e)
		{
			ReadMemory();
		}
		
		void ComboBox_Process_Click(object sender, EventArgs e)
		{
			Processes = Process.GetProcesses();
			AddProcessesToComboBox();
		}
		
		void Print(string output)
		{
			//richTextBox_Console.AppendText(output);
			richTextBox_Console.SelectionStart = 0;
			richTextBox_Console.SelectedText = output;
		}
		
		void Cls()
		{
			richTextBox_Console.Clear();
		}
		void TextBox_DecimalValueTextChanged(object sender, EventArgs e)
		{
	
		}
		void MainLoad(object sender, EventArgs e)
		{
	
		}
		void GroupBox_MemoryEnter(object sender, EventArgs e)
		{
	
		}
		
	}
	
}
