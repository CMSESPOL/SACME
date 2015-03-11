using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACME
{
    class TableRdlGenerator
    {
        private List<string> m_fields;
        private List<string> m_descriptor;

        public List<string> Fields
        {
            get { return m_fields; }
            set { m_fields = value; }
        }
        public List<string> Descriptor
        {
            get { return m_descriptor; }
            set { m_descriptor = value; }
        }


        public Rdl.TableType CreateTable()
        {
            Rdl.TableType table = new Rdl.TableType();
            table.Name = "Table1";
            table.Items = new object[]
            {
                CreateTableColumns(),
                CreateHeader(),
                CreateDetails(),
                "1.02306cm",
                "1.7cm",
            };
            table.ItemsElementName = new Rdl.ItemsChoiceType21[]
            {
                Rdl.ItemsChoiceType21.TableColumns,
                Rdl.ItemsChoiceType21.Header,
                Rdl.ItemsChoiceType21.Details,
                Rdl.ItemsChoiceType21.Top,
                Rdl.ItemsChoiceType21.Left,

            };
            return table;
        }

        private Rdl.HeaderType CreateHeader()
        {
            Rdl.HeaderType header = new Rdl.HeaderType();
            header.Items = new object[]
            {
                CreateHeaderTableRows(),
            };
            header.ItemsElementName = new Rdl.ItemsChoiceType20[] 
            {
                Rdl.ItemsChoiceType20.TableRows,
            };
            return header;
        }

        private Rdl.TableRowsType CreateHeaderTableRows()
        {
            Rdl.TableRowsType headerTableRows = new Rdl.TableRowsType();
            headerTableRows.TableRow = new Rdl.TableRowType[] { CreateHeaderTableRow() };
            return headerTableRows;
        }

        private Rdl.TableRowType CreateHeaderTableRow()
        {
            Rdl.TableRowType headerTableRow = new Rdl.TableRowType();
            headerTableRow.Items = new object[] { CreateHeaderTableCells(), "0.3in" };
            return headerTableRow;
        }

        private Rdl.TableCellsType CreateHeaderTableCells()
        {
            Rdl.TableCellsType headerTableCells = new Rdl.TableCellsType();
            headerTableCells.TableCell = new Rdl.TableCellType[m_fields.Count];
            for (int i = 0; i < m_fields.Count; i++)
            {
                headerTableCells.TableCell[i] = CreateHeaderTableCell(m_fields[i], m_descriptor[i]);
            }
            return headerTableCells;
        }

        private Rdl.TableCellType CreateHeaderTableCell(string fieldName, string descriptorName)
        {
            Rdl.TableCellType headerTableCell = new Rdl.TableCellType();
            headerTableCell.Items = new object[] { CreateHeaderTableCellReportItems(fieldName, descriptorName) };
            return headerTableCell;
        }

        private Rdl.ReportItemsType CreateHeaderTableCellReportItems(string fieldName, string descriptorName)
        {
            Rdl.ReportItemsType headerTableCellReportItems = new Rdl.ReportItemsType();
            headerTableCellReportItems.Items = new object[] { CreateHeaderTableCellTextbox(fieldName, descriptorName) };
            return headerTableCellReportItems;
        }

        private Rdl.TextboxType CreateHeaderTableCellTextbox(string fieldName, string descriptorName)
        {
            Rdl.TextboxType headerTableCellTextbox = new Rdl.TextboxType();
            headerTableCellTextbox.Name = fieldName + "_Heder";
            headerTableCellTextbox.Items = new object[]
            {

                descriptorName,
                CreateHeaderTableCellTextboxStyle(),
                true,
            };
            headerTableCellTextbox.ItemsElementName = new Rdl.ItemsChoiceType14[]
            {
                Rdl.ItemsChoiceType14.Value,
                Rdl.ItemsChoiceType14.Style,
                Rdl.ItemsChoiceType14.CanGrow,
            };
            return headerTableCellTextbox;
        }

        private Rdl.StyleType CreateHeaderTableCellTextboxStyle()
        {
            Rdl.StyleType headerTableCellTextboxStyle = new Rdl.StyleType();
            headerTableCellTextboxStyle.Items = new object[]
            {
                "700",
                "11pt",
                "Center",
            };
            headerTableCellTextboxStyle.ItemsElementName = new Rdl.ItemsChoiceType5[]
            {
                Rdl.ItemsChoiceType5.FontWeight,
                Rdl.ItemsChoiceType5.FontSize,
                Rdl.ItemsChoiceType5.TextAlign,
            };
            return headerTableCellTextboxStyle;
        }

        private Rdl.DetailsType CreateDetails()
        {
            Rdl.DetailsType details = new Rdl.DetailsType();
            details.Items = new object[] { CreateTableRows() };
            return details;
        }

        private Rdl.TableRowsType CreateTableRows()
        {
            Rdl.TableRowsType tableRows = new Rdl.TableRowsType();
            tableRows.TableRow = new Rdl.TableRowType[] { CreateTableRow() };
            return tableRows;
        }

        private Rdl.TableRowType CreateTableRow()
        {
            Rdl.TableRowType tableRow = new Rdl.TableRowType();
            tableRow.Items = new object[] { CreateTableCells(), "0.25in" };
            return tableRow;
        }

        private Rdl.TableCellsType CreateTableCells()
        {
            Rdl.TableCellsType tableCells = new Rdl.TableCellsType();
            tableCells.TableCell = new Rdl.TableCellType[m_fields.Count];
            for (int i = 0; i < m_fields.Count; i++)
            {
                tableCells.TableCell[i] = CreateTableCell(m_fields[i]);
            }
            return tableCells;
        }

        private Rdl.TableCellType CreateTableCell(string fieldname)
        {
            Rdl.TableCellType tableCell = new Rdl.TableCellType();
            tableCell.Items = new object[] { CreateTableCellReportItems(fieldname) };
            return tableCell;
        }

        private Rdl.ReportItemsType CreateTableCellReportItems(string fieldName)
        {
            Rdl.ReportItemsType reportItems = new Rdl.ReportItemsType();
            reportItems.Items = new object[] { CreateTableCellTextbox(fieldName) };
            return reportItems;
        }

        private Rdl.TextboxType CreateTableCellTextbox(string fieldName)
        {
            Rdl.TextboxType textbox = new Rdl.TextboxType();
            textbox.Name = fieldName;
            textbox.Items = new object[]
            {
                "=Fields!"+ fieldName +".Value",
                CreateTableCellTextboxStyle(),
                true,
            };
            textbox.ItemsElementName = new Rdl.ItemsChoiceType14[]
            {
                Rdl.ItemsChoiceType14.Value,
                Rdl.ItemsChoiceType14.Style,
                Rdl.ItemsChoiceType14.CanGrow,
            };
            return textbox;
        }

        private Rdl.StyleType CreateTableCellTextboxStyle()
        {
            Rdl.StyleType style = new Rdl.StyleType();
            style.Items = new object[]
            {
                "=iif(RowNumber(Nothing) mod 2, \"AliceBlue\",\"White\")",
                "Center",
            };
            style.ItemsElementName = new Rdl.ItemsChoiceType5[]
            {
                Rdl.ItemsChoiceType5.BackgroundColor,
                Rdl.ItemsChoiceType5.TextAlign,
            };
            return style;
        }

        private Rdl.TableColumnsType CreateTableColumns()
        {
            Rdl.TableColumnsType tableColumns = new Rdl.TableColumnsType();
            tableColumns.TableColumn = new Rdl.TableColumnType[m_fields.Count];
            for (int i = 0; i < m_fields.Count; i++)
            {
                tableColumns.TableColumn[i] = CreateTableColumn();
            }
            return tableColumns;
        }

        private Rdl.TableColumnType CreateTableColumn()
        {
            Rdl.TableColumnType tableColumn = new Rdl.TableColumnType();
            tableColumn.Items = new object[] { "1.1in" };
            return tableColumn;
        }

    }
}
