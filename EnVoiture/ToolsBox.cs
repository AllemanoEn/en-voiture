﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnVoiture
{
    public class ToolsBox : UserControl
    {
        private TableLayoutPanel tableLayoutPanel;
        private int _waysSize = 1;
        private Route _selectedWay;

        /// <summary>
        /// propriété WayWidgets permetant d'ajouter des WayWidget dans la liste ww
        /// </summary>
        public List<RouteWidget> WayWidgets
        {
            get
            {
                List<RouteWidget> ww = new List<RouteWidget>();
                ww.Add(new RouteWidget(new Route(20, 100, _waysSize, _waysSize, new List<Orientation>() { Orientation.NORTH, Orientation.SOUTH })));
                ww.Add(new RouteWidget(new Route(20, 300, _waysSize, _waysSize, new List<Orientation>() { Orientation.EAST, Orientation.SOUTH })));
                ww.Add(new RouteWidget(new Route(20, 300, _waysSize, _waysSize, new List<Orientation>() { Orientation.EAST, Orientation.SOUTH })));
                return ww;
            }
        }

        public Route SelectedWay
        {
            get
            {
                return _selectedWay;
            }
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ToolsBox()
        {
            InitializeComponent();

            foreach (RouteWidget w in WayWidgets)
            {
                WayButton wb = new WayButton();
                wb.WayWidget = w;
                wb.Paint += new PaintEventHandler((source, e) => { w.DessinerSurOrigine(e.Graphics); });
                wb.MouseClick += new MouseEventHandler(this.WayButton_MouseClick);
                wb.Size = new Size(100,100);
                //panel.Location = new Point(this.Location.X + this.Size.Width / 2, 0);
                tableLayoutPanel.Controls.Add(wb);
            }
        }

        private void WayButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (sender is WayButton)
                {
                    _selectedWay = (sender as WayButton).WayWidget.Route;
                }
                Invalidate();
            }
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(52, 194);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // ToolsBox
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "ToolsBox";
            this.Size = new System.Drawing.Size(311, 194);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
