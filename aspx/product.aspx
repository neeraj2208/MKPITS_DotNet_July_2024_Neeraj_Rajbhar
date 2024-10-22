<%@ page language="C#" autoeventwireup="true" codebehind="product.aspx.cs" inherits="Amazon_web.product" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add New Product</title>
    <style>
        /* Your existing CSS styles */
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            margin: 0;
            padding: 0;
        }

        .container {
            width: 600px;
            margin: 50px auto;
            padding: 25px;
            background-color: white;
            border-radius: 5px;
            box-shadow: 0 4px 12px rgba(0, 0, 0, 0.1);
        }

        h2 {
            color: #ff9900;
            text-align: center;
            font-weight: normal;
            margin-bottom: 20px;
        }

        label {
            display: block;
            margin-bottom: 8px;
            font-weight: bold;
            color: #333;
        }

        .form-control {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 4px;
            font-size: 14px;
            box-sizing: border-box;
        }

        .gridview {
            margin-top: 20px;
            background-color: #fff;
            border-collapse: collapse;
            width: 100%;
            text-align: left;
            box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
        }

            .gridview th, .gridview td {
                padding: 12px 15px;
                border: 1px solid #ddd;
            }

            .gridview th {
                background-color: #f8f8f8;
                font-weight: bold;
            }

        #lblMessage {
            display: block;
            margin-top: 15px;
            text-align: center;
            font-weight: bold;
            color: green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Add New Product</h2>
            <label for="txtProductName">Product Name</label>
            <asp:TextBox ID="txtProductName" runat="server" CssClass="form-control" placeholder="Enter product name"></asp:TextBox>

            <label for="fileProductImage">Product Image</label>
            <asp:FileUpload ID="fileProductImage" runat="server" CssClass="form-control" />

            <label for="txtPrice">Price</label>
            <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" placeholder="Enter price"></asp:TextBox>

            <label for="txtInStockQuantity">In Stock Quantity</label>
            <asp:TextBox ID="txtInStockQuantity" runat="server" CssClass="form-control" placeholder="Enter quantity"></asp:TextBox>

            <div style="text-align: center;">
                <asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click" />
                <asp:Button ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            </div>

            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

            <h3>Registered Products</h3>
            <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False" CssClass="gridview"
                OnSelectedIndexChanged="gvProducts_SelectedIndexChanged" DataKeyNames="ProductID">



                <Columns>
                    <asp:BoundField DataField="ProductID" HeaderText="Product ID" ReadOnly="True" />
                    <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                    <asp:TemplateField HeaderText="Product Image">
                        <ItemTemplate>
                            <asp:Image ID="ProductImage" runat="server" ImageUrl='<%# Eval("ProductImage") %>' Width="50px" Height="50px" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="InStockQuantity" HeaderText="In Stock Quantity" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
