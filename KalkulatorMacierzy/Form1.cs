using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorMacierzy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            C1.SelectAll();
            C1.SelectionAlignment = HorizontalAlignment.Center;
            C1.DeselectAll();
            C2.SelectAll();
            C2.SelectionAlignment = HorizontalAlignment.Center;
            C2.DeselectAll();
            C3.SelectAll();
            C3.SelectionAlignment = HorizontalAlignment.Center;
            C3.DeselectAll();
            C4.SelectAll();
            C4.SelectionAlignment = HorizontalAlignment.Center;
            C4.DeselectAll();
            C5.SelectAll();
            C5.SelectionAlignment = HorizontalAlignment.Center;
            C5.DeselectAll();
            C6.SelectAll();
            C6.SelectionAlignment = HorizontalAlignment.Center;
            C6.DeselectAll();
            C7.SelectAll();
            C7.SelectionAlignment = HorizontalAlignment.Center;
            C7.DeselectAll();
            C8.SelectAll();
            C8.SelectionAlignment = HorizontalAlignment.Center;
            C8.DeselectAll();
            C9.SelectAll();
            C9.SelectionAlignment = HorizontalAlignment.Center;
            C9.DeselectAll();
              
        }

        private void A1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void A2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void A3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void A4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void A5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void A6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void A7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void A8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void A9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void B1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void B2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void B3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void B4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void B5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void B6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void B7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void B8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void B9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            double[,] result = new double[this.tableLayoutPanel1.RowCount, this.tableLayoutPanel1.ColumnCount];
            for (int i = 0; i < this.tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < this.tableLayoutPanel1.ColumnCount; j++)
                {
                    string temp = this.tableLayoutPanel1.GetControlFromPosition(i, j).Text; //pobiera wartość z danej komórki tabeli (Macierz A)
                    string temp2 = this.tableLayoutPanel2.GetControlFromPosition(i, j).Text; //pobiera wartość z danej komórki tabeli (Macierz A)
                    result[i, j] = Convert.ToInt32(temp) + Convert.ToInt32(temp2);  //przypisanie do pomocniczej tablicy wartości dodanych z odpowiednich komórek
                }
                
            }
            for (int i = 0; i < this.tableLayoutPanel3.RowCount; i++)
            {
                for (int j = 0; j < this.tableLayoutPanel3.ColumnCount; j++)
                {
                    this.tableLayoutPanel3.GetControlFromPosition(i, j).Text = Convert.ToString(result[i,j]);               
                }
            }
            

        }

        private void odejmijButton_Click(object sender, EventArgs e)
        {
            double[,] result = new double[this.tableLayoutPanel1.RowCount, this.tableLayoutPanel1.ColumnCount]; //wynikowa macierz jako tablica dwuwymiarowa
            for (int i = 0; i < this.tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < this.tableLayoutPanel1.ColumnCount; j++)
                {
                    string temp = this.tableLayoutPanel1.GetControlFromPosition(i, j).Text; //pobiera wartość z danej komórki tabeli (Macierz A)
                    string temp2 = this.tableLayoutPanel2.GetControlFromPosition(i, j).Text; //pobiera wartość z danej komórki tabeli (Macierz A)
                    result[i, j] = Convert.ToInt32(temp) - Convert.ToInt32(temp2);  //przypisanie do pomocniczej tablicy wartości dodanych z odpowiednich komórek
                }

            }
            for (int i = 0; i < this.tableLayoutPanel3.RowCount; i++)
            {
                for (int j = 0; j < this.tableLayoutPanel3.ColumnCount; j++)
                {
                    this.tableLayoutPanel3.GetControlFromPosition(i, j).Text = Convert.ToString(result[i, j]);  //wpisanie do macierzy wynikowej
                }
            }

        }

        private void iloczynButton_Click(object sender, EventArgs e)
        {
            double[,] result = new double[this.tableLayoutPanel1.RowCount, this.tableLayoutPanel1.ColumnCount]; //wynikowa macierz jako tablica dwuwymiarowa
            double temp3 = 0;
            for (int i = 0; i < this.tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < this.tableLayoutPanel2.ColumnCount; j++)
                {
                    temp3 = 0;
                    for (int k = 0; k < this.tableLayoutPanel2.RowCount; k++)
                    {
                        string temp = this.tableLayoutPanel2.GetControlFromPosition(i, k).Text;
                        string temp2 = this.tableLayoutPanel1.GetControlFromPosition(k, j).Text;
                        temp3 += Convert.ToInt32(temp) * Convert.ToInt32(temp2);
                    }
                    result[i, j] = temp3;
                }
            }
            for (int i = 0; i < this.tableLayoutPanel3.RowCount; i++)
            {
                for (int j = 0; j < this.tableLayoutPanel3.ColumnCount; j++)
                {
                    this.tableLayoutPanel3.GetControlFromPosition(i, j).Text = Convert.ToString(result[i, j]);  //wpisanie do macierzy wynikowej
                }
            }

        }

        private void C1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void C2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void C3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void C4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void C5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void C6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void C7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void C8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void C9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void wyznacznikButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)   //macierz A
        {
            
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)   //macierz B
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)   //macierz wynikowa
        {

        }

        private void C1_TextChanged(object sender, EventArgs e)
        {

        }

        private void C2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonResetujA_Click(object sender, EventArgs e)
        {
            A1.Value = 0;
            A2.Value = 0;
            A3.Value = 0;
            A4.Value = 0;
            A5.Value = 0;
            A6.Value = 0;
            A7.Value = 0;
            A8.Value = 0;
            A9.Value = 0;
        }

        private void buttonResetujB_Click(object sender, EventArgs e)
        {
            B1.Value = 0;
            B2.Value = 0;
            B3.Value = 0;
            B4.Value = 0;
            B5.Value = 0;
            B6.Value = 0;
            B7.Value = 0;
            B8.Value = 0;
            B9.Value = 0;
        }
    }
}
