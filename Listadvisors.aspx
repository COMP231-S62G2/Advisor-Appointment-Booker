<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Listadvisors.aspx.cs" Inherits="Listadvisors" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


    <center><asp:Label ID="Label1" runat="server" Text="Select the Advisor:" 
        Font-Bold="True"></asp:Label>

    
    &nbsp;<select id="department" name="D1" style= "position: absolute; z-index: 10;">
        
        <option label=""></option> 
        <optgroup label="School of Advancement">     
            <option label="Khalid Ali">Khalid Ali</option>
            <option label="Holly Drover">Holly Drover</option>
        </optgroup>

        <optgroup label="School of Business">   
            <option label="Mikhail Mutafyan">Mikhail Mutafyan</option>
            <option label="Stan Cameron">Stan Cameron</option>
        </optgroup>

        <optgroup label="School of Communications">   
            <option label="John Simmons">John Simmons</option>
            <option label="Senior Sonia Martin">Senior Sonia Martin</option>
        </optgroup>

        <optgroup label="School of Engineering Technology and Applied Science">   
            <option label="Bhakti Banjara">Bhakti Banjara</option>
            <option label="Rukmani Ramasubbaralyalu">Rukmani Ramasubbaralyalu</option>
        </optgroup>

        <optgroup label="School of Hospitality and Tourism">   
            <option label="Isabella Kates">Isabella Kates</option>
            <option label="Pepi Lucas">Pepi Lucas</option>
        </optgroup>
    </select><br />
    </center>
    
</asp:Content>