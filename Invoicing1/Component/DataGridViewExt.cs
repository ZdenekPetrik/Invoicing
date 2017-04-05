using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing.Component
{
  public partial class DataGridViewExt : DataGridView
  {
    private System.ComponentModel.IContainer components = null;
    public DataGridViewExt()
    {
      InitializeComponent();
    }

    public DataGridViewExt(IContainer container)
    {
      container.Add(this);

      InitializeComponent();
    }
    public void SetColumnOrderExt()
    {
      SetColumnOrder();
    }

    private void SetColumnOrder()
    {
      if (!gfDataGridViewSetting.Default.ColumnOrder.ContainsKey(this.Name))
        return;

      List<ColumnOrderItem> columnOrder =
        gfDataGridViewSetting.Default.ColumnOrder[this.Name];

      if (columnOrder != null)
      {
        var sorted = columnOrder.OrderBy(i => i.DisplayIndex);
        foreach (var item in sorted)
        {
          if (this.Columns.Count > item.ColumnIndex)
          {
            this.Columns[item.ColumnIndex].DisplayIndex = item.DisplayIndex;
            this.Columns[item.ColumnIndex].Visible = item.Visible;
            this.Columns[item.ColumnIndex].Width = item.Width;
          }
        }
      }
    }
    //---------------------------------------------------------------------
    private void SaveColumnOrder()
    {
      if (this.AllowUserToOrderColumns)
      {
        List<ColumnOrderItem> columnOrder = new List<ColumnOrderItem>();
        DataGridViewColumnCollection columns = this.Columns;
        for (int i = 0; i < columns.Count; i++)
        {
          columnOrder.Add(new ColumnOrderItem
          {
            ColumnIndex = i,
            DisplayIndex = columns[i].DisplayIndex,
            Visible = columns[i].Visible,
            Width = columns[i].Width
          });
        }

        gfDataGridViewSetting.Default.ColumnOrder[this.Name] = columnOrder;
        gfDataGridViewSetting.Default.Save();
      }
    }
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        SaveColumnOrder();
        components.Dispose();
      }
      base.Dispose(disposing);
    }
    private void InitializeComponent()
    {
      components = new System.ComponentModel.Container();
    }
    //---------------------------------------------------------------------
    protected override void OnCreateControl()
    {
      base.OnCreateControl();
    }


  }
  internal sealed class gfDataGridViewSetting : ApplicationSettingsBase
  {
    private static gfDataGridViewSetting _defaultInstace =
      (gfDataGridViewSetting)ApplicationSettingsBase
      .Synchronized(new gfDataGridViewSetting());
    //---------------------------------------------------------------------
    public static gfDataGridViewSetting Default
    {
      get { return _defaultInstace; }
    }
    //---------------------------------------------------------------------
    // Because there can be more than one DGV in the user-application
    // a dictionary is used to save the settings for this DGV.
    // As key the name of the control is used.
    [UserScopedSetting]
    [SettingsSerializeAs(SettingsSerializeAs.Binary)]
    [DefaultSettingValue("")]
    public Dictionary<string, List<ColumnOrderItem>> ColumnOrder
    {
      get { return this["ColumnOrder"] as Dictionary<string, List<ColumnOrderItem>>; }
      set { this["ColumnOrder"] = value; }
    }
  }
  //-------------------------------------------------------------------------
  [Serializable]
  public sealed class ColumnOrderItem
  {
    public int DisplayIndex { get; set; }
    public int Width { get; set; }
    public bool Visible { get; set; }
    public int ColumnIndex { get; set; }
  }

}
