   M S B A M L   `   `   `  ����  tea shop app    tea_shop_app.view   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$
  view��5      .��5
      � ���#e8d87d.+�5   
   �� $��Center=�6   .+�5      �� $��products��6   $	��100��6,   $��30��68   $��16(�6D   $��SemiBold"�6R   
���r���6h   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ product_tetail��5   H   $	��250��6   $	��400��6       AutoGenerateColumns .  $��3q�6`   ���#d8e8dc � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value)  #System.Windows.Controls.DataGridRow��%  '        '  �     �� 5      "  6   .�5      ��  � ��
 ���@�64   �� 5       � ��
 �   �64   �� 5       � ��$ SemiBold"�63   �� 5       � ��$ 1q�68   5      �� 5      "  6   .�5      ��  � �� �#c3ebc863   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 40 61   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6<   �� *Prodid+  5      $  name��6%   $	 * 64   
 6>   �� *Pname+  5       $ price��6%   $	 * 64   
 6>   �� *Price+  5!      $ status��6%   $	 * 65   
 6?   �� *Status+5$      5'      5(      