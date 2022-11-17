using Last_min_Tour.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Last_min_Tour
{
    public partial class InfoTour : Form
    {
        private readonly Tour tours;
        public string text;
        public InfoTour()
        {
            InitializeComponent();
            FillDirection();
            this.Text = "Добавление тура";
            tours = new Tour
            {
                Direction = Direction.Turkey,
                Departure = DateTime.Now,
                NumberOfNights = (int)NumberOfNigthsNumeric.Value,
                CostVacationer = decimal.Parse(CostVacationerTextBox.Text),
                NumberOfVacationers = (int)NumberOfVacationersNumeric.Value,
                Surcharges = decimal.Parse(SurchargesTextBox.Text),
            };

            DirectionComboBox.SelectedItem = tours.Direction;
            DepartureDateTimePicker.Value = tours.Departure;
            NumberOfNigthsNumeric.Value = tours.NumberOfNights;
            CostVacationerTextBox.Text = tours.CostVacationer.ToString();
            NumberOfVacationersNumeric.Value = tours.NumberOfVacationers;
            SurchargesTextBox.Text = tours.Surcharges.ToString();
        }
        public InfoTour(Tour source) : this()
        {
            this.Text = "Изменение тура";
            DirectionComboBox.SelectedItem = source.Direction;
            DepartureDateTimePicker.Value = source.Departure;
            NumberOfNigthsNumeric.Value = source.NumberOfNights;
            CostVacationerTextBox.Text = source.CostVacationer.ToString();
            NumberOfVacationersNumeric.Value = source.NumberOfVacationers;
            WiFiCheckBox.Checked = source.WiFi;
            SurchargesTextBox.Text = source.Surcharges.ToString();
        }
        public Tour Tours => tours;
        private void FillDirection()
        {
            foreach (Direction dir in Enum.GetValues(typeof(Direction)))
            {
                DirectionComboBox.Items.Add(dir);
            }
        }
        private void DirectionComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var parent = sender as ComboBox;
            if (parent != null)
            {
                e.DrawBackground();
                Brush brush = new SolidBrush(parent.ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    brush = SystemBrushes.HighlightText;
                }
                if (e.Index >= 0)
                {
                    if (parent.Items[e.Index] is Direction direction)
                    {
                        switch (direction)
                        {
                            case Direction.Turkey:
                                text = "Турция";
                                break;
                            case Direction.Spain:
                                text = "Испания";
                                break;
                            case Direction.Italy:
                                text = "Италия";
                                break;
                            case Direction.France:
                                text = "Франция";
                                break;
                            case Direction.Shushary:
                                text = "Шушары";
                                break;                           
                        }

                        e.Graphics.DrawString(
                            text,
                            parent.Font,
                            brush,
                            e.Bounds);
                    }
                    else
                    {
                        e.Graphics.DrawString(
                                parent.Items[e.Index].ToString(),
                                parent.Font,
                                brush,
                                e.Bounds);
                    }
                }
            }
        }
        private void DirectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DirectionComboBox.SelectedIndex >= 0)
            {
                tours.Direction = (Direction)DirectionComboBox.SelectedItem;
            }
        }
        private void DepartureDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            tours.Departure = DepartureDateTimePicker.Value;
        }
        private void NumberOfNightsNumeric_ValueChanged(object sender, EventArgs e)
        {
            tours.NumberOfNights = (int)NumberOfNigthsNumeric.Value;
        }

        private void CostVacationerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CostVacationerTextBox.Text.Length > 0)
            {
                tours.CostVacationer = decimal.Parse(CostVacationerTextBox.Text);
            }
        }
        private void NumberOfVacationersNumeric_ValueChanged(object sender, EventArgs e)
        {
            tours.NumberOfVacationers = (int)NumberOfVacationersNumeric.Value;
        }
        private void WiFiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            tours.WiFi = WiFiCheckBox.Checked;
        }
        private void SurchargesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SurchargesTextBox.Text.Length > 0)
            {
                tours.Surcharges = decimal.Parse(SurchargesTextBox.Text);
            }
        }
    }
}

