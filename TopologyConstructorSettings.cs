﻿using System.Windows.Forms;
using software_engineering_2019.Models;

namespace software_engineering_2019
{
    public partial class TopologyConstructor
    {
        private void SetSettings()
        {
            SetField();
            SetCellsSize();

            SetSpinners();
        }

        private void SetField()
        {
            fillingStationField.RowHeadersVisible = false;
            fillingStationField.ColumnHeadersVisible = false;

            fillingStationField.AllowUserToResizeColumns = false;
            fillingStationField.AllowUserToResizeRows = false;

            fillingStationField.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            fillingStationField.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            fillingStationField.RowCount = Topology.MinNumOfCellsVertically;
            fillingStationField.ColumnCount = Topology.MinNumOfCellsHorizontally;
        }

        private void SetCellsSize()
        {
            for (int i = 0; i < fillingStationField.ColumnCount; i++)
            {
                fillingStationField.Columns[i].Width = Settings.CellSizeInPx;
            }

            for (int j = 0; j < fillingStationField.RowCount; j++)
            {
                fillingStationField.Rows[j].Height = Settings.CellSizeInPx;
            }
        }

        private void SetSpinners()
        {
            cellsHorizontally.Minimum = Topology.MinNumOfCellsHorizontally;
            cellsHorizontally.Maximum = Topology.MaxNumOfCellsHorizontally;

            cellsVertically.Minimum = Topology.MinNumOfCellsVertically;
            cellsVertically.Maximum = Topology.MaxNumOfCellsVertically;

            cellsHorizontally.Text = fillingStationField.ColumnCount.ToString();
            cellsVertically.Text = fillingStationField.RowCount.ToString();
        }
    }
}