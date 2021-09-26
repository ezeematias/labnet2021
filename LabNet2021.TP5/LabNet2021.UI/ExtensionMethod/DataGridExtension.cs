using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabNet2021.UI
{
    public static class DataGridExtension
    {
        public static DataGridView RemoveColumns(this DataGridView dgv)
        {
            foreach (DataGridViewColumn dgvColumn in dgv.Columns)
            {
                bool notAvailable = true;
                foreach (DataGridViewRow dgvRow in dgv.Rows)
                {
                    dgv.Columns[dgvColumn.Index].Visible = true;
                }
                foreach (DataGridViewRow dgvRow in dgv.Rows)
                {
                    if (dgvRow.Cells[dgvColumn.Index].Value == null)
                        notAvailable = true;
                    else if (!string.IsNullOrEmpty(dgvRow.Cells[dgvColumn.Index].Value.ToString()))
                    {
                        notAvailable = false;
                        break;
                    }
                }
                if (notAvailable)
                {
                    dgv.Columns[dgvColumn.Index].Visible = false;
                }
            }
            return dgv;
        }
    }
}
