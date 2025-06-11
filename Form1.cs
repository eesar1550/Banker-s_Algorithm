using System;
using System.Windows.Forms;

namespace DeadlockDetection
{
    public partial class Form1 : Form
    {
        int processes, resources;
        int[,] allocation, max, need;
        int[] available;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            processes = int.Parse(txtProcesses.Text);
            resources = int.Parse(txtResources.Text);

            // Set row/column count
            dgvAllocation.RowCount = processes;
            dgvAllocation.ColumnCount = resources;
            dgvMax.RowCount = processes;
            dgvMax.ColumnCount = resources;
            dgvAvailable.RowCount = 1;
            dgvAvailable.ColumnCount = resources;

            // Set row headers (P0, P1, ...)
            for (int i = 0; i < processes; i++)
            {
                dgvAllocation.Rows[i].HeaderCell.Value = "P" + i;
                dgvMax.Rows[i].HeaderCell.Value = "P" + i;
            }

            // Set column headers (R0, R1, ...)
            for (int j = 0; j < resources; j++)
            {
                dgvAllocation.Columns[j].HeaderText = "R" + j;
                dgvMax.Columns[j].HeaderText = "R" + j;
                dgvAvailable.Columns[j].HeaderText = "R" + j;
            }

            // Optional: adjust column widths to fit headers
            dgvAllocation.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dgvMax.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void btnBankers_Click(object sender, EventArgs e)
        {
            ReadMatrices();
            CalculateNeed();

            if (IsSafeState(out string sequence))
            {
                lblResult.Text = "Safe State! Sequence: " + sequence;
                ShowNeedMatrix(); // Show Need matrix only in safe state
            }
            else
            {
                lblResult.Text = "Deadlock Detected! No Safe Sequence.";
                dgvNeed.Rows.Clear();
                dgvNeed.Columns.Clear();
                dgvNeed.Visible = false; // Hide Need matrix
            }
        }


        private void ReadMatrices()
        {
            allocation = new int[processes, resources];
            max = new int[processes, resources];
            available = new int[resources];

            for (int i = 0; i < processes; i++)
                for (int j = 0; j < resources; j++)
                {
                    allocation[i, j] = int.Parse(dgvAllocation.Rows[i].Cells[j].Value.ToString());
                    max[i, j] = int.Parse(dgvMax.Rows[i].Cells[j].Value.ToString());
                }

            for (int j = 0; j < resources; j++)
                available[j] = int.Parse(dgvAvailable.Rows[0].Cells[j].Value.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvAllocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtResources_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMax_Click(object sender, EventArgs e)
        {

        }

        private void dgvAvailable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CalculateNeed()
        {
            need = new int[processes, resources];
            for (int i = 0; i < processes; i++)
                for (int j = 0; j < resources; j++)
                    need[i, j] = max[i, j] - allocation[i, j];
        }
        private void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private bool IsSafeState(out string safeSequence)
        {
            int[] work = new int[resources];
            Array.Copy(available, work, resources);

            bool[] finish = new bool[processes];
            safeSequence = "";
            int count = 0;

            while (count < processes)
            {
                bool found = false;

                for (int i = 0; i < processes; i++)
                {
                    if (!finish[i])
                    {
                        bool canProceed = true;

                        // Check if all resources for this process can be satisfied
                        for (int j = 0; j < resources; j++)
                        {
                            if (need[i, j] > work[j])
                            {
                                canProceed = false;
                                break;
                            }
                        }

                        if (canProceed)
                        {
                            // Simulate process execution and resource release
                            for (int j = 0; j < resources; j++)
                            {
                                work[j] += allocation[i, j];
                            }

                            finish[i] = true;
                            found = true;
                            count++;
                            safeSequence += $"P{i} ";
                            break; // Start checking from the beginning again
                        }
                    }
                }

                if (!found)
                {
                    safeSequence = "No safe sequence exists";
                    return false;
                }
            }

            return true;
        }
        private void ShowNeedMatrix()
        {
            dgvNeed.Rows.Clear();
            dgvNeed.Columns.Clear();
            dgvNeed.RowCount = processes;
            dgvNeed.ColumnCount = resources;

            for (int j = 0; j < resources; j++)
                dgvNeed.Columns[j].HeaderText = "R" + j;

            for (int i = 0; i < processes; i++)
            {
                dgvNeed.Rows[i].HeaderCell.Value = "P" + i;
                for (int j = 0; j < resources; j++)
                {
                    dgvNeed.Rows[i].Cells[j].Value = need[i, j];
                }
            }

            dgvNeed.Visible = true;
        }


    }
}

