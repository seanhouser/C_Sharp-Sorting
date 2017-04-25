using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Sorting
{
    public partial class frmMain : Form
    {
        List<float> Input = null;
        public frmMain()
        {
            InitializeComponent();
                    
        }

        private void btnInput_Click(object sender, EventArgs e) 
        {
            CreateList();
        }

        private void CreateList()
        {
            string string_input = txtInput.Text;
            Input = string_input.Split(',').Select(float.Parse).ToList();
            rtbPresort.Text = string_input;
        }

        private void btnMerge_Click(object sender, EventArgs e) 
        {
            if (Input == null)
                CreateList();

            List<float> Helper = new List<float>(Input.Capacity);
            MergeSort(Input, Helper, 0, Input.Count);

            
            PrintResult(Input);
        }

        private void MergeSort(List<float> Input, List<float> Helper, int low, int high) 
        {
            if (low < high)
            {
                int middle = (low + high / 2);
                MergeSort(Input, Helper, low, middle);
                MergeSort(Input, Helper, middle + 1, high);
                Merge(Input, Helper, low, middle, high);
            }
        }

        private void Merge(List<float> Input, List<float> Helper, int low, int middle, int high)
        {
            for (int i = low; i <= high; ++i)
                Helper.Add(Input[i]);

            int helper_left = low;
            int helper_right = middle + 1;
            int current = low;

            while (helper_left <= middle && helper_right <= high)
            {
                if (Helper[helper_left] <= Helper[helper_right])
                {
                    Input[current] = Helper[helper_left];
                    ++helper_left;
                }
                else
                {
                    Input[current] = Helper[helper_right];
                    ++helper_right;
                }
                ++current;
            }

            int remaining = middle - helper_left;
            for (int i = 0; i <= remaining; ++i)
                Input[current + 1] = Helper[helper_left + 1];

            PrintResult(Input);
        }



        private void PrintResult(List<float> Input)
        {
            rtbPresort.Clear();
            for (int i = 0; i < Input.Count; ++i)
            {
                rtbPresort.Text += Input[i];
                rtbPresort.Text += ", ";
            }
        }
    }
}
