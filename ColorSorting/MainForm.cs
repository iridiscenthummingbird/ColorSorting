using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace ColorSorting
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			ImageToSort.Height = Int32.Parse(numericUpDown1.Value.ToString());
			Colors.Array = new Color[ImageToSort.Height, ImageToSort.Height];
			ImageToSort.Image = new Bitmap(ImageToSort.Height, ImageToSort.Height);
			numericUpDown1.Value = decimal.Parse(Properties.Settings.Default.Height.ToString());

			ChangeLanguage.ResManager = new ResourceManager[2];
			ChangeLanguage.ResManager[0] = new ResourceManager("ColorSorting.Resourses.ukr", System.Reflection.Assembly.GetExecutingAssembly());
			ChangeLanguage.ResManager[1] = new ResourceManager("ColorSorting.Resourses.eng", System.Reflection.Assembly.GetExecutingAssembly());
			changeLanguage();

			SimpleLog.newSession();
		
		}

		[DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteObject([In] IntPtr hObject);

		private void fill()
		{
			SimpleLog.SWatch_start("Filling picture " + ImageToSort.Height.ToString() + 'x' + ImageToSort.Height.ToString());
			Random rand = new Random();
			List<Color> colors = new List<Color>();
			colors.Clear();

			for (int i = 0; i < ImageToSort.Height * ImageToSort.Height; i++)
			{
				colors.Add(Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), Colors.ConstantColor));
			}
			Colors.ListOfColors.Clear();

			foreach (Color c in colors)
			{
				Colors.ListOfColors.Add(c);
			}
			Colors.ListOfColors = colors;
			int count = 0;


			for (int i = 0; i < ImageToSort.Height; i++)
			{
				for (int j = 0; j < ImageToSort.Height; j++)
				{
					ImageToSort.Image.SetPixel(i, j, colors[count]);
					Colors.Array[i, j] = colors[count];
					count++;
				}
			}

			pictureBox1.Image = ImageToSort.Image;
			SimpleLog.SWatch_stop();
		}


		private void Mix_Click(object sender, EventArgs e)
		{
			fill();
			shellSortButton.Enabled = true;
			shakerSortButton.Enabled = true;
		}

		static void Swap<T>(ref T a, ref T b)
		{
			T c = a;
			a = b;
			b = c;
		}

		private async void shakerSort()
		{
			int l, r, count = 0;
			bool flag = false;

			SimpleLog.SWatch_start("Sorting: shaker");

			if (GIFCheckBox.Checked)
				ImageToSort.gifEncoder = new GifBitmapEncoder();

			if (GIFCheckBox.Checked)
				add(ImageToSort.Image);

			for (int index = 0; index < 6; index++)
			{
				for (int i = 0; i < ImageToSort.Height; i++)
				{
					l = 0;
					r = ImageToSort.Height - 1;


					while (l < r)
					{
						flag = false;
						for (int j = l; j < r; j++)
						{
							if (Colors.Array[j, i].G < Colors.Array[j + 1, i].G)
							{
								Swap(ref Colors.Array[j, i], ref Colors.Array[j + 1, i]);
								Color tmp = ImageToSort.Image.GetPixel(j, i);


								ImageToSort.Image.SetPixel(j, i, ImageToSort.Image.GetPixel(j + 1, i));

								ImageToSort.Image.SetPixel(j + 1, i, tmp);
								pictureBox1.Image = ImageToSort.Image;

								if (delayCheckbox.Checked)
									await Task.Delay(10);
							}
						}
						r--;
						for (int j = r; j < l; j++)
						{
							if (Colors.Array[j, i].G < Colors.Array[j - 1, i].G)
							{
								Swap(ref Colors.Array[j, i], ref Colors.Array[j - 1, i]);

								Color tmp = ImageToSort.Image.GetPixel(j, i);


								ImageToSort.Image.SetPixel(j, i, ImageToSort.Image.GetPixel(j - 1, i));

								ImageToSort.Image.SetPixel(j - 1, i, tmp);

								pictureBox1.Image = ImageToSort.Image;

								if (delayCheckbox.Checked)
									await Task.Delay(10);

							}
						}
						l++;
						count++;
						flag = true;

					}
					if (flag && GIFCheckBox.Checked && count % 200 == 0)
						add(ImageToSort.Image);
				}
				for (int i = 0; i < ImageToSort.Height; i++)
				{
					l = 0;
					r = ImageToSort.Height - 1;


					while (l < r)
					{
						flag = false;
						for (int j = l; j < r; j++)
						{
							if (Colors.Array[i, j].R < Colors.Array[i, j + 1].R)
							{
								Swap(ref Colors.Array[i, j], ref Colors.Array[i, j + 1]);

								Color tmp = ImageToSort.Image.GetPixel(i, j);


								ImageToSort.Image.SetPixel(i, j, ImageToSort.Image.GetPixel(i, j + 1));

								ImageToSort.Image.SetPixel(i, j + 1, tmp);
								pictureBox1.Image = ImageToSort.Image;

								if (delayCheckbox.Checked)
									await Task.Delay(100);
							}
						}
						r--;
						for (int j = r; j < l; j++)
						{
							if (Colors.Array[j, i].R < Colors.Array[j - 1, i].R)
							{
								Swap(ref Colors.Array[i, j], ref Colors.Array[i, j - 1]);

								Color tmp = ImageToSort.Image.GetPixel(i, j);


								ImageToSort.Image.SetPixel(i, j, ImageToSort.Image.GetPixel(i, j - 1));

								ImageToSort.Image.SetPixel(i, j - 1, tmp);
								pictureBox1.Image = ImageToSort.Image;

								if (delayCheckbox.Checked)
									await Task.Delay(100);
							}
						}
						l++;
						count++;
						flag = true;

					}
					if (flag && GIFCheckBox.Checked && count % 200 == 0)
						add(ImageToSort.Image);
				}
			}

			if (GIFCheckBox.Checked) writeGIF();
			SimpleLog.SWatch_stop();
			numericUpDown1.Enabled = true;
			mixButton.Enabled = true;
			shakerSortButton.Enabled = true;
			shellSortButton.Enabled = true;
		}

		private async void shellSort()
		{

			SimpleLog.SWatch_start("Sorting shell");
			bool flag = false;
			int count = 0;

			if (GIFCheckBox.Checked)
				ImageToSort.gifEncoder = new GifBitmapEncoder();

			if (GIFCheckBox.Checked)
				add(ImageToSort.Image);

			for (int index = 0; index < 5; index++)
			{
				for (int ind_i = 0; ind_i < ImageToSort.Height; ind_i++)
				{
					int step;
					flag = false;
					for (step = ImageToSort.Height / 2; step > 0; step /= 2)
					{

						for (int i = step; i < ImageToSort.Height; i++)
						{
							for (int j = i - step; j >= 0 && Colors.Array[ind_i, j].R < Colors.Array[ind_i, j + step].R; j -= step)
							{
								Color tmp = Colors.Array[ind_i, j];
								Colors.Array[ind_i, j] = Colors.Array[ind_i, j + step];
								Colors.Array[ind_i, j + step] = tmp;

								flag = true;
								count++;

								ImageToSort.Image.SetPixel(ind_i, j, Colors.Array[ind_i, j]);

								ImageToSort.Image.SetPixel(ind_i, j + step, Colors.Array[ind_i, j + step]);
								pictureBox1.Image = ImageToSort.Image;

								if (delayCheckbox.Checked)
									await Task.Delay(1);
							}
						}
					}
					if (flag && GIFCheckBox.Checked && count % 5 == 0)
						add(ImageToSort.Image);
				}

				for (int ind_j = 0; ind_j < ImageToSort.Height; ind_j++)
				{
					int step;
					flag = false;
					for (step = ImageToSort.Height / 2; step > 0; step /= 2)
					{

						for (int i = step; i < ImageToSort.Height; i++)
						{
							for (int j = i - step; j >= 0 && Colors.Array[j, ind_j].G < Colors.Array[j + step, ind_j].G; j -= step)
							{
								Color tmp = Colors.Array[j, ind_j];
								Colors.Array[j, ind_j] = Colors.Array[j + step, ind_j];
								Colors.Array[j + step, ind_j] = tmp;

								count++;
								flag = true;

								ImageToSort.Image.SetPixel(j, ind_j, Colors.Array[j, ind_j]);

								ImageToSort.Image.SetPixel(j + step, ind_j, Colors.Array[j + step, ind_j]);
								pictureBox1.Image = ImageToSort.Image;

								if (delayCheckbox.Checked)
									await Task.Delay(1);
							}
						}
					}
					if (flag && GIFCheckBox.Checked && count % 5 == 0)
						add(ImageToSort.Image);

				}
			}

			if (GIFCheckBox.Checked) writeGIF();
			SimpleLog.SWatch_stop();
			numericUpDown1.Enabled = true;
			mixButton.Enabled = true;
			shakerSortButton.Enabled = true;
			shellSortButton.Enabled = true;
		}

		private void changeLanguage()
		{
			int tmp = ChangeLanguage.Language ? 1 : 0;

			mixButton.Text = ChangeLanguage.ResManager[tmp].GetString("mix");
			shakerSortButton.Text = ChangeLanguage.ResManager[tmp].GetString("shaker_sort");
			shellSortButton.Text = ChangeLanguage.ResManager[tmp].GetString("shell_sort");
			delayCheckbox.Text = ChangeLanguage.ResManager[tmp].GetString("delay");
			changeLanguageToolStripMenuItem.Text = ChangeLanguage.ResManager[tmp].GetString("changeLanguage");
			this.Text = ChangeLanguage.ResManager[tmp].GetString("colorsSort");
			fileToolStripMenuItem.Text = ChangeLanguage.ResManager[tmp].GetString("file");
			writeToolStripMenuItem.Text = ChangeLanguage.ResManager[tmp].GetString("write");
			readToolStripMenuItem.Text = ChangeLanguage.ResManager[tmp].GetString("read");
			GIFCheckBox.Text = ChangeLanguage.ResManager[tmp].GetString("writeGif");
			changeConstantColorToolStripMenuItem.Text = ChangeLanguage.ResManager[tmp].GetString("changeConstantColorForm");
            aboutToolStripMenuItem.Text = ChangeLanguage.ResManager[tmp].GetString("about");
        }

        private void changeLanguageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChangeLanguageForm f = new ChangeLanguageForm();
			f.ShowDialog();
			changeLanguage();
		}

		private void mixButton_Click(object sender, EventArgs e)
		{
			GC.Collect();

			ImageToSort.Image.Dispose();
			ImageToSort.Height = Int32.Parse(numericUpDown1.Value.ToString());
			Colors.Array = new Color[ImageToSort.Height, ImageToSort.Height];
			ImageToSort.Image = new Bitmap(ImageToSort.Height, ImageToSort.Height);
			fill();
			shakerSortButton.Enabled = true;
			shellSortButton.Enabled = true;

			GC.Collect();

		}

		private void shellSortButton_Click(object sender, EventArgs e)
		{
			numericUpDown1.Enabled = false;
			mixButton.Enabled = false;
			shakerSortButton.Enabled = false;
			shellSortButton.Enabled = false;
			shellSort();

		}

		private void shakerSortButton_Click(object sender, EventArgs e)
		{
			numericUpDown1.Enabled = false;
			mixButton.Enabled = false;
			shakerSortButton.Enabled = false;
			shellSortButton.Enabled = false;
			shakerSort();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.Height = ImageToSort.Height;
		}

		private void changeConstantColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ChangeConstantColorForm f = new ChangeConstantColorForm();
			f.ShowDialog();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.Save();
			SimpleLog.endSession();
		}

		private void writeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Colors.ListOfColors.Count == 0) return;
			SaveFileDialog exportFile = new SaveFileDialog
			{
				Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv|Bitmap pictures (*bmp)|*.bmp",
				FilterIndex = 1,
				RestoreDirectory = true
			};
			if (exportFile.ShowDialog() == DialogResult.OK)
			{
				SimpleLog.SWatch_start("Exporting file " + exportFile.FileName);
				if (exportFile.FilterIndex != 3)
				{
					try
					{
						using (StreamWriter fout = new StreamWriter(exportFile.FileName, false))
						{
							int value = ImageToSort.Height;

							try
							{
								switch (exportFile.FilterIndex)
								{
									case 1:
										fout.WriteLine(value + " " + Colors.ConstantColor);
										for (int i = 0; i < value * value; i++)
										{
											fout.Write(Colors.ListOfColors[i].R + " " + Colors.ListOfColors[i].G + " ");
											if (i != 0 && i % value == 0) fout.Write('\n');
										}
										break;
									case 2:
										fout.WriteLine(value + "," + Colors.ConstantColor);
										for (int i = 0; i < value * value; i++)
										{
											fout.Write("\"" + Colors.ListOfColors[i].R + "," + Colors.ListOfColors[i].G + "\"");
											if (i != 0 && ((i + 1) % value == 0)) fout.Write('\n');
											else fout.Write(",");
										}
										break;
								}
							}
							catch (Exception ex)
							{
								FileExceptionForm exForm = new FileExceptionForm(ex, 1);
								exForm.ShowDialog();
							}
						}
					}
					catch(Exception ex)
					{
						CatchEx(ex, 3);
						return;
					}
				}
				else
				{
					try {
						using (Bitmap img = ImageToSort.Image)
						{
							try { img.Save(exportFile.FileName); }
							catch (Exception ex)
							{
								FileExceptionForm exForm = new FileExceptionForm(ex, 1);
								exForm.ShowDialog();
							}
						}
					}
					catch(Exception ex)
					{
						CatchEx(ex, 3);
						return;
					}
				}
				SimpleLog.SWatch_stop();
			}
			exportFile.Dispose();

		}

		private void readToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog importFile = new OpenFileDialog
			{
				Filter = "All supported files (*.txt, *.csv, *.bmp)|*.txt;*.csv;*.bmp|Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv|Mitmap pictures (*bmp)|*.bmp",
				FilterIndex = 1,
				RestoreDirectory = true,
				Multiselect = false
					
			};

			if (importFile.ShowDialog() == DialogResult.OK)
			{
				SimpleLog.SWatch_start("Importing picture " + importFile.FileName);
				ImageToSort.Image.Dispose();
				Colors.ListOfColors.Clear();
				Bitmap tmp;

				if (importFile.FileName.EndsWith(".bmp"))
				{
					try
					{
						tmp = new Bitmap(importFile.FileName);

						if (tmp.Height != tmp.Width || tmp.Height > numericUpDown1.Maximum || tmp.Height < numericUpDown1.Minimum)
						{
							tmp.Dispose();
							throw new Exception();
						}
					}

					catch (Exception ex)
					{
						CatchEx(ex);
						return;
					}

					numericUpDown1.Value = tmp.Height;
					ImageToSort.Height = tmp.Height;
					ImageToSort.Image = new Bitmap(ImageToSort.Height, ImageToSort.Height);
					Colors.ListOfColors.Clear();
					Colors.Array = new Color[ImageToSort.Height, ImageToSort.Height];
					Colors.ListOfColors = new List<Color>(ImageToSort.Height * ImageToSort.Height);

					Question f = new Question();

					if (f.ShowDialog() == DialogResult.Yes)
					{
						for (int i = 0; i < tmp.Width; i++)
						{
							for (int j = 0; j < tmp.Width; j++)
							{
								ImageToSort.Image.SetPixel(i, j, Color.FromArgb(tmp.GetPixel(i, j).R, tmp.GetPixel(i, j).G, Colors.ConstantColor));
								Colors.Array[i, j] = Color.FromArgb(tmp.GetPixel(i, j).R, tmp.GetPixel(i, j).G, Colors.ConstantColor);
								Colors.ListOfColors.Add(Colors.Array[i, j]);
							}
						}
					}
					else
					{
						for (int i = 0; i < tmp.Width; i++)
						{
							for (int j = 0; j < tmp.Width; j++)
							{
								ImageToSort.Image.SetPixel(i, j, tmp.GetPixel(i, j));
								Colors.Array[i, j] = tmp.GetPixel(i, j);
								Colors.ListOfColors.Add(Colors.Array[i, j]);
							}
						}
					}
					f.Dispose();
					pictureBox1.Image = ImageToSort.Image;
					
					tmp.Dispose();
				}
				else
				{
					int[] parameters;
					try { 
						using (StreamReader fin = new StreamReader(importFile.FileName))
						{
							String inText = fin.ReadLine(), pattern = @"(\d{1,3})[,\s](\d{1,3})\n?";
							try
							{
								parameters = inText.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
								if (parameters[0] > numericUpDown1.Maximum || parameters[0] < numericUpDown1.Minimum)
									throw new Exception();

							}
							catch (Exception ex)
							{
								CatchEx(ex);
								return;
							}

							ImageToSort.Height = parameters[0];
							try
							{
								Colors.ConstantColor = (byte)parameters[1];
							}
							catch (Exception ex)
							{
								CatchEx(ex);
								return;
							}

							for (int i = 0; i < ImageToSort.Height; i++)
							{
								String line = fin.ReadLine();
								System.Text.RegularExpressions.MatchCollection Mat;
								try
								{
									Mat = System.Text.RegularExpressions.Regex.Matches(line, pattern);
								}
								catch (Exception ex)
								{
									CatchEx(ex);
									return;
								}

								foreach (System.Text.RegularExpressions.Match m in Mat)
									Colors.ListOfColors.Add(Color.FromArgb(int.Parse(m.Groups[1].Value), int.Parse(m.Groups[2].Value), Colors.ConstantColor));
							}

							Colors.Array = new Color[ImageToSort.Height, ImageToSort.Height];
							ImageToSort.Image = new Bitmap(ImageToSort.Height, ImageToSort.Height);

							int count = 0;

							for (int i = 0; i < ImageToSort.Height; i++)
							{
								for (int j = 0; j < ImageToSort.Height; j++)
								{
									try
									{
										ImageToSort.Image.SetPixel(i, j, Colors.ListOfColors[count]);
									}
									catch (Exception ex)
									{
										CatchEx(ex);
										return;
									}
									Colors.Array[i, j] = Colors.ListOfColors[count];
									count++;
								}
							}
							pictureBox1.Image = ImageToSort.Image;
							numericUpDown1.Value = ImageToSort.Height;
						}
					}
					catch (Exception ex)
					{
						CatchEx(ex, 2);
						return;
					}
				}
				SimpleLog.SWatch_stop();
				shellSortButton.Enabled = true;
				shakerSortButton.Enabled = true;
			}
			importFile.Dispose();
		}	
		private void add(Bitmap img)
		{
			try
			{
				var bmp = img.GetHbitmap();
				var BitMFrame = BitmapFrame.Create(
					System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
						bmp,
						IntPtr.Zero,
						Int32Rect.Empty,
						BitmapSizeOptions.FromEmptyOptions()));

				ImageToSort.gifEncoder.Frames.Add(BitMFrame);
				DeleteObject(bmp);
				GC.Collect();
			}
			catch (Exception)
			{
				int tmp = ChangeLanguage.Language ? 1 : 0;
				MessageBox.Show(ChangeLanguage.ResManager[tmp].GetString("ExOutOfMemory"),
								ChangeLanguage.ResManager[tmp].GetString("ExOOM_Capture"),
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
				System.Environment.Exit(0);
			}
		}

		private void writeGIF()
		{
			SaveFileDialog exportGIF = new SaveFileDialog
			{
				Filter = "GIF files (*.gif)|*.gif",
				RestoreDirectory = true,
			};

			if (exportGIF.ShowDialog() == DialogResult.OK)
			{
				SimpleLog.SWatch_start("Exporting file " + exportGIF.FileName);
				try
				{
					using (FileStream fs = new FileStream(exportGIF.FileName, FileMode.Create))
					{
						try
						{
							ImageToSort.gifEncoder.Save(fs);
						}
						catch (Exception ex)
						{
							FileExceptionForm ExForm = new FileExceptionForm(ex, 1);
							ExForm.Show();
						}

					}
				}
				catch(Exception ex)
				{
					FileExceptionForm ExForm = new FileExceptionForm(ex, 3);
					ExForm.Show();
				}
				ImageToSort.gifEncoder.Frames.Clear();
				ImageToSort.gifEncoder = null;
			}
			GC.Collect();
		}

		private void CatchEx(Exception ex, int ind = 0)
		{

			ImageToSort.Image.Dispose();
			Colors.Array = null;
			Colors.ListOfColors.Clear();
			pictureBox1.Image = new Bitmap(5, 5);

			shakerSortButton.Enabled = false;
			shellSortButton.Enabled = false;

			FileExceptionForm ExForm = new FileExceptionForm(ex, ind);
			ExForm.ShowDialog();

			this.Enabled = true;
		}

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm f = new AboutForm();
            f.ShowDialog();
        }
    }
}
