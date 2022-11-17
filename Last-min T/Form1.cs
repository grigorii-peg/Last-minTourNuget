using Last_min_Tour.Models;
using Last_min_TourNu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Last_min_Tour
{
    public partial class Form1 : Form
    {
        private Last_min_TourNu.Tours<Tour> nug;
        private readonly BindingSource BinSource;
        private decimal total = 0;
        public Form1()
        {
            InitializeComponent();
            TourGridView.AutoGenerateColumns = false;
            nug = new Last_min_TourNu.Tours<Tour>();

            BinSource = new BindingSource();
            BinSource.DataSource = nug.GetList();
            TourGridView.DataSource = BinSource;
        }
        private void InfoMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пегушин Григорий, ИП-20-3", "Горящие туры",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void AddStripButton_Click(object sender, EventArgs e)
        {
            var infoForm = new InfoTour();

            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                nug.Add(infoForm.Tours);
                BinSource.ResetBindings(false);
                Statistics();
            }
        }
        private void DeleteStripButton_Click(object sender, EventArgs e)
        {
            var id = (Tour)TourGridView.Rows[TourGridView.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы хотите удалить {id.Direction} с датой отправления {id.Departure:D} Продолжить?",
                "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nug.Delete(id);
                BinSource.ResetBindings(false);
                Statistics();
            }
        }
        private void EditStripButton_Click(object sender, EventArgs e)
        {
            var id = (Tour)TourGridView.Rows[TourGridView.SelectedRows[0].Index].DataBoundItem;
            var infoForm = new InfoTour(id);
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                nug.Edit(id, infoForm.Tours);
                BinSource.ResetBindings(false);
                Statistics();
            }
        }
        private void AddMenu_Click(object sender, EventArgs e)
        {
            AddStripButton_Click(sender, e);
        }
        private void DeliteMenu_Click(object sender, EventArgs e)
        {
            DeleteStripButton_Click(sender, e);
        }
        private void ChangeMenu_Click(object sender, EventArgs e)
        {
            EditStripButton_Click(sender, e);
        }
        private void TourGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (TourGridView.Columns[e.ColumnIndex].Name == "TotalCostAmountColumn")
            {
                var data = (Tour)TourGridView.Rows[e.RowIndex].DataBoundItem;
                total += (data.NumberOfNights * data.NumberOfVacationers * data.CostVacationer) + data.Surcharges;
                e.Value = total;
                total = 0;
            }

            if (TourGridView.Columns[e.ColumnIndex].Name == "DirectionColumn")
            {
                var dir = (Direction)e.Value;
                switch (dir)
                {
                    case Direction.Turkey:
                        e.Value = "Турция";
                        break;
                    case Direction.Spain:
                        e.Value = "Испания";
                        break;
                    case Direction.Italy:
                        e.Value = "Италия";
                        break;
                    case Direction.France:
                        e.Value = "Франция";
                        break;
                    case Direction.Shushary:
                        e.Value = "Шушары";
                        break;        
                }
            }
            if (TourGridView.Columns[e.ColumnIndex].Name == "WiFiColumn")
            {
                var check = (bool)e.Value;
                switch (check)
                {
                    case true:
                        e.Value = "Есть";
                        break;
                    case false:
                        e.Value = "Нет";
                        break;
                }
            }
        }
        private void TourGridView_SelectionChanged(object sender, EventArgs e)
        {
            DeleteMenuItem.Enabled = EditMenuItem.Enabled = DeleteStripButton.Enabled = EditStripButton.Enabled = TourGridView.SelectedRows.Count > 0;
        }
        private void Statistics()
        {
            NumberOfToursStatus.Text = $"Всего туров: {nug.GetList().Count.ToString()}";

            decimal TotalCost = nug.GetList().Sum(x => (x.NumberOfNights * x.NumberOfVacationers * x.CostVacationer) + x.Surcharges);
            decimal TotalCostSurcharges = nug.GetList().Sum(x => x.Surcharges);

            TotalCostStatus.Text = $"Общая сумма: {TotalCost}";
            int NumberOfToursWithSurcharges = nug.GetList().Where(x => x.Surcharges != 0).Count();
            NumberOfToursWithSurchargesStatus.Text = $"Кол-во туров с доплатами: {NumberOfToursWithSurcharges}";
            TotalCostSurchargesStatus.Text = $"Общая сумма доплат: {TotalCostSurcharges}";
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
