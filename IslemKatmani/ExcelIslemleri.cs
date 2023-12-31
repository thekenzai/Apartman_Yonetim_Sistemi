﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IslemKatmani
{
    public static class ExcelIslemleri
    {
        public static void ExportToExcel(DataGridView dgw)
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Rapor";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < dgw.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgw.Columns.Count; j++)
                    {
                        if (cellRowIndex == 1)
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgw.Columns[j].HeaderText;
                        else
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgw.Rows[i].Cells[j].Value.ToString();
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    if (cellRowIndex == 1)
                        i = -1;
                    cellRowIndex++;

                }

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Dosya Oluşturuldu!");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
    }
}
